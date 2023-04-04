using QuickDBAccess.Model;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class DataSourceEditForm : Form {
		DataSourceModel Model;

		public DataSourceEditForm(DataSourceModel Model) {
			this.Model = Model;
			InitializeComponent();
			InitializeModelView();
		}
		private void InitializeModelView() {
			DataSourceNameTextBox.Text = Model.Name;
		}

		private void EditParentParameterButton_Click(object sender, System.EventArgs e) {

		}

		private void button2_Click(object sender, System.EventArgs e) {

		}
	}
}
