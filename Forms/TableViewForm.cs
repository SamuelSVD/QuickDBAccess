using QuickDBAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class TableViewForm : Form {
		private DataTable datatable = new DataTable();
		List<TableViewForm> ChildrenTabs = new List<TableViewForm>();
		public Control getControl() {
			return ContentTableLayoutPanel;
		}
		private Model.TableView tableView;
		private Model.SQLConnection connection;
		public TableViewForm(Model.TableView tv, Model.SQLConnection connection) {
			InitializeComponent();
			ContentDataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
			tableView = tv;
			this.connection = connection;
			if (tv.buttonActions.Count > 2) {
				ButtonsTableLayoutPanel.ColumnCount = tv.buttonActions.Count;
			}
			ColumnStyle cs;
			Button b;
			int cnt = 0;
			for (int i = 0; i < tv.buttonActions.Count; i++) {
				if (ButtonsTableLayoutPanel.ColumnCount <= i) {
					ButtonsTableLayoutPanel.ColumnCount++;
				}
				if (ButtonsTableLayoutPanel.ColumnStyles.Count > i) {
					cs = ButtonsTableLayoutPanel.ColumnStyles[i];
				} else {
					cs = new ColumnStyle();
					ButtonsTableLayoutPanel.ColumnStyles.Add(cs);
				}
				cs.SizeType = SizeType.AutoSize;
				b = new Button();
				b.Text = tv.buttonActions[i].name;
				b.MinimumSize = b.Size;
				b.AutoSize = true;
				AddButtonEvent(b, tv.buttonActions[i]);
				ButtonsTableLayoutPanel.Controls.Add(b, i, 0);
				cnt++;
			}
			if (ButtonsTableLayoutPanel.ColumnCount <= tv.buttonActions.Count) {
				ButtonsTableLayoutPanel.ColumnCount++;
			}
			b = new Button();
			b.Text = "";
			b.Width = b.Height;
			b.MinimumSize = b.Size;
			b.AutoSize = true;
			b.Anchor = AnchorStyles.Right | AnchorStyles.Top;
			b.Click += RefreshData;
			b.BackgroundImageLayout = ImageLayout.Stretch;
			b.BackgroundImage = Properties.Resources.refresh;
			ButtonsTableLayoutPanel.Controls.Add(b, cnt, 0);

			cs = new ColumnStyle();
			cs.SizeType = SizeType.AutoSize;
			ButtonsTableLayoutPanel.ColumnStyles.Add(cs);

			DataLoad();
			if (Program.DEBUG) ContentTableLayoutPanel.CellPaint += tableLayoutPanel_CellPaint;
			if (tableView.ChildTableViews.Count > 0) {
				BuildChildrenViews();
			} else {
				ContentTableLayoutPanel.RowCount--;
				ContentTableLayoutPanel.Controls.Remove(ChildrenTabControl);
				ContentTableLayoutPanel.RowStyles[1].SizeType = SizeType.AutoSize;
			}
		}
		private void BuildChildrenViews() {
			ContentTableLayoutPanel.Controls.Add(ChildrenTabControl, 0, 2);
			ContentTableLayoutPanel.AutoSize = true;
			ContentTableLayoutPanel.Dock = DockStyle.Fill;
			foreach (TableView child in tableView.ChildTableViews) {
				AddChildTableView(child);
			}
		}
		private void AddChildTableView(TableView tv) {
			TableViewForm tvf = new TableViewForm(tv, connection);
			TabPage tp = new TabPage();
			tp.Text = tv.name;
			tp.Controls.Add(tvf.getControl());
			ChildrenTabControl.TabPages.Add(tp);
		}
		void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
			e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
		}
		private void AddButtonEvent(Button b, Query q) {
			b.Click += new EventHandler(delegate (object o, EventArgs e) {
				QueryForm f = new QueryForm(q, connection, ContentDataGridView);
				f.ShowDialog();
				DataLoad();
			});
		}
		public void RefreshData(object sender, EventArgs args) {
			DataLoad();
		}
		public void DataLoad() {
			string connString = connection.ConnectionString();
			string query = tableView.ContentQuery.command;

			using (var con = new SqlConnection(connString))
			using (var cmd = new SqlCommand(query, con)) {
				try {
					con.Open();
					// create data adapter
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					// this will query your database and return the result to your datatable
					datatable.Clear();
					da.Fill(datatable);
					ContentDataGridView.DataSource = datatable;
					con.Close();
					da.Dispose();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			if (this.tableView.OnDoubleClickQuery != null) {
				QueryForm f = new QueryForm(this.tableView.OnDoubleClickQuery, connection, ContentDataGridView);
				f.ShowDialog();
				DataLoad();
			}
		}
	}
}
