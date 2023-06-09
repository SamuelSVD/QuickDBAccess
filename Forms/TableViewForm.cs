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
		public Button RefreshButton;
		private QuickAccessModel QdbaModel;
		private Dictionary<QueryParameterModel, Control> paramControlMapping = new Dictionary<QueryParameterModel, Control>();
		public Control getControl() {
			if (tableView.ChildTableViews.Count == 0) {
				return ContentTableLayoutPanel;
			} else {
				return ContentSplitContainer;
			}
		}
		private Model.TableViewModel tableView;
		public TableViewForm(Model.TableViewModel tv, QuickAccessModel qdbaModel) : this(tv, qdbaModel, null) { }
		public TableViewForm(Model.TableViewModel tv, QuickAccessModel qdbaModel, TableViewForm parent) {
			InitializeComponent();
			ContentDataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
			tableView = tv;
			ParentForm = parent;
			QdbaModel = qdbaModel;
			if (tv.Buttons.Count > 2) {
				ButtonsTableLayoutPanel.ColumnCount = tv.Buttons.Count;
			}
			BuildButtons();
			BuildParameterFields();
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
		private void BuildButtons() {
			ColumnStyle cs;
			Button b;
			int cnt = 0;
			for (int i = 0; i < tableView.Buttons.Count; i++) {
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
				b.Text = tableView.Buttons[i].Text;
				b.MinimumSize = b.Size;
				b.AutoSize = true;
				AddButtonEvent(b, tableView.Buttons[i]);
				ButtonsTableLayoutPanel.Controls.Add(b, i, 0);
				cnt++;
			}
			if (ButtonsTableLayoutPanel.ColumnCount <= tableView.Buttons.Count) {
				ButtonsTableLayoutPanel.ColumnCount++;
			}
			RefreshButton = new Button();
			cs = new ColumnStyle();
			cs.SizeType = SizeType.AutoSize;
			ButtonsTableLayoutPanel.ColumnStyles.Add(cs);
			ButtonsTableLayoutPanel.Controls.Add(RefreshButton, cnt, 0);
			RefreshButton.Text = "x";
			RefreshButton.AutoSize = true;
			RefreshButton.Width = RefreshButton.Height;
			RefreshButton.MinimumSize = RefreshButton.Size;
			RefreshButton.Text = ""; //Needed to make the sizing the same as other buttons
			RefreshButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;
			RefreshButton.Click += RefreshData;
			RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
			RefreshButton.BackgroundImage = Properties.Resources.refresh;
		}
		private void BuildParameterFields() {
			DataSourceModel ds = QdbaModel.DataSourceByName(tableView.ContentDataSourceName);
			ParametersTableLayoutPanel.Visible = (ds == null) || ds.Query.Parameters.Count > 0;
			foreach(QueryParameterModel param in ds.Query.Parameters) {
				AddParameter(ds, param);
			}
			ParametersTableLayoutPanel.ColumnStyles.Clear();
			ParametersTableLayoutPanel.ColumnCount = ParametersTableLayoutPanel.Controls.Count + 1;
			for (int i = 0; i < ParametersTableLayoutPanel.Controls.Count + 1; i++) {
				ColumnStyle cs = new ColumnStyle();
				if (i == ParametersTableLayoutPanel.Controls.Count) {
					cs.SizeType = SizeType.Percent;
					cs.Width = 100;
				} else {
					cs.SizeType = SizeType.AutoSize;
				}
				ParametersTableLayoutPanel.ColumnStyles.Add(cs);
			}
		}
		private void AddParameter(DataSourceModel dataSource, QueryParameterModel param) {
			int i = dataSource.Query.Parameters.IndexOf(param);
			Label l = new Label();
			l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			l.Text = param.name;
			l.TextAlign = ContentAlignment.MiddleLeft;
			l.MinimumSize = new Size(1, l.Height);
			l.AutoSize = true;
			ParametersTableLayoutPanel.Controls.Add(l, i, 0);
			switch (param.getSqlDbType()) {
				case SqlDbType.BigInt:
					NumericUpDown nud2 = new NumericUpDown();
					nud2.Minimum = long.MinValue;
					nud2.Maximum = long.MaxValue;
					param.c = nud2;
					break;
				case SqlDbType.Bit:
					CheckBox cb = new CheckBox();
					param.c = cb;
					break;
				case SqlDbType.Date:
					DateTimePicker dtp = new DateTimePicker();
					dtp.Format = DateTimePickerFormat.Short;
					param.c = dtp;
					break;
				case SqlDbType.Time:
					DateTimePicker dtp2 = new DateTimePicker();
					dtp2.Format = DateTimePickerFormat.Time;
					param.c = dtp2;
					break;
				case SqlDbType.DateTime:
					DateTimePicker dtp3 = new DateTimePicker();
					dtp3.Format = DateTimePickerFormat.Custom;
					dtp3.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
					param.c = dtp3;
					break;
				case SqlDbType.Float:
					TextBox tb = new TextBox();
					tb.Text = "0.0";
					param.c = tb;
					break;
				case SqlDbType.Int:
					NumericUpDown nud = new NumericUpDown();
					nud.Minimum = int.MinValue;
					nud.Maximum = int.MaxValue;
					param.c = nud;
					break;
				case SqlDbType.Real:
					TextBox tb2 = new TextBox();
					tb2.Text = "0.0";
					param.c = tb2;
					break;
				case SqlDbType.SmallInt:
					NumericUpDown nud3 = new NumericUpDown();
					nud3.Minimum = short.MinValue;
					nud3.Maximum = short.MaxValue;
					param.c = nud3;
					break;
				case SqlDbType.TinyInt:
					NumericUpDown nud4 = new NumericUpDown();
					nud4.Minimum = byte.MinValue;
					nud4.Maximum = byte.MaxValue;
					param.c = nud4;
					break;
				default:
					TextBox tbd = new TextBox();
					param.c = tbd;
					break;
			}
			param.c.Dock = DockStyle.Top;
			Control c = param.c;
			param.c = null;
			ParametersTableLayoutPanel.Controls.Add(c, i+1, 0);
			paramControlMapping.Add(param, c);
		}
		private void BuildChildrenViews() {
			ContentTableLayoutPanel.AutoSize = true;
			ContentTableLayoutPanel.Dock = DockStyle.Fill;
			foreach (TableViewModel child in tableView.ChildTableViews) {
				AddChildTableView(child);
			}
		}
		private void AddChildTableView(TableViewModel tv) {
			TableViewForm tvf = new TableViewForm(tv, QdbaModel, this);
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
				QueryForm f = new QueryForm(b.Text, QdbaModel.DataSourceByName(q.DataSourceName), ContentDataGridView, QdbaModel);
				f.ShowDialog();
				f.Dispose();
				RefreshData(this, null);
			});
		}
		public void RefreshData(object sender, EventArgs args) {
			if (sender == RefreshButton) {
				if (ProgramData.Instance != null) {
					ProgramData.Instance.RevalidateConnections();
				}
			}
			DataLoad();
			foreach (TableViewForm tvf in ChildrenTabs) {
				tvf.RefreshData(sender, args);
			}
		}
		public object GetValue(string Name) {
			foreach (QueryParameterModel qp in QdbaModel.DataSourceByName(tableView.ContentDataSourceName).Query.Parameters) {
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
					throw new Exception($"Content DataSource not assigned for tabe view {tableView.Name}");
				}
				DataSourceModel ds = QdbaModel.DataSourceByName(tableView.ContentDataSourceName);
				if (string.IsNullOrEmpty(ds.ConnectionName)) {
					throw new Exception($"Connection name not assigned for data source {ds.Name}");
				}
				SQLConnectionModel connection = QdbaModel.ConnectionByName(ds.ConnectionName);
				if (!connection.ConnectionValid) return;
				string connString = connection.ConnectionString;
				string query = ds.Query.Command;

				datatable.Clear();

				using (var con = new SqlConnection(connString))
				using (var cmd = new SqlCommand(query, con)) {
					try {
						for (int i = 0; i < ds.Query.ParentParameters.Count; i++) {
							QueryParameterModel p = ds.Query.ParentParameters[i];
							cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
							cmd.Parameters["@" + p.name].Value = ParentForm.GetValue(p.name);
							if (cmd.Parameters["@" + p.name].Value == null) return;
						}
						for (int i = 0; i < ds.Query.Parameters.Count; i++) {
							QueryParameterModel p = ds.Query.Parameters[i];
							cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
							p.c = paramControlMapping[p];
							cmd.Parameters["@" + p.name].Value = p.getValue();
							p.c = null;
						}
						con.Open();
						// create data adapter
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						// this will query your database and return the result to your datatable
						da.Fill(datatable);
						ContentDataGridView.DataSource = datatable;
						foreach(DataGridViewColumn col in ContentDataGridView.Columns) {
							ColumnDetailModel detail = tableView.ColumnDetails.Find(t => t.Name == col.HeaderText);
							if (detail != null) {
								col.Visible = !detail.hidden;
							}
						}
						con.Close();
						da.Dispose();
					}
					catch (Exception ex) {
						if (ex.Message.StartsWith("Login failed")) {
							connection.Invalidate();
						}
						if (ex.Message.StartsWith("A network-related")) {
							connection.Invalidate();
						}
						throw;
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
					QueryForm f = new QueryForm(tableView.DoubleClickAction.Text, QdbaModel.DataSourceByName(tableView.DoubleClickAction.DataSourceName), ContentDataGridView, QdbaModel);
					f.ShowDialog();
					f.Dispose();
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

		private void ContentDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e) {
			e.Column.FillWeight = 10;
		}

		private void ContentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}
