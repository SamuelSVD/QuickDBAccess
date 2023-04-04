using QuickDBAccess.Model;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class TableViewEditForm : Form {
		TableViewModel Model;

		public TableViewEditForm(TableViewModel Model) {
			this.Model = Model;
			InitializeComponent();
			InitializeModelView();
		}
		private void InitializeModelView() {
			TableViewNameTextBox.Text = Model.Name;
			DataSourceComboBox.Text = Model.ContentDataSourceName;
		}
	}
}
