using QuickDBAccess.Model;
using System;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class DataSourceEditForm : Form {
		DataSourceModel Model;

		public DataSourceEditForm(DataSourceModel Model) {
			this.Model = Model;
			InitializeComponent();
			foreach (SQLConnectionModel model in ProgramData.Instance.Connections) {
				ConnectionComboBox.Items.Add(model.Name);
			}
			DataSourceNameTextBox.TextChanged += DataSourceNameTextBox_TextChanged;
			InitializeModelView();
		}

		private void DataSourceNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Name = DataSourceNameTextBox.Text;
			DataSourceNameTextBox.Valid = !string.IsNullOrEmpty(Model.Name);
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
			ListViewItem item = new ListViewItem(queryParameter.type);
			item.SubItems.Add(queryParameter.name);
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
			ListViewItem item = new ListViewItem(queryParameter.type);
			item.SubItems.Add(queryParameter.name);
			item.SubItems.Add(queryParameter.autoSourceColumnName);
			ParameterListView.Items.Add(item);
		}
		public DialogResult ShowNewDialog() {
			Text = "New Data Source";
			return ShowDialog();
		}
		private void OkButton_Click(object sender, System.EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void QueryRichTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Query.Command = QueryRichTextBox.Text;
		}

		private void ParameterUpButton_Click(object sender, System.EventArgs e) {
			throw new NotImplementedException();
		}

		private void ParameterDownButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void ParentParameterUpButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void ParentParameterDownButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void AddParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void AddParentParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void EditParentParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void DeleteParentParameterButton_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void ConnectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			Model.ConnectionName = ConnectionComboBox.Text;
		}
	}
}
