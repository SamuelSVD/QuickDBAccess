﻿using QuickDBAccess.Model;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class ConnectionEditForm : Form {
		SQLConnectionModel Model;

		public ConnectionEditForm(SQLConnectionModel model) {
			Model = model;
			InitializeComponent();
			ConnectionNameTextBox.TextChanged += ConnectionNameTextBox_TextChanged;
			ServerTextBox.TextChanged += ServerTextBox_TextChanged;
			DatabaseTextBox.TextChanged += DatabaseTextBox_TextChanged;
			UserTextBox.TextChanged += UserTextBox_TextChanged;
			PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
			InitializeModelView();
		}


		public DialogResult ShowNewDialog() {
			Text = "New Connection";
			ApplyButton.Hide();
			tableLayoutPanel4.Controls.Remove(ApplyButton);
			tableLayoutPanel4.SetColumn(OkButton, 2);
			return ShowDialog();
		}
		private void InitializeModelView() {
			ConnectionNameTextBox.Text = Model.Name;
			ServerTextBox.Text = Model.server;
			DatabaseTextBox.Text = Model.database;
			UserTextBox.Text = Model.user;
			PasswordTextBox.Text = Model.password;
		}

		private void ConnectionNameTextBox_TextChanged(object sender, System.EventArgs e) {
			Model.Name = ConnectionNameTextBox.Text;
			ConnectionNameTextBox.Valid = !string.IsNullOrEmpty(Model.Name);
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
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
