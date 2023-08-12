using QuickDBAccess.Properties;
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
	public partial class HomeForm : Form {
		public Control Content {
			get {
				return contentGroupBox;
			}
		}
		public HomeForm() {
			InitializeComponent();
			InitializeRecentFiles();
		}

		private void InitializeRecentFiles() {
			if (Settings.Default.RecentFiles == null) {
				Settings.Default.RecentFiles = new List<string>();
				RecentFilesGroupBox.Visible= false;
			}
			foreach (string recentFile in Settings.Default.RecentFiles) {
				Button b = new Button();
				b.Text = recentFile;
				b.AutoSize = true;
				b.Dock = DockStyle.Top;
				RecentFilesTableLayoutPanel.Controls.Add(b);
				b.Click += new EventHandler(delegate (object o, EventArgs e) {
					MainForm.Form.OpenRecentFile(b.Text);
				});
			}
		}

		private void NewProjectButton_Click(object sender, EventArgs e) {
			MainForm.Form.newToolStripMenuItem_Click(sender, e);
		}

		private void ExistingProjectButton_Click(object sender, EventArgs e) {
			MainForm.Form.openToolStripMenuItem_Click(sender, e);
		}
	}
}
