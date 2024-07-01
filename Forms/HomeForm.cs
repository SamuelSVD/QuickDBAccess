using QuickDBAccess.Controls;
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
			for (int i = 0; i < Settings.Default.RecentFiles.Count(); i++) {
				string recentFilePath = Settings.Default.RecentFiles[i];
				string recentFileProjName = string.Empty;
				if (Settings.Default.RecentFilesProjectName.Count() > i) {
					recentFileProjName = Settings.Default.RecentFilesProjectName[i];
				}
				RecentFileUserControl b = new RecentFileUserControl();
				b.ProjectName = recentFileProjName;
				b.ProjectPath = recentFilePath;

				b.HoverColor = SystemColors.ButtonHighlight;
				//b.Text = recentFile;
				//b.AutoSize = true;
				//b.Dock = DockStyle.Top;
				RecentFilesTableLayoutPanel.Controls.Add(b);
				b.Click += new EventHandler(delegate (object o, EventArgs e) {
					string filePath = recentFilePath;
					MainForm.Form.OpenRecentFile(filePath);
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
