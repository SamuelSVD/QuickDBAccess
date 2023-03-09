using QuickDBAccess.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
	public partial class QueryForm : Form {
		private DataSource dataSource;
		private DataGridView dgv;
		public QueryForm(string text, DataSource ds, DataGridView dgv) {
			InitializeComponent();
			this.Text = text;
			this.dataSource = ds;
			this.dgv = dgv;
			CreateForm();
			if (Program.DEBUG) itemsTableLayoutPanel.CellPaint += itemsTableLayoutPanel_CellPaint;
		}
		void itemsTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
			e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
		}
		private void CreateForm() {
			foreach (QueryParameter p in dataSource.Query.Parameters) {
				AddParameter(p);
			}
		}
		private void AddParameter(QueryParameter param) {
			int i = dataSource.Query.Parameters.IndexOf(param);
			Label l = new Label();
			l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			l.Text = param.name;
			l.MinimumSize = l.Size;
			l.AutoSize = true;
			itemsTableLayoutPanel.Controls.Add(l, 0, i);
			switch (param.getSqlDbType()) {
				case SqlDbType.Int:
					NumericUpDown nud = new NumericUpDown();
					nud.Minimum = int.MinValue;
					nud.Maximum = int.MaxValue;
					param.c = nud;
					break;
				case SqlDbType.DateTime:
					DateTimePicker dtp = new DateTimePicker();
					param.c = dtp;
					break;
				default:
					TextBox tbd = new TextBox();
					param.c = tbd;
					break;
			}
			itemsTableLayoutPanel.Controls.Add(param.c, 1, i);
			try {
				var dataGridViewColumn = dgv.Columns[param.autoSourceColumnName];
				if (dataGridViewColumn != null) {
					int index = dgv.Columns.IndexOf(dataGridViewColumn);
					param.c.Text = dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[index].Value.ToString();
				}
			}
			catch { }
		}
		public object GetValue(string Name) {
			foreach(QueryParameter qp in this.dataSource.Query.Parameters) {
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
			string connString = ProgramData.Instance.ConnectionByName(dataSource.ConnectionName).ConnectionString();
			string query = this.dataSource.Query.Command;

			using (var con = new SqlConnection(connString))
			using (var cmd = new SqlCommand(query, con)) {
				for (int i = 0; i < this.dataSource.Query.Parameters.Count; i++) {
					QueryParameter p = this.dataSource.Query.Parameters[i];
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
