using QuickDBAccess.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class TableViewEditForm : Form {
		TableViewModel Model;

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

		public TableViewEditForm(TableViewModel Model) {
			this.Model = Model;
			InitializeComponent();
			foreach (DataSourceModel model in ProgramData.Instance.DataSources) {
				DataSourceComboBox.Items.Add(model.Name);
			}
			TableViewNameTextBox.TextChanged += TableViewNameTextBox_TextChanged;
			InitializeModelView();
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
		private void AddButton(ButtonModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.Text);
			item.SubItems.Add(queryParameter.DataSourceName);
			ButtonListView.Items.Add(item);
		}
		private void RefreshTableViewList() {
			TableViewListView.Items.Clear();
			foreach (TableViewModel parameter in Model.ChildTableViews) {
				AddTableView(parameter);
			}
		}
		private void AddTableView(TableViewModel queryParameter) {
			ListViewItem item = new ListViewItem(queryParameter.Name);
			item.SubItems.Add(queryParameter.ContentDataSourceName);
			item.SubItems.Add(queryParameter.ChildTableViews.Count.ToString());
			TableViewListView.Items.Add(item);
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
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonsDownButton_Click(object sender, EventArgs e) {
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void NewButtonButton_Click(object sender, EventArgs e) {
			ButtonModel parameter = new ButtonModel();
			ButtonEditForm parameterEditForm = new ButtonEditForm(parameter);
			if (parameterEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.Buttons.Add(parameter);
				AddButton(parameter);
			}
		}

		private void EditButtonButton_Click(object sender, EventArgs e) {
			ButtonModel parameter = new ButtonModel(SelectedButton);
			ButtonEditForm parameterEditForm = new ButtonEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedButton = parameter;
			}
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
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void TableViewDownButton_Click(object sender, EventArgs e) {
			try {
				throw new NotImplementedException();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void NewTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel parameter = new TableViewModel();
			TableViewEditForm parameterEditForm = new TableViewEditForm(parameter);
			if (parameterEditForm.ShowNewDialog() == DialogResult.OK) {
				Model.ChildTableViews.Add(parameter);
				AddTableView(parameter);
			}
		}

		private void EditTableViewButton_Click(object sender, EventArgs e) {
			TableViewModel parameter = new TableViewModel(SelectedTableView);
			TableViewEditForm parameterEditForm = new TableViewEditForm(parameter);
			if (parameterEditForm.ShowDialog() == DialogResult.OK) {
				SelectedTableView = parameter;
			}
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
		}

		private void TableViewListView_SelectedIndexChanged(object sender, EventArgs e) {
			NewButtonButton.Enabled = true;
			EditButtonButton.Enabled = SelectedTableView != null;
			DeleteButtonButton.Enabled = SelectedTableView != null;
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
	}
}
