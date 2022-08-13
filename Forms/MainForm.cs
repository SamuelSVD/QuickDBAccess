using QuickDBAccess.Model;
using System.Windows.Forms;
using Utils;

namespace QuickDBAccess.Forms {
	public partial class MainForm : Form {
		QuickAccess qa;
		public MainForm() {
			InitializeComponent();
			LoadConfig();
		}
		public void LoadConfig() {
			qa = XMLUtils.LoadFromFile<QuickAccess>(ProgramData.CONFIG);
			if (qa != null) {
				foreach (TableView tv in qa.TableViews) {
					AddTableView(tv);
				}
			}
		}
		private void AddTableView(TableView tv) {
			TableViewForm tvf = new TableViewForm(tv, qa.Connection);
			TabPage tp = new TabPage();
			tp.Text = tv.name;
			tp.Controls.Add(tvf.getControl());
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
	}
}
