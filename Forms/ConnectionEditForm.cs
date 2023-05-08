using QuickDBAccess.Model;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class ConnectionEditForm : Form {
		SQLConnectionModel Model;
		SQLConnectionModel ReferenceModel;
		QuickAccessModel QdbaModel;

		public ConnectionEditForm(SQLConnectionModel model, SQLConnectionModel referenceModel, QuickAccessModel qdbaModel) {
			Model = model;
			ReferenceModel = referenceModel;
			QdbaModel = qdbaModel;
			InitializeComponent();
			ConnectionNameTextBox.TextChanged += ConnectionNameTextBox_TextChanged;
			ServerTextBox.TextChanged += ServerTextBox_TextChanged;
			DatabaseTextBox.TextChanged += DatabaseTextBox_TextChanged;
			UserTextBox.TextChanged += UserTextBox_TextChanged;
			PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
			ConnectionNameTextBox.TooltipText = "Connection name required";
			InitializeModelView();
		}


		public DialogResult ShowNewDialog() {
			Text = "New Connection";
			return ShowDialog();
		}
		private void InitializeModelView() {
			ConnectionNameTextBox.Text = Model.Name;
			ServerTextBox.Text = Model.server;
			DatabaseTextBox.Text = Model.database;
			UserTextBox.Text = Model.user;
			PasswordTextBox.Text = Model.password;
			IntegratedSecurityCheckBox.Checked = Model.useIntegratedSecurity;
		}

		private void ConnectionNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Name = ConnectionNameTextBox.Text;
			if (!string.IsNullOrEmpty(Model.Name)) {
				ConnectionNameTextBox.Valid = !(QdbaModel.Connections.Exists(c => (c != ReferenceModel) && c.Name == Model.Name));
				if (!ConnectionNameTextBox.Valid) {
					ConnectionNameTextBox.TooltipText = "Another connection already exists with this name";
				}
			} else {
				ConnectionNameTextBox.Valid = false;
				ConnectionNameTextBox.TooltipText = "Connection name required";
			}
		}
		private void ServerTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.server = ServerTextBox.Text;
			ServerTextBox.Valid = !string.IsNullOrEmpty(Model.server);
		}

		private void DatabaseTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.database = DatabaseTextBox.Text;
			DatabaseTextBox.Valid = !string.IsNullOrEmpty(Model.database);
		}

		private void UserTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.user = UserTextBox.Text;
			UserTextBox.Valid = !string.IsNullOrEmpty(Model.user);
		}

		private void PasswordTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.password = PasswordTextBox.Text;
			PasswordTextBox.Valid = !string.IsNullOrEmpty(Model.password);
		}

		private void OkButton_Click(object sender, System.EventArgs e) {
			if (!ConnectionNameTextBox.Valid) {
				MessageBox.Show(ConnectionNameTextBox.TooltipText, "Quick DB Access - Error");
			} else {
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void IntegratedSecurityCheckBox_CheckedChanged(object sender, System.EventArgs e) {
			Model.useIntegratedSecurity = IntegratedSecurityCheckBox.Checked;
			if (Model.useIntegratedSecurity) {
				UserTextBox.Valid = true;
				PasswordTextBox.Valid = true;
			} else {
				UserTextBox_TextChanged(sender, e);
				PasswordTextBox_TextChanged(sender, e);
			}
			UserTextBox.Enabled = !Model.useIntegratedSecurity;
			PasswordTextBox.Enabled = !Model.useIntegratedSecurity;
		}
	}
}
