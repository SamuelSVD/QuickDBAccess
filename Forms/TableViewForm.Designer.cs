
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableViewForm));
			this.ContentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ContentDataGridView = new System.Windows.Forms.DataGridView();
			this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ChildrenTabControl = new System.Windows.Forms.TabControl();
			this.ContentSplitContainer = new System.Windows.Forms.SplitContainer();
			this.ParametersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ContentTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ContentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ContentSplitContainer)).BeginInit();
			this.ContentSplitContainer.Panel1.SuspendLayout();
			this.ContentSplitContainer.Panel2.SuspendLayout();
			this.ContentSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContentTableLayoutPanel
			// 
			this.ContentTableLayoutPanel.AutoSize = true;
			this.ContentTableLayoutPanel.ColumnCount = 1;
			this.ContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ContentTableLayoutPanel.Controls.Add(this.ParametersTableLayoutPanel, 0, 1);
			this.ContentTableLayoutPanel.Controls.Add(this.ContentDataGridView, 0, 2);
			this.ContentTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 0);
			this.ContentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ContentTableLayoutPanel.Name = "ContentTableLayoutPanel";
			this.ContentTableLayoutPanel.RowCount = 3;
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ContentTableLayoutPanel.Size = new System.Drawing.Size(221, 69);
			this.ContentTableLayoutPanel.TabIndex = 0;
			// 
			// ContentDataGridView
			// 
			this.ContentDataGridView.AllowUserToAddRows = false;
			this.ContentDataGridView.AllowUserToDeleteRows = false;
			this.ContentDataGridView.AllowUserToOrderColumns = true;
			this.ContentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ContentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentDataGridView.Location = new System.Drawing.Point(3, 15);
			this.ContentDataGridView.Name = "ContentDataGridView";
			this.ContentDataGridView.ReadOnly = true;
			this.ContentDataGridView.Size = new System.Drawing.Size(215, 57);
			this.ContentDataGridView.TabIndex = 1;
			this.ContentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContentDataGridView_CellContentClick);
			this.ContentDataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ContentDataGridView_CellStateChanged);
			this.ContentDataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ContentDataGridView_ColumnAdded);
			this.ContentDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ContentDataGridView_RowStateChanged);
			// 
			// ButtonsTableLayoutPanel
			// 
			this.ButtonsTableLayoutPanel.AutoSize = true;
			this.ButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonsTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.ButtonsTableLayoutPanel.ColumnCount = 1;
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
			this.ButtonsTableLayoutPanel.RowCount = 1;
			this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(215, 1);
			this.ButtonsTableLayoutPanel.TabIndex = 0;
			// 
			// ChildrenTabControl
			// 
			this.ChildrenTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChildrenTabControl.Location = new System.Drawing.Point(0, 0);
			this.ChildrenTabControl.Name = "ChildrenTabControl";
			this.ChildrenTabControl.SelectedIndex = 0;
			this.ChildrenTabControl.Size = new System.Drawing.Size(221, 86);
			this.ChildrenTabControl.TabIndex = 2;
			// 
			// ContentSplitContainer
			// 
			this.ContentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.ContentSplitContainer.Name = "ContentSplitContainer";
			this.ContentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ContentSplitContainer.Panel1
			// 
			this.ContentSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.ContentSplitContainer.Panel1.Controls.Add(this.ContentTableLayoutPanel);
			// 
			// ContentSplitContainer.Panel2
			// 
			this.ContentSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.ContentSplitContainer.Panel2.Controls.Add(this.ChildrenTabControl);
			this.ContentSplitContainer.Size = new System.Drawing.Size(221, 159);
			this.ContentSplitContainer.SplitterDistance = 69;
			this.ContentSplitContainer.TabIndex = 1;
			// 
			// ParametersTableLayoutPanel
			// 
			this.ParametersTableLayoutPanel.AutoSize = true;
			this.ParametersTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ParametersTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.ParametersTableLayoutPanel.ColumnCount = 1;
			this.ParametersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ParametersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.ParametersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParametersTableLayoutPanel.Location = new System.Drawing.Point(3, 9);
			this.ParametersTableLayoutPanel.Name = "ParametersTableLayoutPanel";
			this.ParametersTableLayoutPanel.RowCount = 1;
			this.ParametersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.ParametersTableLayoutPanel.Size = new System.Drawing.Size(215, 1);
			this.ParametersTableLayoutPanel.TabIndex = 1;
			// 
			// TableViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(221, 159);
			this.Controls.Add(this.ContentSplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TableViewForm";
			this.Text = "TableViewForm";
			this.ContentTableLayoutPanel.ResumeLayout(false);
			this.ContentTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ContentDataGridView)).EndInit();
			this.ContentSplitContainer.Panel1.ResumeLayout(false);
			this.ContentSplitContainer.Panel1.PerformLayout();
			this.ContentSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ContentSplitContainer)).EndInit();
			this.ContentSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContentTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.DataGridView ContentDataGridView;
		private System.Windows.Forms.TabControl ChildrenTabControl;
		private System.Windows.Forms.SplitContainer ContentSplitContainer;
		private System.Windows.Forms.TableLayoutPanel ParametersTableLayoutPanel;
	}
}