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
		public TableViewForm ParentForm;
		public Control getControl() {
			if (tableView.ChildTableViews.Count == 0) {
				return ContentTableLayoutPanel;
			} else {
				return ContentSplitContainer;
			}
		}
		private Model.TableView tableView;
		public TableViewForm(Model.TableView tv) : this(tv, null) { }
		public TableViewForm(Model.TableView tv, TableViewForm parent) {
			InitializeComponent();
			ContentDataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
			tableView = tv;
			ParentForm = parent;
			if (tv.Buttons.Count > 2) {
				ButtonsTableLayoutPanel.ColumnCount = tv.Buttons.Count;
			}
			ColumnStyle cs;
			Button b;
			int cnt = 0;
			for (int i = 0; i < tv.Buttons.Count; i++) {
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
				b.Text = tv.Buttons[i].Text;
				b.MinimumSize = b.Size;
				b.AutoSize = true;
				AddButtonEvent(b, tv.Buttons[i]);
				ButtonsTableLayoutPanel.Controls.Add(b, i, 0);
				cnt++;
			}
			if (ButtonsTableLayoutPanel.ColumnCount <= tv.Buttons.Count) {
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

			//DataLoad();
			if (Program.DEBUG) ContentTableLayoutPanel.CellPaint += tableLayoutPanel_CellPaint;
			if (tableView.ChildTableViews.Count > 0) {
				BuildChildrenViews();
			} else {
				ContentTableLayoutPanel.RowCount--;
				ContentTableLayoutPanel.Controls.Remove(ChildrenTabControl);
				ContentTableLayoutPanel.RowStyles[1].SizeType = SizeType.AutoSize;
			}
			_initialized = true;
		}
		private void BuildChildrenViews() {
			ContentTableLayoutPanel.AutoSize = true;
			ContentTableLayoutPanel.Dock = DockStyle.Fill;
			foreach (TableView child in tableView.ChildTableViews) {
				AddChildTableView(child);
			}
		}
		private void AddChildTableView(TableView tv) {
			TableViewForm tvf = new TableViewForm(tv, this);
			TabPage tp = new TabPage();
			tp.Text = tv.Name;
			tp.Controls.Add(tvf.getControl());
			ChildrenTabControl.TabPages.Add(tp);
			ChildrenTabs.Add(tvf);
		}
		void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
			e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
		}
		private void AddButtonEvent(Button b, ButtonModel q) {
			b.Click += new EventHandler(delegate (object o, EventArgs e) {
				QueryForm f = new QueryForm(b.Text, ProgramData.Instance.DataSourceByName(q.DataSourceName), ContentDataGridView);
				f.ShowDialog();
				DataLoad();
			});
		}
		public void RefreshData(object sender, EventArgs args) {
			DataLoad();
		}
		public object GetValue(string Name) {
			foreach (QueryParameter qp in ProgramData.Instance.DataSourceByName(tableView.ContentDataSourceName).Query.Parameters) {
				if (qp.name == Name) {
					return qp.getValue();
				}
			}
			try {
				var dataGridViewColumn = ContentDataGridView.Columns[Name];
				int index = ContentDataGridView.Columns.IndexOf(dataGridViewColumn);
				return ContentDataGridView.Rows[ContentDataGridView.SelectedCells[0].RowIndex].Cells[index].Value;
			}
			catch { }
			return null;
		}
		public void DataLoad() {
			try {
				if (string.IsNullOrEmpty(tableView.ContentDataSourceName)) {
					throw new Exception("Content DataSource not assigned.");
				}
				DataSource ds = ProgramData.Instance.DataSourceByName(tableView.ContentDataSourceName);
				if (string.IsNullOrEmpty(ds.ConnectionName)) {
					throw new Exception($"Connection name not assigned for data source {ds.Name}");
				}
				string connString = ProgramData.Instance.ConnectionByName(ds.ConnectionName).ConnectionString();
				string query = ds.Query.Command;

				using (var con = new SqlConnection(connString))
				using (var cmd = new SqlCommand(query, con)) {
					try {
						for (int i = 0; i < ds.Query.ParentParameters.Count; i++) {
							QueryParameter p = ds.Query.ParentParameters[i];
							cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
							cmd.Parameters["@" + p.name].Value = ParentForm.GetValue(p.name);
							if (cmd.Parameters["@" + p.name].Value == null) return;
						}
						for (int i = 0; i < ds.Query.Parameters.Count; i++) {
							QueryParameter p = ds.Query.Parameters[i];
							cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
							cmd.Parameters["@" + p.name].Value = p.getValue();
						}
						con.Open();
						// create data adapter
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						// this will query your database and return the result to your datatable
						datatable.Clear();
						da.Fill(datatable);
						ContentDataGridView.DataSource = datatable;
						foreach(DataGridViewColumn col in ContentDataGridView.Columns) {
							ColumnDetail detail = tableView.ColumnDetails.Find(t => t.Name == col.HeaderText);
							if (detail != null) {
								col.Visible = !detail.hidden;
							}
						}
						con.Close();
						da.Dispose();
					}
					catch (Exception ex) {
						if (ex.Message != "Operation cannot be performed in this event handler.") {
							MessageBox.Show(ex.Message);
						}
					}
				}
			}
			catch (Exception ex) {
				if (ex.Message != "Operation cannot be performed in this event handler.") {
					MessageBox.Show(ex.Message);
				}
			}

		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			try {
				if (tableView.DoubleClickAction != null) {
					QueryForm f = new QueryForm(tableView.DoubleClickAction.Text, ProgramData.Instance.DataSourceByName(tableView.DoubleClickAction.DataSourceName), ContentDataGridView);
					f.ShowDialog();
					DataLoad();
				}
			}
			catch (Exception ex) {
				if (ex.Message != "Operation cannot be performed in this event handler.") {
					MessageBox.Show(ex.Message);
				}
			}
		}
		int _selectedRow = -1;
		private bool _initialized = false;

		private void ContentDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
			if (e.StateChanged != DataGridViewElementStates.Selected || !_initialized) return;
			if (ContentDataGridView.SelectedCells.Count > 0) {
				if (_selectedRow == ContentDataGridView.SelectedCells[0].RowIndex) return;
			}
			foreach (TableViewForm tvf in ChildrenTabs) {
				tvf.RefreshData(sender, e);
			}
			if (ContentDataGridView.SelectedCells.Count > 0) {
				_selectedRow = ContentDataGridView.SelectedCells[0].RowIndex;
			} else {
				_selectedRow = -1;
			}
		}

		private void ContentDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) {
			if (e.StateChanged != DataGridViewElementStates.Selected || !_initialized) return;
			if (ContentDataGridView.SelectedCells.Count > 0) {
				if (ContentDataGridView.SelectedCells[0].RowIndex != _selectedRow) {
					_selectedRow = ContentDataGridView.SelectedCells[0].RowIndex;
					foreach (TableViewForm tvf in ChildrenTabs) {
						tvf.RefreshData(sender, e);
					}
				}
			}
		}
	}
}
