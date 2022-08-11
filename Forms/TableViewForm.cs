using QuickDBAccess.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms
{
    public partial class TableViewForm : Form
    {
        private DataTable datatable = new DataTable();

        public DataGridView gridView
        {
            get
            {
                return this.dataGridView;
            }
        }
        public Control getControl()
        {
            return tableLayoutPanel;
        }
        private Model.TableView tableView;
        private Model.SQLConnection connection;
        public TableViewForm(Model.TableView tv, Model.SQLConnection connection)
        {
            InitializeComponent();
            tableView = tv;
            this.connection = connection;
            if (tv.buttonActions.Count > 2)
            {
                tableLayoutPanel2.ColumnCount = tv.buttonActions.Count;
            }
			ColumnStyle cs;
			Button b;
			int cnt = 0;
			for (int i = 0; i < tv.buttonActions.Count; i++)
            {
				if (tableLayoutPanel2.ColumnCount <= i) {
					tableLayoutPanel2.ColumnCount++;
				}
				if (tableLayoutPanel2.ColumnStyles.Count > i)
                {
                    cs = tableLayoutPanel2.ColumnStyles[i];
                }
                else
                {
                    cs = new ColumnStyle();
                    tableLayoutPanel2.ColumnStyles.Add(cs);
                }
                cs.SizeType = SizeType.AutoSize;
                b = new Button();
                b.Text = tv.buttonActions[i].name;
                b.MinimumSize = b.Size;
                b.AutoSize = true;
                AddButtonEvent(b, tv.buttonActions[i]);
                tableLayoutPanel2.Controls.Add(b, i, 0);
				cnt++;
            }
			tableLayoutPanel2.ColumnCount++;
			b = new Button();
			b.Text = "";
			b.Width = b.Height;
			b.MinimumSize = b.Size;
			b.AutoSize = true;
			b.Anchor = AnchorStyles.Right | AnchorStyles.Top;
			b.Click += RefreshData;
			b.BackgroundImageLayout = ImageLayout.Stretch;
			b.BackgroundImage = Properties.Resources.refresh;
			tableLayoutPanel2.Controls.Add(b, cnt, 0);

			cs = new ColumnStyle();
			cs.SizeType = SizeType.AutoSize;
			tableLayoutPanel2.ColumnStyles.Add(cs);

			DataLoad();
            if (Program.DEBUG) tableLayoutPanel.CellPaint += tableLayoutPanel_CellPaint;
        }
        void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
        }
        private void AddButtonEvent(Button b, Query q)
        {
            b.Click += new EventHandler(delegate (object o, EventArgs e)
            {
                QueryForm f = new QueryForm(q, connection, gridView);
                f.ShowDialog();
                DataLoad();
            });
        }
		public void RefreshData(object sender, EventArgs args) {
			DataLoad();
		}
        public void DataLoad()
        {
            string connString = connection.ConnectionString();
            string query = tableView.ContentQuery.command;

            using (var con = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    // create data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    datatable.Clear();
                    da.Fill(datatable);
                    dataGridView.DataSource = datatable;
                    con.Close();
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tableView.OnDoubleClickQuery != null)
            {
                QueryForm f = new QueryForm(this.tableView.OnDoubleClickQuery, connection, gridView);
                f.ShowDialog();
                DataLoad();
            }
        }
    }
}
