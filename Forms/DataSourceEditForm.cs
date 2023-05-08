using QuickDBAccess.Model;
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
			foreach (SQLConnectionModel connection in QdbaModel.Connections) {
				ConnectionComboBox.Items.Add(connection.Name);
			}
			DataSourceNameTextBox.TextChanged += DataSourceNameTextBox_TextChanged;
			DataSourceNameTextBox.TooltipText = "Data source name required";
			InitializeModelView();
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
		private void AddParameter(QueryParameterModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.name);
			item.SubItems.Add(queryParameter.type);
			item.SubItems.Add(queryParameter.autoSourceColumnName);
			ParameterListView.Items.Add(item);
		}
		private void RefreshParentParameterList() {
			ParentParameterListView.Items.Clear();
			foreach (QueryParameterModel parentParameter in Model.Query.ParentParameters) {
				AddParentParameter(parentParameter);
			}
		}
		private void AddParentParameter(QueryParameterModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.name);
			item.SubItems.Add(queryParameter.type);
			item.SubItems.Add(queryParameter.autoSourceColumnName);
			ParentParameterListView.Items.Add(item);
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
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ParameterDownButton_Click(object sender, EventArgs e) {
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ParentParameterUpButton_Click(object sender, EventArgs e) {
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ParentParameterDownButton_Click(object sender, EventArgs e) {
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void AddParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel();
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Query.Parameters.Add(parameter);
				AddParameter(parameter);
			}
		}

		private void EditParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel(SelectedParameter);
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedParameter = parameter;
			}
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
		}

		private void EditParentParameterButton_Click(object sender, EventArgs e) {
			QueryParameterModel parameter = new QueryParameterModel(SelectedParentParameter);
			QueryParameterEditForm parameterEditForm = new QueryParameterEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedParentParameter = parameter;
			}
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
		}

		private void ParentParameterListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewParentParameterButton.Enabled = true;
			EditParentParameterButton.Enabled = SelectedParentParameter != null;
			DeleteParentParameterButton.Enabled = SelectedParentParameter != null;
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
	}
}
