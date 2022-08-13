
namespace QuickDBAccess.Forms
{
    partial class TableViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.ContentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ContentDataGridView = new System.Windows.Forms.DataGridView();
			this.ChildrenTabControl = new System.Windows.Forms.TabControl();
			this.ContentTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ContentDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ContentTableLayoutPanel
			// 
			this.ContentTableLayoutPanel.AutoSize = true;
			this.ContentTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ContentTableLayoutPanel.ColumnCount = 1;
			this.ContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ContentTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 0);
			this.ContentTableLayoutPanel.Controls.Add(this.ContentDataGridView, 0, 1);
			this.ContentTableLayoutPanel.Controls.Add(this.ChildrenTabControl, 0, 2);
			this.ContentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ContentTableLayoutPanel.Name = "ContentTableLayoutPanel";
			this.ContentTableLayoutPanel.RowCount = 3;
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.ContentTableLayoutPanel.Size = new System.Drawing.Size(325, 211);
			this.ContentTableLayoutPanel.TabIndex = 0;
			// 
			// ButtonsTableLayoutPanel
			// 
			this.ButtonsTableLayoutPanel.AutoSize = true;
			this.ButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonsTableLayoutPanel.ColumnCount = 1;
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
			this.ButtonsTableLayoutPanel.RowCount = 1;
			this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(397, 1);
			this.ButtonsTableLayoutPanel.TabIndex = 0;
			// 
			// ContentDataGridView
			// 
			this.ContentDataGridView.AllowUserToAddRows = false;
			this.ContentDataGridView.AllowUserToDeleteRows = false;
			this.ContentDataGridView.AllowUserToOrderColumns = true;
			this.ContentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ContentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentDataGridView.Location = new System.Drawing.Point(3, 9);
			this.ContentDataGridView.Name = "ContentDataGridView";
			this.ContentDataGridView.Size = new System.Drawing.Size(397, 117);
			this.ContentDataGridView.TabIndex = 1;
			// 
			// ChildrenTabControl
			// 
			this.ChildrenTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChildrenTabControl.Location = new System.Drawing.Point(3, 132);
			this.ChildrenTabControl.Name = "ChildrenTabControl";
			this.ChildrenTabControl.SelectedIndex = 0;
			this.ChildrenTabControl.Size = new System.Drawing.Size(397, 76);
			this.ChildrenTabControl.TabIndex = 2;
			// 
			// TableViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(325, 211);
			this.Controls.Add(this.ContentTableLayoutPanel);
			this.Name = "TableViewForm";
			this.Text = "TableViewForm";
			this.ContentTableLayoutPanel.ResumeLayout(false);
			this.ContentTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ContentDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContentTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.DataGridView ContentDataGridView;
		private System.Windows.Forms.TabControl ChildrenTabControl;
	}
}