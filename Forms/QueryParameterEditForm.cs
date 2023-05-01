using QuickDBAccess.Model;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class QueryParameterEditForm : Form {
		QueryParameterModel Model;

		public QueryParameterEditForm(QueryParameterModel model) {
			Model = model;
			InitializeComponent();
			ParameterTextTextBox.TextChanged += ParameterNameTextBox_TextChanged;
			AutoSourceColumnTextBox.TextChanged += AutoSourceColumnTextBox_TextChanged;
			foreach(KeyValuePair<string, SqlDbType> entry in QueryParameterModel.GetTypeNames()) {
				TypeComboBox.Items.Add(entry.Key);
			}
			InitializeModelView();
		}


		public DialogResult ShowNewDialog() {
			Text = "New Parameter";
			return ShowDialog();
		}
		private void InitializeModelView() {
			ParameterTextTextBox.Text = Model.name;
			AutoSourceColumnTextBox.Text = Model.autoSourceColumnName;
			TypeComboBox.Text = Model.type;
		}
		private void ParameterNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.name = ParameterTextTextBox.Text;
			ParameterTextTextBox.Valid = !string.IsNullOrEmpty(Model.name);
		}
		private void TypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			Model.type = TypeComboBox.Text;
		}
		private void AutoSourceColumnTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.autoSourceColumnName = AutoSourceColumnTextBox.Text;
			AutoSourceColumnTextBox.Valid = !string.IsNullOrEmpty(Model.autoSourceColumnName);
		}
		private void OkButton_Click(object sender, System.EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
