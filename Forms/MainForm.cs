using QuickDBAccess.Model;
using QuickDBAccess.Properties;
using System;
using System.Windows.Forms;
using Utils;

namespace QuickDBAccess.Forms {
	public partial class MainForm : Form {
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
			InitializeComponent();
			LoadConfig();
			BuildTableViews();
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
			}
		}
		public void LoadTableViewsData() {
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
		}

		private bool _formShown = false;
		private void MainForm_Shown(object sender, System.EventArgs e) {
			if (!_formShown) {
				LoadTableViewsData();
				UpdateFormText();
				_formShown = true;
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, System.EventArgs e) {
			if (ProgramData.Instance == null) return;
			foreach (TableViewModel tv in ProgramData.Instance.TableViews) {
				try {
					tv.View.RefreshData(sender, e);
				}
				catch {

				}
			}
		}
		private void refreshCurrentAllToolStripMenuItem_Click(object sender, EventArgs e) {
			if (CurrentTableView != null) {
				CurrentTableView.View.RefreshData(sender, e);
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
			if (ProgramData.Changed) {
				switch(MessageBox.Show("Unsaved changes. Would you like to save before exiting?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
					case DialogResult.Yes:
						if (!ProgramData.SaveConfig()) {
							e.Cancel = true;
						}
						UpdateFormText();
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
			GC.Collect();
		}

		private void UpdateFormText() {
			Text = "Quick DB Access - ";
			Text += (ProgramData.Instance == null) || string.IsNullOrEmpty(ProgramData.Instance.ProjectName) ? "Untitled Project" : ProgramData.Instance.ProjectName;
			Text += ProgramData.Changed ? "*" : string.Empty;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
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
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
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
				ProgramData.Instance = new QuickAccessModel();
			}
			BuildTableViews();
			LoadTableViewsData();
			UpdateFormText();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			ProgramData.SaveConfig();
			UpdateFormText();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			ProgramData.SaveConfigAs();
			UpdateFormText();
		}
	}
}
