using QuickDBAccess.Model;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace QuickDBAccess.Forms
{
    public partial class MainForm : Form
    {
        QuickAccess qa;
        public MainForm()
        {
            InitializeComponent();
            LoadConfig();
        }
        public void LoadConfig()
        {
            qa = XMLUtils.LoadFromFile<QuickAccess>(ProgramData.CONFIG);
            //qa.TableViews[0].buttonActions[0].parameters.Add(new QueryParameter());
            //XMLUtils.SaveToFile(qa, ProgramData.CONFIG);
            if (qa != null)
            {
                foreach (TableView tv in qa.TableViews)
                {
                    AddTableView(tv);
                }
            }
        }
        private void AddTableView(TableView tv)
        {
            TableViewForm tvf = new TableViewForm(tv, qa.Connection);
            TabPage tp = new TabPage();
            tp.Text = tv.name;
            tp.Controls.Add(tvf.getControl());
            tabControl1.TabPages.Add(tp);
        }
    }
}
