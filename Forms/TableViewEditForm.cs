using QuickDBAccess.Model;
using System;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class TableViewEditForm : Form {
		TableViewModel Model;

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
			throw new NotImplementedException();
		}

		private void ButtonsDownButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void NewButtonButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditButtonButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteButtonButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void TableViewUpButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void TableViewDownButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void NewTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteTableViewButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DataSourceComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			Model.ContentDataSourceName = DataSourceComboBox.Text;
		}

		private void ParameterListView_SelectedIndexChanged(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void ParentParameterListView_SelectedIndexChanged(object sender, EventArgs e) {
			throw new NotImplementedException();
		}
	}
}
