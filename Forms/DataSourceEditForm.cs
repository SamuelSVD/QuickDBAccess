﻿using QuickDBAccess.Model;
using QuickDBAccess.Properties;
using QuickDBAccess.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class DataSourceEditForm : Form {
		DataSourceModel Model;
		DataSourceModel ReferenceModel;
		QuickAccessModel QdbaModel;

		public QueryParameterModel SelectedParameter {
			get {
				if (ParameterListView.SelectedIndices.Count <= 0) return null;
				return Model.Query.Parameters[ParameterListView.SelectedIndices[0]];
			}
			set {
				if (ParameterListView.SelectedIndices.Count <= 0) return;
				QueryParameterModel originalModel = Model.Query.Parameters[ParameterListView.SelectedIndices[0]];
				originalModel.Apply(value);
				ListViewItem item = ParameterListView.SelectedItems[0];
				item.SubItems[0].Text = value.name;
				item.SubItems[1].Text = value.type;
				item.SubItems[2].Text = value.autoSourceColumnName;
			}
		}
		public QueryParameterModel SelectedParentParameter {
			get {
				if (ParentParameterListView.SelectedIndices.Count <= 0) return null;
				return Model.Query.ParentParameters[ParentParameterListView.SelectedIndices[0]];
			}
			set {
				if (ParentParameterListView.SelectedIndices.Count <= 0) return;
				QueryParameterModel originalModel = Model.Query.ParentParameters[ParentParameterListView.SelectedIndices[0]];
				originalModel.Apply(value);
				ListViewItem item = ParentParameterListView.SelectedItems[0];
				item.SubItems[0].Text = value.name;
				item.SubItems[1].Text = value.type;
				item.SubItems[2].Text = value.autoSourceColumnName;
			}
		}
		public DataSourceEditForm(DataSourceModel model, DataSourceModel referenceModel, QuickAccessModel qdbaModel) {
			this.Model = model;
			this.ReferenceModel = referenceModel;
			this.QdbaModel = qdbaModel;
			InitializeComponent();
			InitializeLocalization();
			foreach (SQLConnectionModel connection in QdbaModel.Connections) {
				ConnectionComboBox.Items.Add(connection.Name);
			}
			DataSourceNameTextBox.TextChanged += DataSourceNameTextBox_TextChanged;
			DataSourceNameTextBox.TooltipText = "Data source name required";
			InitializeModelView();
			ParameterListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			ParentParameterListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void InitializeLocalization() {
			NewParameterButton.SetTooltip(Strings.Form_NewParameterButton_Tooltip);
			EditParameterButton.SetTooltip(Strings.Form_EditParameterButton_Tooltip);
			DeleteParameterButton.SetTooltip(Strings.Form_DeleteParameterButton_Tooltip);
			NewParentParameterButton.SetTooltip(Strings.Form_NewParentParameterButton_Tooltip);
			EditParentParameterButton.SetTooltip(Strings.Form_EditParentParameterButton_Tooltip);
			DeleteParentParameterButton.SetTooltip(Strings.Form_DeleteParentParameterButton_Tooltip);
			ParentParameterUpButton.SetTooltip(Strings.Form_ParentParameterUpButton_Tooltip);
			ParameterUpButton.SetTooltip(Strings.Form_ParameterUpButton_Tooltip);
			ParameterDownButton.SetTooltip(Strings.Form_ParameterDownButton_Tooltip);
			ParentParameterDownButton.SetTooltip(Strings.Form_ParentParameterDownButton_Tooltip);
		}
		private void DataSourceNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Name = DataSourceNameTextBox.Text;
			if (!string.IsNullOrEmpty(Model.Name)) {
				DataSourceNameTextBox.Valid = !(QdbaModel.DataSources.Exists(ds => (ds != ReferenceModel) && ds.Name == Model.Name));
				if (!DataSourceNameTextBox.Valid) {
					DataSourceNameTextBox.TooltipText = "Another data source already exists with this name";
				}
			} else {
				DataSourceNameTextBox.Valid = false;
				DataSourceNameTextBox.TooltipText = "Data source name required";
			}
		}

		private void InitializeModelView() {
			DataSourceNameTextBox.Text = Model.Name;
			ConnectionComboBox.Text = Model.ConnectionName;
			QueryRichTextBox.Text = Model.Query.Command;
			RefreshParameterList();
			RefreshParentParameterList();
		}
		private void RefreshParameterList() {
			ParameterListView.Items.Clear();
			foreach (QueryParameterModel parameter in Model.Query.Parameters) {
				AddParameter(parameter);
			}
		}
		private ListViewItem AddParameter(QueryParameterModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.name);
			item.SubItems.Add(queryParameter.type);
			item.SubItems.Add(queryParameter.autoSourceColumnName);
			ParameterListView.Items.Add(item);
			ParameterListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		private void RefreshParentParameterList() {
			ParentParameterListView.Items.Clear();
			foreach (QueryParameterModel parentParameter in Model.Query.ParentParameters) {
				AddParentParameter(parentParameter);
			}
		}
		private ListViewItem AddParentParameter(QueryParameterModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.name);
			item.SubItems.Add(queryParameter.type);
			item.SubItems.Add(queryParameter.autoSourceColumnName);
			ParentParameterListView.Items.Add(item);
			ParentParameterListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		public DialogResult ShowNewDialog() {
			Text = "New Data Source";
			return ShowDialog();
		}
		private void OkButton_Click(object sender, System.EventArgs e) {
			if (!DataSourceNameTextBox.Valid) {
				MessageBox.Show(DataSourceNameTextBox.TooltipText, "Quick DB Access - Error");
			} else {
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void QueryRichTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Query.Command = QueryRichTextBox.Text;
		}

		private void ParameterUpButton_Click(object sender, System.EventArgs e) {
			QueryParameterModel p = SelectedParameter;
			int oldIndex = Model.Query.Parameters.IndexOf(p);
			ListViewItem item = ParameterListView.Items[oldIndex];
			Model.Query.Parameters.RemoveAt(oldIndex);
			Model.Query.Parameters.Insert(oldIndex - 1, p);
			ParameterListView.Items.RemoveAt(oldIndex);
			ParameterListView.Items.Insert(oldIndex - 1, item);
		}

		private void ParameterDownButton_Click(object sender, EventArgs e) {
			QueryParameterModel p = SelectedParameter;
			int oldIndex = Model.Query.Parameters.IndexOf(p);
			ListViewItem item = ParameterListView.Items[oldIndex];
			Model.Query.Parameters.RemoveAt(oldIndex);
			Model.Query.Parameters.Insert(oldIndex + 1, p);
			ParameterListView.Items.RemoveAt(oldIndex);
			ParameterListView.Items.Insert(oldIndex + 1, item);
		}

		private void ParentParameterUpButton_Click(object sender, EventArgs e) {
			QueryParameterModel pp = SelectedParentParameter;
			int oldIndex = Model.Query.ParentParameters.IndexOf(pp);
			ListViewItem item = ParentParameterListView.Items[oldIndex];
			Model.Query.ParentParameters.RemoveAt(oldIndex);
			Model.Query.ParentParameters.Insert(oldIndex - 1, pp);
			ParentParameterListView.Items.RemoveAt(oldIndex);
			ParentParameterListView.Items.Insert(oldIndex - 1, item);
		}

		private void ParentParameterDownButton_Click(object sender, EventArgs e) {
			QueryParameterModel pp = SelectedParentParameter;
			int oldIndex = Model.Query.ParentParameters.IndexOf(pp);
			ListViewItem item = ParentParameterListView.Items[oldIndex];
			Model.Query.ParentParameters.RemoveAt(oldIndex);
			Model.Query.ParentParameters.Insert(oldIndex + 1, pp);
			ParentParameterListView.Items.RemoveAt(oldIndex);
			ParentParameterListView.Items.Insert(oldIndex + 1, item);
		}

		private void AddParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel();
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Query.Parameters.Add(parameter);
				AddParameter(parameter);
			}
			parameterEditForm.Dispose();
		}

		private void EditParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel(SelectedParameter);
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedParameter = parameter;
			}
			parameterEditForm.Dispose();
		}

		private void DeleteParameterButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this parameter?", "Delete Parameter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					Model.Query.Parameters.Remove(SelectedParameter);
					ParameterListView.Items.RemoveAt(ParameterListView.SelectedIndices[0]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void AddParentParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel();
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Query.ParentParameters.Add(parameter);
				AddParentParameter(parameter);
			}
			parameterEditForm.Dispose();
		}

		private void EditParentParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel(SelectedParentParameter);
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedParentParameter = parameter;
			}
			parameterEditForm.Dispose();
		}

		private void DeleteParentParameterButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this parent parameter?", "Delete Parent Parameter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					Model.Query.ParentParameters.Remove(SelectedParentParameter);
					ParentParameterListView.Items.RemoveAt(ParentParameterListView.SelectedIndices[0]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ConnectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			Model.ConnectionName = ConnectionComboBox.Text;
		}

		private void ParameterListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewParameterButton.Enabled = true;
			EditParameterButton.Enabled = SelectedParameter != null;
			DeleteParameterButton.Enabled = SelectedParameter != null;
			ParameterUpButton.Enabled = Model.Query.Parameters.Count > 1 && ParameterListView.SelectedIndices.Count > 0 && ParameterListView.SelectedIndices[0] > 0;
			ParameterDownButton.Enabled = Model.Query.Parameters.Count > 1 && ParameterListView.SelectedIndices.Count > 0 && ParameterListView.SelectedIndices[0] < Model.Query.Parameters.Count - 1;
		}

		private void ParentParameterListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewParentParameterButton.Enabled = true;
			EditParentParameterButton.Enabled = SelectedParentParameter != null;
			DeleteParentParameterButton.Enabled = SelectedParentParameter != null;
			ParentParameterUpButton.Enabled = Model.Query.ParentParameters.Count > 1 && ParentParameterListView.SelectedIndices.Count > 0 && ParentParameterListView.SelectedIndices[0] > 0;
			ParentParameterDownButton.Enabled = Model.Query.ParentParameters.Count > 1 && ParentParameterListView.SelectedIndices.Count > 0 && ParentParameterListView.SelectedIndices[0] < Model.Query.ParentParameters.Count - 1;
		}
		private void ChangeEnableDisable(Button button, Bitmap enabledImage, Bitmap disabledImage) {
			if (button.Enabled) {
				button.BackgroundImage = enabledImage;
			} else {
				button.BackgroundImage = disabledImage;
			}
		}
		private void EditParameterButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditParameterButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}
		private void DeleteParameterButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteParameterButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}
		private void EditParentParameterButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditParentParameterButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}
		private void DeleteParentParameterButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteParentParameterButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}

		private void ParameterUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ParameterUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void ParameterDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ParameterDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}

		private void ParentParameterUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ParentParameterUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void ParentParameterDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ParentParameterDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}

		private void ParameterListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedParameter != null) {
				EditParameterButton_Click(sender, e);
			}
		}

		private void ParentParameterListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedParentParameter != null) {
				EditParentParameterButton_Click(sender, e);
			}
		}

		private void ParameterListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (ParameterUpButton.Enabled) {
							ParameterUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (ParameterDownButton.Enabled) {
							ParameterDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditParameterButton.Enabled) {
							EditParameterButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void ParentParameterListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (ParentParameterUpButton.Enabled) {
							ParentParameterUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (ParentParameterDownButton.Enabled) {
							ParentParameterDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditParentParameterButton.Enabled) {
							EditParentParameterButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void ParameterDuplicateToolStripMenuItem_Click(object sender, EventArgs e) {
			QueryParameterModel paramOriginal = SelectedParameter;
			QueryParameterModel paramCopy = new QueryParameterModel(paramOriginal);
			int oldIndex = Model.Query.Parameters.IndexOf(paramOriginal);
			Model.Query.Parameters.Insert(oldIndex + 1, paramCopy);
			ListViewItem item = AddParameter(paramCopy);
			ParameterListView.Items.Remove(item);
			ParameterListView.Items.Insert(oldIndex + 1, item);

		}
		private void ParameterListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = ParameterListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					ParameterContextMenu.Show(Cursor.Position);
				}
			}
		}

		private void ParentParameterDuplicateStripMenuItem_Click(object sender, EventArgs e) {
			QueryParameterModel paramOriginal = SelectedParentParameter;
			QueryParameterModel paramCopy = new QueryParameterModel(paramOriginal);
			int oldIndex = Model.Query.ParentParameters.IndexOf(paramOriginal);
			Model.Query.ParentParameters.Insert(oldIndex + 1, paramCopy);
			ListViewItem item = AddParentParameter(paramCopy);
			ParentParameterListView.Items.Remove(item);
			ParentParameterListView.Items.Insert(oldIndex + 1, item);
		}

		private void ParentParameterListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = ParameterListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					ParentParameterContextMenu.Show(Cursor.Position);
				}
			}
		}
	}
}
