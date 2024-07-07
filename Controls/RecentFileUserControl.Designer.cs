namespace QuickDBAccess.Controls {
	partial class RecentFileUserControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ProjectNameLabel = new System.Windows.Forms.Label();
			this.ProjectPathLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.ProjectNameLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ProjectPathLabel, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 40);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Click += new System.EventHandler(this.c_Click);
			this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.c_MouseEnter);
			this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.c_MouseLeave);
			// 
			// ProjectNameLabel
			// 
			this.ProjectNameLabel.AutoSize = true;
			this.ProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProjectNameLabel.Location = new System.Drawing.Point(2, 0);
			this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ProjectNameLabel.Name = "ProjectNameLabel";
			this.ProjectNameLabel.Size = new System.Drawing.Size(139, 20);
			this.ProjectNameLabel.TabIndex = 0;
			this.ProjectNameLabel.Text = "ProjectNameLabel";
			this.ProjectNameLabel.Click += new System.EventHandler(this.c_Click);
			this.ProjectNameLabel.MouseEnter += new System.EventHandler(this.c_MouseEnter);
			this.ProjectNameLabel.MouseLeave += new System.EventHandler(this.c_MouseLeave);
			// 
			// ProjectPathLabel
			// 
			this.ProjectPathLabel.AutoSize = true;
			this.ProjectPathLabel.Location = new System.Drawing.Point(2, 20);
			this.ProjectPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ProjectPathLabel.Name = "ProjectPathLabel";
			this.ProjectPathLabel.Size = new System.Drawing.Size(88, 13);
			this.ProjectPathLabel.TabIndex = 1;
			this.ProjectPathLabel.Text = "ProjectPathLabel";
			this.ProjectPathLabel.Click += new System.EventHandler(this.c_Click);
			this.ProjectPathLabel.MouseEnter += new System.EventHandler(this.c_MouseEnter);
			this.ProjectPathLabel.MouseLeave += new System.EventHandler(this.c_MouseLeave);
			// 
			// RecentFileUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "RecentFileUserControl";
			this.Size = new System.Drawing.Size(450, 40);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label ProjectNameLabel;
		private System.Windows.Forms.Label ProjectPathLabel;
	}
}
