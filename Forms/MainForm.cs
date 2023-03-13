using QuickDBAccess.Model;
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
				foreach (TableView tv in ProgramData.Instance.TableViews) {
					AddTableView(tv);
				}
			}
			ProgramData.SaveConfig();
		}
		private void AddTableView(TableView tv) {
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
				foreach(TableView tv in ProgramData.Instance.TableViews) {
					try {
						tv.View.DataLoad();
					} catch {

					}
				}
				_formShown = true;
			}
		}

		private void refreshAllToolStripMenuItem_Click(object sender, System.EventArgs e) {
			foreach (TableView tv in ProgramData.Instance.TableViews) {
				try {
					tv.View.RefreshData(sender, e);
				}
				catch {

				}
			}
		}
	}
}
