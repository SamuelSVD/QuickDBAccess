namespace QuickDBAccess.Forms {
	partial class TableViewEditForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.listView1 = new System.Windows.Forms.ListView();
			this.QueryGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.DataSourceLabel = new System.Windows.Forms.Label();
			this.QueryLabel = new System.Windows.Forms.Label();
			this.DataSourceComboBox = new System.Windows.Forms.ComboBox();
			this.QueryRichTextBox = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ParametersLabel = new System.Windows.Forms.Label();
			this.ParentParametersLabel = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.QueryGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.ParametersGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(3, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(394, 28);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// QueryGroupBox
			// 
			this.QueryGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.QueryGroupBox.Location = new System.Drawing.Point(12, 12);
			this.QueryGroupBox.Name = "QueryGroupBox";
			this.QueryGroupBox.Size = new System.Drawing.Size(409, 143);
			this.QueryGroupBox.TabIndex = 1;
			this.QueryGroupBox.TabStop = false;
			this.QueryGroupBox.Text = "Data Source Details";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.DataSourceLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.QueryLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.DataSourceComboBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.QueryRichTextBox, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 124);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// DataSourceLabel
			// 
			this.DataSourceLabel.AutoSize = true;
			this.DataSourceLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceLabel.Location = new System.Drawing.Point(3, 0);
			this.DataSourceLabel.Name = "DataSourceLabel";
			this.DataSourceLabel.Size = new System.Drawing.Size(397, 13);
			this.DataSourceLabel.TabIndex = 0;
			this.DataSourceLabel.Text = "Data Source";
			// 
			// QueryLabel
			// 
			this.QueryLabel.AutoSize = true;
			this.QueryLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.QueryLabel.Location = new System.Drawing.Point(3, 40);
			this.QueryLabel.Name = "QueryLabel";
			this.QueryLabel.Size = new System.Drawing.Size(397, 13);
			this.QueryLabel.TabIndex = 1;
			this.QueryLabel.Text = "Query";
			// 
			// DataSourceComboBox
			// 
			this.DataSourceComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceComboBox.FormattingEnabled = true;
			this.DataSourceComboBox.Location = new System.Drawing.Point(3, 16);
			this.DataSourceComboBox.Name = "DataSourceComboBox";
			this.DataSourceComboBox.Size = new System.Drawing.Size(397, 21);
			this.DataSourceComboBox.TabIndex = 2;
			// 
			// QueryRichTextBox
			// 
			this.QueryRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.QueryRichTextBox.Location = new System.Drawing.Point(3, 56);
			this.QueryRichTextBox.Name = "QueryRichTextBox";
			this.QueryRichTextBox.Size = new System.Drawing.Size(397, 63);
			this.QueryRichTextBox.TabIndex = 3;
			this.QueryRichTextBox.Text = "";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.ParametersLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ParentParametersLabel, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.listView2, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 114);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// ParametersLabel
			// 
			this.ParametersLabel.AutoSize = true;
			this.ParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParametersLabel.Location = new System.Drawing.Point(3, 0);
			this.ParametersLabel.Name = "ParametersLabel";
			this.ParametersLabel.Size = new System.Drawing.Size(394, 13);
			this.ParametersLabel.TabIndex = 1;
			this.ParametersLabel.Text = "Parameters";
			// 
			// ParentParametersLabel
			// 
			this.ParentParametersLabel.AutoSize = true;
			this.ParentParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParentParametersLabel.Location = new System.Drawing.Point(3, 47);
			this.ParentParametersLabel.Name = "ParentParametersLabel";
			this.ParentParametersLabel.Size = new System.Drawing.Size(394, 13);
			this.ParentParametersLabel.TabIndex = 2;
			this.ParentParametersLabel.Text = "Parent Parameters";
			// 
			// listView2
			// 
			this.listView2.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(3, 63);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(394, 43);
			this.listView2.TabIndex = 3;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// ParametersGroupBox
			// 
			this.ParametersGroupBox.Controls.Add(this.tableLayoutPanel2);
			this.ParametersGroupBox.Location = new System.Drawing.Point(15, 161);
			this.ParametersGroupBox.Name = "ParametersGroupBox";
			this.ParametersGroupBox.Size = new System.Drawing.Size(406, 133);
			this.ParametersGroupBox.TabIndex = 4;
			this.ParametersGroupBox.TabStop = false;
			this.ParametersGroupBox.Text = "Parameters";
			// 
			// TableViewEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ParametersGroupBox);
			this.Controls.Add(this.QueryGroupBox);
			this.Name = "TableViewEditForm";
			this.Text = "Edit Table View";
			this.QueryGroupBox.ResumeLayout(false);
			this.QueryGroupBox.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ParametersGroupBox.ResumeLayout(false);
			this.ParametersGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox QueryGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label DataSourceLabel;
		private System.Windows.Forms.Label QueryLabel;
		private System.Windows.Forms.ComboBox DataSourceComboBox;
		private System.Windows.Forms.RichTextBox QueryRichTextBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label ParametersLabel;
		private System.Windows.Forms.Label ParentParametersLabel;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.GroupBox ParametersGroupBox;
	}
}