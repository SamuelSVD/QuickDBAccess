using QuickDBAccess.Model;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class ButtonEditForm : Form {
		ButtonModel Model;

		public ButtonEditForm(ButtonModel model) {
			Model = model;
			InitializeComponent();
			ConnectionNameTextBox.TextChanged += ConnectionNameTextBox_TextChanged;
			foreach (DataSourceModel dataSource in ProgramData.Instance.DataSources) {
				DataSourceComboBox.Items.Add(dataSource.Name);
			}
			InitializeModelView();
		}

		public DialogResult ShowNewDialog() {
			Text = "New Button";
			return ShowDialog();
		}
		private void InitializeModelView() {
			ConnectionNameTextBox.Text = Model.Text;
			DataSourceComboBox.Text = Model.DataSourceName;
		}

		private void ConnectionNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Text = ConnectionNameTextBox.Text;
			ConnectionNameTextBox.Valid = !string.IsNullOrEmpty(Model.Text);
		}

		private void OkButton_Click(object sender, System.EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}

		private void DataSourceComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			Model.DataSourceName = DataSourceComboBox.Text;
		}

		private void ConnectionNameTextBox_Load(object sender, System.EventArgs e) {

		}
	}
}
