using QuickDBAccess.Model;
using System;
using System.Windows.Forms;
using Utils;

namespace QuickDBAccess.Forms {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			LoadConfig();
		}
		public void LoadConfig() {
			ProgramData.LoadConfig();
			if (ProgramData.Instance != null) {
				foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
					AddTableView(tv);
				}
			}
			//ProgramData.SaveConfig();
		}
		private void AddTableView(TableViewModel tv) {
			TableViewForm tvf = new TableViewForm(tv);
			TabPage tp = new TabPage();
			tp.Text = tv.Name;
			tp.Controls.Add(tvf.getControl());
			tv.TabPage = tp;
			tv.View = tvf;
			TableViewTabControl.MinimumSize = tvf.getControl().MinimumSize;
			TableViewTabControl.TabPages.Add(tp);
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e) {
			Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e) {
			AboutForm af = new AboutForm();
			af.ShowDialog();
		}

		private bool _formShown = false;
		private void MainForm_Shown(object sender, System.EventArgs e) {
			if (!_formShown) {
				if (ProgramData.Instance != null) {
					foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
						try {
							tv.View.DataLoad();
						}
						catch (Exception ex) {

						}
					}
					editToolStripMenuItem.Enabled = true;
				}
				_formShown = true;
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, System.EventArgs e) {
			foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
				try {
					tv.View.RefreshData(sender, e);
				}
				catch {

				}
			}
		}

		private void MainForm_Load(object sender, System.EventArgs e) {
			bool locationValid = false;
			foreach(Screen screen in Screen.AllScreens) {
				if (screen.WorkingArea.Contains(Properties.Settings.Default.Location)) {
					locationValid = true;
				}
			}
			if (!locationValid) {
				return;
			}
			if (Properties.Settings.Default.Maximised) {
				Location = Properties.Settings.Default.Location;
				WindowState = FormWindowState.Maximized;
				if (Properties.Settings.Default.Size.Width > 0) {
					Size = Properties.Settings.Default.Size;
				}
			} else if (Properties.Settings.Default.Minimised) {
				Location = Properties.Settings.Default.Location;
				WindowState = FormWindowState.Minimized;
				if (Properties.Settings.Default.Size.Width > 0) {
					Size = Properties.Settings.Default.Size;
				}
			} else {
				Location = Properties.Settings.Default.Location;
				if (Properties.Settings.Default.Size.Width > 0) {
					Size = Properties.Settings.Default.Size;
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (WindowState == FormWindowState.Maximized) {
				Properties.Settings.Default.Location = RestoreBounds.Location;
				Properties.Settings.Default.Size = RestoreBounds.Size;
				Properties.Settings.Default.Maximised = true;
				Properties.Settings.Default.Minimised = false;
			} else if (WindowState == FormWindowState.Normal) {
				Properties.Settings.Default.Location = Location;
				Properties.Settings.Default.Size = Size;
				Properties.Settings.Default.Maximised = false;
				Properties.Settings.Default.Minimised = false;
			} else {
				Properties.Settings.Default.Location = RestoreBounds.Location;
				Properties.Settings.Default.Size = RestoreBounds.Size;
				Properties.Settings.Default.Maximised = false;
				Properties.Settings.Default.Minimised = true;
			}
			Properties.Settings.Default.Save();
		}

		private void editToolStripMenuItem_Click(object sender, System.EventArgs e) {
			QuickAccessEditForm editForm = new QuickAccessEditForm(ProgramData.Instance);
			editForm.ShowDialog();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			NewProjectForm newProjectForm = new NewProjectForm();
			if (newProjectForm.ShowDialog() == DialogResult.OK) {
			}
			throw new NotImplementedException();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}
	}
}
