namespace QuickDBAccess.Forms {
	partial class HomeForm {
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ExistingProjectButton = new System.Windows.Forms.Button();
			this.NewProjectButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.RecentFilesGroupBox = new System.Windows.Forms.GroupBox();
			this.RecentFilesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.contentGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.RecentFilesGroupBox.SuspendLayout();
			this.contentGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.ExistingProjectButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.NewProjectButton, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.RecentFilesGroupBox, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 270);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ExistingProjectButton
			// 
			this.ExistingProjectButton.Location = new System.Drawing.Point(3, 76);
			this.ExistingProjectButton.Name = "ExistingProjectButton";
			this.ExistingProjectButton.Size = new System.Drawing.Size(200, 43);
			this.ExistingProjectButton.TabIndex = 1;
			this.ExistingProjectButton.Text = "Open Existing Project";
			this.ExistingProjectButton.UseVisualStyleBackColor = true;
			this.ExistingProjectButton.Click += new System.EventHandler(this.ExistingProjectButton_Click);
			// 
			// NewProjectButton
			// 
			this.NewProjectButton.Location = new System.Drawing.Point(3, 29);
			this.NewProjectButton.Name = "NewProjectButton";
			this.NewProjectButton.Size = new System.Drawing.Size(200, 41);
			this.NewProjectButton.TabIndex = 1;
			this.NewProjectButton.Text = "New Project";
			this.NewProjectButton.UseVisualStyleBackColor = true;
			this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(313, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Welcome to Quick DB Access!\r\nTo begin please create a new project or open an exis" +
    "ting project.";
			// 
			// RecentFilesGroupBox
			// 
			this.RecentFilesGroupBox.AutoSize = true;
			this.RecentFilesGroupBox.Controls.Add(this.RecentFilesTableLayoutPanel);
			this.RecentFilesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.RecentFilesGroupBox.Location = new System.Drawing.Point(3, 125);
			this.RecentFilesGroupBox.Name = "RecentFilesGroupBox";
			this.RecentFilesGroupBox.Size = new System.Drawing.Size(456, 19);
			this.RecentFilesGroupBox.TabIndex = 3;
			this.RecentFilesGroupBox.TabStop = false;
			this.RecentFilesGroupBox.Text = "Recent Files";
			// 
			// RecentFilesTableLayoutPanel
			// 
			this.RecentFilesTableLayoutPanel.AutoSize = true;
			this.RecentFilesTableLayoutPanel.ColumnCount = 1;
			this.RecentFilesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.RecentFilesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.RecentFilesTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.RecentFilesTableLayoutPanel.Name = "RecentFilesTableLayoutPanel";
			this.RecentFilesTableLayoutPanel.RowCount = 1;
			this.RecentFilesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.RecentFilesTableLayoutPanel.Size = new System.Drawing.Size(450, 0);
			this.RecentFilesTableLayoutPanel.TabIndex = 0;
			// 
			// contentGroupBox
			// 
			this.contentGroupBox.AutoSize = true;
			this.contentGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.contentGroupBox.Location = new System.Drawing.Point(12, 12);
			this.contentGroupBox.Name = "contentGroupBox";
			this.contentGroupBox.Size = new System.Drawing.Size(474, 337);
			this.contentGroupBox.TabIndex = 1;
			this.contentGroupBox.TabStop = false;
			this.contentGroupBox.Text = "Quick DB Access";
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.contentGroupBox);
			this.Name = "HomeForm";
			this.Text = "HomeForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.RecentFilesGroupBox.ResumeLayout(false);
			this.RecentFilesGroupBox.PerformLayout();
			this.contentGroupBox.ResumeLayout(false);
			this.contentGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button NewProjectButton;
		private System.Windows.Forms.Button ExistingProjectButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox contentGroupBox;
		private System.Windows.Forms.GroupBox RecentFilesGroupBox;
		private System.Windows.Forms.TableLayoutPanel RecentFilesTableLayoutPanel;
	}
}