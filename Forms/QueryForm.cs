﻿using QuickDBAccess.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class QueryForm : Form {
		private DataSourceModel dataSource;
		private DataGridView dgv;
		private QuickAccessModel QdbaModel;
		public QueryForm(string text, DataSourceModel ds, DataGridView dgv, QuickAccessModel qdbaModel) {
			InitializeComponent();
			this.Text = text;
			this.dataSource = ds;
			this.dgv = dgv;
			this.QdbaModel = qdbaModel;
			CreateForm();
			if (Program.DEBUG) itemsTableLayoutPanel.CellPaint += itemsTableLayoutPanel_CellPaint;
		}
		void itemsTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
			e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
		}
		private void CreateForm() {
			foreach (QueryParameterModel p in dataSource.Query.Parameters) {
				AddParameter(p);
			}
		}
		private void AddParameter(QueryParameterModel param) {
			int i = dataSource.Query.Parameters.IndexOf(param);
			Label l = new Label();
			l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			l.Text = param.name;
			l.MinimumSize = l.Size;
			l.AutoSize = true;
			itemsTableLayoutPanel.Controls.Add(l, 0, i);
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
			itemsTableLayoutPanel.Controls.Add(param.c, 1, i);
			try {
				var dataGridViewColumn = dgv.Columns[param.autoSourceColumnName];
				if (dataGridViewColumn != null) {
					int index = dgv.Columns.IndexOf(dataGridViewColumn);
					if (param.c.GetType() == typeof(CheckBox)) {
						((CheckBox)param.c).Checked = Convert.ToBoolean(dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[index].Value);
					} else {
						param.c.Text = dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[index].Value.ToString();
					}
				}
			}
			catch { }
		}
		public object GetValue(string Name) {
			foreach(QueryParameterModel qp in this.dataSource.Query.Parameters) {
				if (qp.name == Name) {
					return qp.getValue();
				}
			}
			try {
				var dataGridViewColumn = dgv.Columns[Name];
				int index = dgv.Columns.IndexOf(dataGridViewColumn);
				return dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[index].Value;
			}
			catch { }
			return null;
		}
		private void okButton_Click(object sender, EventArgs e) {
			string connString = QdbaModel.ConnectionByName(dataSource.ConnectionName).ConnectionString;
			string query = this.dataSource.Query.Command;

			using (var con = new SqlConnection(connString))
			using (var cmd = new SqlCommand(query, con)) {
				for (int i = 0; i < this.dataSource.Query.Parameters.Count; i++) {
					QueryParameterModel p = this.dataSource.Query.Parameters[i];
					cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
					cmd.Parameters["@" + p.name].Value = p.getValue();
				}
				try {
					con.Open();
					Int32 rowsAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(String.Format("RowsAffected: {0}", rowsAffected));
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
			Close();
		}
	}
}
