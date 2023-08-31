using QuickDBAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class DataFilterForm : Form {
		public DataFilterModel Model;
		List<string> ColumnNames;
		public DataFilterForm(DataFilterModel model, List<string> columnNames) {
			InitializeComponent();
			Model = new DataFilterModel(model);
			ColumnNames = columnNames;
			InitializeViewModel();
		}
		public void InitializeViewModel() {
			foreach(string columnName in ColumnNames) {
				ColumnComboBox.Items.Add(columnName);
			}
			ColumnComboBox.SelectedIndex = Model.ColumnIndex;
			ExpressionComboBox.Items.Add("contains");
			ExpressionComboBox.Items.Add("equals");
			ExpressionComboBox.Items.Add("does not equal");
			switch (Model.Expression) {
				case DataFilterModel.ComparisonExpression.Contains:
					ExpressionComboBox.Text = "contains";
					break;
				case DataFilterModel.ComparisonExpression.Equals:
					ExpressionComboBox.Text = "equals";
					break;
				case DataFilterModel.ComparisonExpression.NotEquals:
					ExpressionComboBox.Text = "does not equal";
					break;
			}
			TextTextBox.Text = Model.Text;
		}
		private void OkButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}
		private void CancelButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void ClearButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Abort;
			Close();
		}

		private void ColumnComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			Model.ColumnIndex = ColumnComboBox.SelectedIndex;
		}

		private void ExpressionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			switch (ExpressionComboBox.Text) {
				case "contains":
					Model.Expression = DataFilterModel.ComparisonExpression.Contains;
					break;
				case "equals":
					Model.Expression = DataFilterModel.ComparisonExpression.Equals;
					break;
				case "does not equal":
					Model.Expression = DataFilterModel.ComparisonExpression.NotEquals; 
					break;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			Model.Text = TextTextBox.Text;
		}
	}
}
