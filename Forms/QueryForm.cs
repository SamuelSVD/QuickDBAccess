using QuickDBAccess.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuickDBAccess.Forms
{
    public partial class QueryForm : Form
    {
        private Query query;
        private SQLConnection connection;
        private DataGridView dgv;
        public QueryForm(Query query, SQLConnection connection, DataGridView dgv)
        {
            InitializeComponent();
            this.query = query;
            this.connection = connection;
            this.dgv = dgv;
            CreateForm();
        }
        private void CreateForm()
        {
            foreach (QueryParameter p in query.parameters)
            {
                AddParameter(p);
            }
        }
        private void AddParameter(QueryParameter param)
        {
            int i = query.parameters.IndexOf(param);
            Label l = new Label();
            l.Text = param.name;
            itemsTableLayoutPanel.Controls.Add(l, 0, i);
            switch (param.getSqlDbType())
            {
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
            try
            {
                var dataGridViewColumn = dgv.Columns[param.autoSourceColumnName];
                if (dataGridViewColumn != null)
                {
                    int index = dgv.Columns.IndexOf(dataGridViewColumn);
                    param.c.Text = dgv.Rows[dgv.SelectedCells[0].RowIndex].Cells[index].Value.ToString();
                }
            }
            catch { }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            string connString = connection.ConnectionString();//
            string query = this.query.command;

            using (var con = new SqlConnection(connString))
            using (var cmd = new SqlCommand(query, con))
            {
                for (int i = 0; i < this.query.parameters.Count; i++)
                {
                    QueryParameter p = this.query.parameters[i];
                    cmd.Parameters.Add("@" + p.name, p.getSqlDbType());
                    cmd.Parameters["@" + p.name].Value = p.getValue();
                }
                try
                {
                    con.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(String.Format("RowsAffected: {0}", rowsAffected));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }
    }
}
