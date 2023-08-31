using QuickDBAccess.Model;
using QuickDBAccess.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class MainForm : Form {
		public static MainForm Form;
		public TableViewModel CurrentTableView {
			get {
				int i = TableViewTabControl.SelectedIndex;
				if ((i >= 0) && (ProgramData.Instance != null) && (i < ProgramData.Instance.TableViews.Count)) {
					return ProgramData.Instance.TableViews[i];
				}
				return null;
			}
		}
		public MainForm() {
			Form = this;
			InitializeComponent();
			if (ProgramData.ShouldBeValidConfigLocation) LoadConfig();
			BuildTableViews();
			UpdateRecentFiles();
		}
		public void OpenRecentFile(string path) {
			if (ProgramData.Changed) {
				DialogResult result = MessageBox.Show("Unsaved changes. Would you like to save before opening a different project?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes) {
					ProgramData.SaveConfig();
					if (ProgramData.Changed) {
						return;
					}
				} else if (result == DialogResult.No) {
				} else {
					return;
				}
			}
			ProgramData.OpenConfig(path);
			if (ProgramData.Instance == null) {
				if (ProgramData.InvalidFile) {
					MessageBox.Show($"Unable to open {ProgramData.CONFIG}. The file may be corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				ProgramData.Instance = new QuickAccessModel();
			}
			BuildTableViews();
			LoadTableViewsData();
			UpdateFormText();
			UpdateRecentFiles();
		}
		public void UpdateRecentFiles() {
			if (Settings.Default.RecentFiles == null) {
				Settings.Default.RecentFiles = new List<string>();
			}
			if (ProgramData.InvalidFile) {
				if (Settings.Default.RecentFiles.Contains(ProgramData.CONFIG)) {
					Settings.Default.RecentFiles.RemoveAt(Settings.Default.RecentFiles.IndexOf(ProgramData.CONFIG));
				}
			} else if (ProgramData.ValidConfigLocation) {
				if (Settings.Default.RecentFiles.Contains(ProgramData.CONFIG)) {
					Settings.Default.RecentFiles.RemoveAt(Settings.Default.RecentFiles.IndexOf(ProgramData.CONFIG));
				}
				Settings.Default.RecentFiles.Insert(0, ProgramData.CONFIG);
			}
			while (Settings.Default.RecentFiles.Count > 10) {
				Settings.Default.RecentFiles.RemoveAt(Settings.Default.RecentFiles.Count - 1);
			}
			OpenRecentToolStripMenuItem.Enabled = Settings.Default.RecentFiles.Count > 0;
			OpenRecentToolStripMenuItem.DropDownItems.Clear();
			foreach (string s in Settings.Default.RecentFiles) {
				string s2 = s;
				ToolStripMenuItem recentItem = new ToolStripMenuItem();
				recentItem.Text = s2;
				recentItem.Click += new EventHandler(delegate (object o, EventArgs e) {
					OpenRecentFile(s2);
				});
				OpenRecentToolStripMenuItem.DropDownItems.Add(recentItem);
			}
			Settings.Default.Save();
		}
		public void LoadConfig() {
			ProgramData.LoadConfig();
			if (ProgramData.Instance == null) {
				ProgramData.Instance = new QuickAccessModel();
			}
		}
		public void BuildTableViews() {
			TableViewTabControl.TabPages.Clear();
			if (ProgramData.Instance != null) {
				foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
					AddTableView(tv);
				}
			} else {
				TabPage tp = new TabPage("Welcome");
				tp.Controls.Add(new HomeForm().Content);
				TableViewTabControl.TabPages.Add(tp);
			}
		}
		public void LoadTableViewsData() {
			if (ProgramData.Instance != null) {
				foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
					try {
						tv.View.RefreshData(this, null);
					}
					catch (Exception ex) {
					}
				}
				editToolStripMenuItem.Enabled = true;
			}
		}
		private void AddTableView(TableViewModel tv) {
			TableViewForm tvf = new TableViewForm(tv, ProgramData.Instance);
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
			af.Dispose();
		}

		private bool _formShown = false;
		private void MainForm_Shown(object sender, System.EventArgs e) {
			if (!_formShown) {
				LoadTableViewsData();
				UpdateFormText();
				_formShown = true;
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e) {
			if (ProgramData.Instance == null) return;
			ProgramData.Instance.RevalidateConnections();
			LoadTableViewsData();
		}
		private void refreshCurrentAllToolStripMenuItem_Click(object sender, EventArgs e) {
			if (ProgramData.Instance == null) return;
			ProgramData.Instance.RevalidateConnections();
			if (CurrentTableView != null) {
				CurrentTableView.View.RefreshData(sender, e);
			}
		}
		private void MainForm_Load(object sender, System.EventArgs e) {
			bool locationValid = false;
			foreach (Screen screen in Screen.AllScreens) {
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
			if (ProgramData.Changed) {
				switch (MessageBox.Show("Unsaved changes. Would you like to save before exiting?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
					case DialogResult.Yes:
						if (!ProgramData.SaveConfig()) {
							e.Cancel = true;
						}
						UpdateFormText();
						UpdateRecentFiles();
						break;
					case DialogResult.No:
						break;
					default:
						e.Cancel = true;
						break;
				}
			}
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
			if (ProgramData.Instance == null) return;
			QuickAccessModel model = new QuickAccessModel(ProgramData.Instance);
			QuickAccessEditForm editForm = new QuickAccessEditForm(model);
			if (editForm.ShowDialog() == DialogResult.OK) {
				if (editForm.Changed) {
					ProgramData.Instance = model;
					BuildTableViews();
					LoadTableViewsData();
					ProgramData.Changed = true;
					UpdateFormText();
				}
			}
			editForm.Dispose();
			GC.Collect();
		}

		private void UpdateFormText() {
			Text = "Quick DB Access";
			if (ProgramData.Instance != null) {
				Text += " - ";
				Text += string.IsNullOrEmpty(ProgramData.Instance.ProjectName) ? "Untitled Project" : ProgramData.Instance.ProjectName;
			}
			Text += ProgramData.Changed ? "*" : string.Empty;
		}

		public void newToolStripMenuItem_Click(object sender, EventArgs e) {
			if (ProgramData.Changed) {
				switch (MessageBox.Show("Unsaved changes. Would you like to save before starting a new project?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
					case DialogResult.Yes:
						if (!ProgramData.SaveConfig()) {
							return;
						}
						break;
					case DialogResult.No:
						break;
					default:
						return;
				}
			}
			ProgramData.Instance = new QuickAccessModel();
			ProgramData.Changed = false;
			ProgramData.ValidConfigLocation = false;
			ProgramData.ShouldBeValidConfigLocation = false;
			BuildTableViews();
			LoadTableViewsData();
			UpdateFormText();
			UpdateRecentFiles();
		}

		public void openToolStripMenuItem_Click(object sender, EventArgs e) {
			if (ProgramData.Changed) {
				DialogResult result = MessageBox.Show("Unsaved changes. Would you like to save before opening a different project?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes) {
					ProgramData.SaveConfig();
					if (ProgramData.Changed) {
						return;
					}
				} else if (result == DialogResult.No) {
				} else {
					return;
				}
			}
			ProgramData.OpenConfig();
			if (ProgramData.Instance == null) {
				if (ProgramData.InvalidFile) {
					MessageBox.Show($"Unable to open {ProgramData.CONFIG}. The file may be corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				ProgramData.Instance = null;
			}
			BuildTableViews();
			LoadTableViewsData();
			UpdateFormText();
			UpdateRecentFiles();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			ProgramData.SaveConfig();
			UpdateFormText();
			UpdateRecentFiles();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			ProgramData.SaveConfigAs();
			UpdateFormText();
			UpdateRecentFiles();
		}
	}
}
