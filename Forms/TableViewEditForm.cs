using QuickDBAccess.Model;
using QuickDBAccess.Properties;
using QuickDBAccess.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class TableViewEditForm : Form {
		TableViewModel Model;
		public QuickAccessModel QdbaModel { get; private set; }

		public ButtonModel SelectedButton {
			get {
				if (ButtonListView.SelectedIndices.Count <= 0) return null;
				return Model.Buttons[ButtonListView.SelectedIndices[0]];
			}
			set {
				if (ButtonListView.SelectedIndices.Count <= 0) return;
				ButtonModel originalModel = Model.Buttons[ButtonListView.SelectedIndices[0]];
				Model.Buttons[ButtonListView.SelectedIndices[0]].Apply(value);
				ListViewItem item = ButtonListView.SelectedItems[0];
				item.SubItems[0].Text = value.Text;
				item.SubItems[1].Text = value.DataSourceName;
			}
		}
		public TableViewModel SelectedTableView {
			get {
				if (TableViewListView.SelectedIndices.Count <= 0) return null;
				return Model.ChildTableViews[TableViewListView.SelectedIndices[0]];
			}
			set {
				if (TableViewListView.SelectedIndices.Count <= 0) return;
				TableViewModel originalModel = Model.ChildTableViews[TableViewListView.SelectedIndices[0]];
				Model.ChildTableViews[TableViewListView.SelectedIndices[0]].Apply(value);
				ListViewItem item = TableViewListView.SelectedItems[0];
				item.SubItems[0].Text = value.Name;
				item.SubItems[1].Text = value.ContentDataSourceName;
				item.SubItems[2].Text = value.ChildTableViews.Count.ToString();
			}
		}

		public TableViewEditForm(TableViewModel model, QuickAccessModel qdbaModel) {
			this.Model = model;
			this.QdbaModel = qdbaModel;
			InitializeComponent();
			InitializeLocalization();
			foreach (DataSourceModel dsModel in qdbaModel.DataSources) {
				DataSourceComboBox.Items.Add(dsModel.Name);
			}
			TableViewNameTextBox.TextChanged += TableViewNameTextBox_TextChanged;
			InitializeModelView();
			ButtonListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			TableViewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void InitializeLocalization() {
			TableViewsDownButton.SetTooltip(Strings.Form_TableViewsDownButton_Tooltip);
			TableViewsUpButton.SetTooltip(Strings.Form_TableViewsUpButton_Tooltip);
			DeleteTableViewButton.SetTooltip(Strings.Form_DeleteTableViewButton_Tooltip);
			EditTableViewButton.SetTooltip(Strings.Form_EditTableViewButton_Tooltip);
			NewTableViewButton.SetTooltip(Strings.Form_NewTableViewButton_Tooltip);
			ButtonsDownButton.SetTooltip(Strings.Form_ButtonsDownButton_Tooltip);
			ButtonsUpButton.SetTooltip(Strings.Form_ButtonsUpButton_Tooltip);
			DeleteButtonButton.SetTooltip(Strings.Form_DeleteButtonButton_Tooltip);
			EditButtonButton.SetTooltip(Strings.Form_EditButtonButton_Tooltip);
			NewButtonButton.SetTooltip(Strings.Form_NewButtonButton_Tooltip);
		}
		private void InitializeModelView() {
			TableViewNameTextBox.Text = Model.Name;
			DataSourceComboBox.Text = Model.ContentDataSourceName;
			RefreshButtonList();
			RefreshTableViewList();
		}
		private void RefreshButtonList() {
			ButtonListView.Items.Clear();
			foreach (ButtonModel parameter in Model.Buttons) {
				AddButton(parameter);
			}
		}
		private ListViewItem AddButton(ButtonModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.Text);
			item.SubItems.Add(queryParameter.DataSourceName);
			ButtonListView.Items.Add(item);
			ButtonListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		private void RefreshTableViewList() {
			TableViewListView.Items.Clear();
			foreach (TableViewModel parameter in Model.ChildTableViews) {
				AddTableView(parameter);
			}
		}
		private ListViewItem AddTableView(TableViewModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.Name);
			item.SubItems.Add(queryParameter.ContentDataSourceName);
			item.SubItems.Add(queryParameter.ChildTableViews.Count.ToString());
			TableViewListView.Items.Add(item);
			TableViewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			return item;
		}
		public DialogResult ShowNewDialog() {
			Text = "New Table View";
			return ShowDialog();
		}
		private void TableViewNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Name = TableViewNameTextBox.Text;
			TableViewNameTextBox.Valid = !string.IsNullOrEmpty(Model.Name);
		}
		private void OkButton_Click(object sender, System.EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void ButtonsUpButton_Click(object sender, System.EventArgs e) {
			ButtonModel p = SelectedButton;
			int oldIndex = Model.Buttons.IndexOf(p);
			ListViewItem item = ButtonListView.Items[oldIndex];
			Model.Buttons.RemoveAt(oldIndex);
			Model.Buttons.Insert(oldIndex - 1, p);
			ButtonListView.Items.RemoveAt(oldIndex);
			ButtonListView.Items.Insert(oldIndex - 1, item);
		}

		private void ButtonsDownButton_Click(object sender, EventArgs e) {
			ButtonModel p = SelectedButton;
			int oldIndex = Model.Buttons.IndexOf(p);
			ListViewItem item = ButtonListView.Items[oldIndex];
			Model.Buttons.RemoveAt(oldIndex);
			Model.Buttons.Insert(oldIndex + 1, p);
			ButtonListView.Items.RemoveAt(oldIndex);
			ButtonListView.Items.Insert(oldIndex + 1, item);
		}

		private void NewButtonButton_Click(object sender, EventArgs e) {
			ButtonModel buttonModel = new ButtonModel();
			ButtonEditForm buttonEditForm = new ButtonEditForm(buttonModel, QdbaModel);
			if (buttonEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Buttons.Add(buttonModel);
				AddButton(buttonModel);
			}
			buttonEditForm.Dispose();
			this.DialogResult = DialogResult.None;
		}

		private void EditButtonButton_Click(object sender, EventArgs e) {
			ButtonModel parameter = new ButtonModel(SelectedButton);
			ButtonEditForm parameterEditForm = new ButtonEditForm(parameter, QdbaModel);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedButton = parameter;
			}
			parameterEditForm.Dispose();
			this.DialogResult = DialogResult.None;
		}

		private void DeleteButtonButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this button?", "Delete Button", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					Model.Buttons.Remove(SelectedButton);
					ButtonListView.Items.RemoveAt(ButtonListView.SelectedIndices[0]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void TableViewUpButton_Click(object sender, EventArgs e) {
			TableViewModel tvm = SelectedTableView;
			int oldIndex = Model.ChildTableViews.IndexOf(tvm);
			ListViewItem item = TableViewListView.Items[oldIndex];
			Model.ChildTableViews.RemoveAt(oldIndex);
			Model.ChildTableViews.Insert(oldIndex - 1, tvm);
			TableViewListView.Items.RemoveAt(oldIndex);
			TableViewListView.Items.Insert(oldIndex - 1, item);
		}

		private void TableViewDownButton_Click(object sender, EventArgs e) {
			TableViewModel tvm = SelectedTableView;
			int oldIndex = Model.ChildTableViews.IndexOf(tvm);
			ListViewItem item = TableViewListView.Items[oldIndex];
			Model.ChildTableViews.RemoveAt(oldIndex);
			Model.ChildTableViews.Insert(oldIndex + 1, tvm);
			TableViewListView.Items.RemoveAt(oldIndex);
			TableViewListView.Items.Insert(oldIndex + 1, item);
		}

		private void NewTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel tableViewModel = new TableViewModel();
			TableViewEditForm tableViewEditForm = new TableViewEditForm(tableViewModel, QdbaModel);
			if (tableViewEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.ChildTableViews.Add(tableViewModel);
				AddTableView(tableViewModel);
			}
			tableViewEditForm.Dispose();
		}

		private void EditTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel tableViewModel = new TableViewModel(SelectedTableView);
			TableViewEditForm tableViewEditForm = new TableViewEditForm(tableViewModel, QdbaModel);
			if (tableViewEditForm.ShowDialog() == DialogResult.OK) {
				SelectedTableView = tableViewModel;
			}
			tableViewEditForm.Dispose();
		}

		private void DeleteTableViewButton_Click(object sender, EventArgs e) {
			try {
				if (MessageBox.Show("Delete this table view?", "Delete Table View", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
					Model.ChildTableViews.Remove(SelectedTableView);
					TableViewListView.Items.RemoveAt(TableViewListView.SelectedIndices[0]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void DataSourceComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			Model.ContentDataSourceName = DataSourceComboBox.Text;
		}

		private void ButtonListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewButtonButton.Enabled = true;
			EditButtonButton.Enabled = SelectedButton != null;
			DeleteButtonButton.Enabled = SelectedButton != null;
			ButtonsUpButton.Enabled = Model.Buttons.Count > 1 && ButtonListView.SelectedIndices.Count > 0 && ButtonListView.SelectedIndices[0] > 0;
			ButtonsDownButton.Enabled = Model.Buttons.Count > 1 && ButtonListView.SelectedIndices.Count > 0 && ButtonListView.SelectedIndices[0] < Model.Buttons.Count - 1;
		}

		private void TableViewListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewTableViewButton.Enabled = true;
			EditTableViewButton.Enabled = SelectedTableView != null;
			DeleteTableViewButton.Enabled = SelectedTableView != null;
			TableViewsUpButton.Enabled = Model.ChildTableViews.Count > 1 && TableViewListView.SelectedIndices.Count > 0 && TableViewListView.SelectedIndices[0] > 0;
			TableViewsDownButton.Enabled = Model.ChildTableViews.Count > 1 && TableViewListView.SelectedIndices.Count > 0 && TableViewListView.SelectedIndices[0] < Model.ChildTableViews.Count - 1;
		}
		private void ChangeEnableDisable(Button button, Bitmap enabledImage, Bitmap disabledImage) {
			if (button.Enabled) {
				button.BackgroundImage = enabledImage;
			} else {
				button.BackgroundImage = disabledImage;
			}
		}
		private void EditButtonButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditButtonButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}
		private void DeleteButtonButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteButtonButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}
		private void EditTableViewButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(EditTableViewButton, Properties.Resources.edit, Properties.Resources.edit_disabled);
		}
		private void DeleteTableViewButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(DeleteTableViewButton, Properties.Resources.delete, Properties.Resources.delete_disabled);
		}

		private void ButtonsUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ButtonsUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void ButtonsDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(ButtonsDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}

		private void TableViewUpButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(TableViewsUpButton, Properties.Resources.up, Properties.Resources.up_disabled);
		}

		private void TableViewDownButton_EnabledChanged(object sender, EventArgs e) {
			ChangeEnableDisable(TableViewsDownButton, Properties.Resources.down, Properties.Resources.down_disabled);
		}

		private void ButtonListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedButton != null) {
				EditButtonButton_Click(sender, e);
			}
		}

		private void TableViewListView_DoubleClick(object sender, EventArgs e) {
			if (SelectedTableView != null) {
				EditTableViewButton_Click(sender, e);
			}
		}

		private void ButtonListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (ButtonsUpButton.Enabled) {
							ButtonsUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (ButtonsDownButton.Enabled) {
							ButtonsDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditButtonButton.Enabled) {
							EditButtonButton_Click(sender, e);
						}
						break;
				}
			}
		}

		private void TableViewListView_KeyDown(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.Up:
						if (TableViewsUpButton.Enabled) {
							TableViewUpButton_Click(sender, e);
						}
						break;
					case Keys.Down:
						if (TableViewsDownButton.Enabled) {
							TableViewDownButton_Click(sender, e);
						}
						break;
				}
			} else {
				switch (e.KeyCode) {
					case Keys.Enter:
					case Keys.F2:
						if (EditTableViewButton.Enabled) {
							EditTableViewButton_Click(sender, e);
						}
						break;
				}
			}
		}
		private void DuplicateButtonToolStripMenuItem_Click(object sender, EventArgs e) {
			ButtonModel buttonOriginal = SelectedButton;
			ButtonModel buttonCopy = new ButtonModel(buttonOriginal);
			int oldIndex = Model.Buttons.IndexOf(buttonOriginal);
			Model.Buttons.Insert(oldIndex + 1, buttonCopy);
			ListViewItem item = AddButton(buttonCopy);
			ButtonListView.Items.Remove(item);
			ButtonListView.Items.Insert(oldIndex + 1, item);
		}
		private void ButtonListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = ButtonListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					ButtonsContextMenu.Show(Cursor.Position);
				}
			}
		}
		private void DuplicateTableViewToolStripMenuItem_Click(object sender, EventArgs e) {
			TableViewModel tableViewOriginal = SelectedTableView;
			TableViewModel tableViewCopy = new TableViewModel(tableViewOriginal);
			int oldIndex = Model.ChildTableViews.IndexOf(tableViewOriginal);
			Model.ChildTableViews.Insert(oldIndex + 1, tableViewCopy);
			ListViewItem item = AddTableView(tableViewCopy);
			TableViewListView.Items.Remove(item);
			TableViewListView.Items.Insert(oldIndex + 1, item);
		}
		private void TableViewListView_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				var focusedItem = TableViewListView.FocusedItem;
				if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
					TableViewsContextMenu.Show(Cursor.Position);
				}
			}
		}
	}
}
