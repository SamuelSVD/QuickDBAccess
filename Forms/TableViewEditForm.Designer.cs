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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableViewEditForm));
			this.DataSourceLabel = new System.Windows.Forms.Label();
			this.DataSourceComboBox = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonListView = new System.Windows.Forms.ListView();
			this.TextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ButtonDataSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ParametersLabel = new System.Windows.Forms.Label();
			this.ParentParametersLabel = new System.Windows.Forms.Label();
			this.TableViewListView = new System.Windows.Forms.ListView();
			this.TableViewNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SubTablesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteButtonButton = new System.Windows.Forms.Button();
			this.EditButtonButton = new System.Windows.Forms.Button();
			this.NewButtonButton = new System.Windows.Forms.Button();
			this.NewTableViewButton = new System.Windows.Forms.Button();
			this.EditTableViewButton = new System.Windows.Forms.Button();
			this.DeleteTableViewButton = new System.Windows.Forms.Button();
			this.ButtonsUpButton = new System.Windows.Forms.Button();
			this.ButtonsDownButton = new System.Windows.Forms.Button();
			this.TableViewUpButton = new System.Windows.Forms.Button();
			this.TableViewDownButton = new System.Windows.Forms.Button();
			this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewDetailGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewNameTextBox = new QuickDBAccess.ValidateTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel2.SuspendLayout();
			this.ParametersGroupBox.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.TableViewDetailGroup.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataSourceLabel
			// 
			this.DataSourceLabel.AutoSize = true;
			this.DataSourceLabel.Location = new System.Drawing.Point(3, 41);
			this.DataSourceLabel.Name = "DataSourceLabel";
			this.DataSourceLabel.Size = new System.Drawing.Size(67, 13);
			this.DataSourceLabel.TabIndex = 0;
			this.DataSourceLabel.Text = "Data Source";
			// 
			// DataSourceComboBox
			// 
			this.DataSourceComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceComboBox.FormattingEnabled = true;
			this.DataSourceComboBox.Location = new System.Drawing.Point(3, 57);
			this.DataSourceComboBox.Name = "DataSourceComboBox";
			this.DataSourceComboBox.Size = new System.Drawing.Size(390, 21);
			this.DataSourceComboBox.TabIndex = 1;
			this.DataSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.DataSourceComboBox_SelectedIndexChanged);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.ButtonListView, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.ParametersLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ParentParametersLabel, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.TableViewListView, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.DeleteButtonButton, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.EditButtonButton, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.NewButtonButton, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.NewTableViewButton, 2, 4);
			this.tableLayoutPanel2.Controls.Add(this.EditTableViewButton, 3, 4);
			this.tableLayoutPanel2.Controls.Add(this.DeleteTableViewButton, 4, 4);
			this.tableLayoutPanel2.Controls.Add(this.ButtonsUpButton, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.ButtonsDownButton, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.TableViewUpButton, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.TableViewDownButton, 0, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 213);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// ButtonListView
			// 
			this.ButtonListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TextColumn,
            this.ButtonDataSourceColumn});
			this.ButtonListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonListView.HideSelection = false;
			this.ButtonListView.Location = new System.Drawing.Point(32, 16);
			this.ButtonListView.Name = "ButtonListView";
			this.tableLayoutPanel2.SetRowSpan(this.ButtonListView, 2);
			this.ButtonListView.Size = new System.Drawing.Size(274, 87);
			this.ButtonListView.TabIndex = 2;
			this.ButtonListView.UseCompatibleStateImageBehavior = false;
			this.ButtonListView.View = System.Windows.Forms.View.Details;
			this.ButtonListView.SelectedIndexChanged += new System.EventHandler(this.ButtonListView_SelectedIndexChanged);
			this.ButtonListView.DoubleClick += new System.EventHandler(this.ButtonListView_DoubleClick);
			this.ButtonListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonListView_KeyDown);
			// 
			// TextColumn
			// 
			this.TextColumn.Text = "Text";
			this.TextColumn.Width = 63;
			// 
			// ButtonDataSourceColumn
			// 
			this.ButtonDataSourceColumn.Text = "Data Source";
			this.ButtonDataSourceColumn.Width = 88;
			// 
			// ParametersLabel
			// 
			this.ParametersLabel.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ParametersLabel, 5);
			this.ParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParametersLabel.Location = new System.Drawing.Point(3, 0);
			this.ParametersLabel.Name = "ParametersLabel";
			this.ParametersLabel.Size = new System.Drawing.Size(390, 13);
			this.ParametersLabel.TabIndex = 1;
			this.ParametersLabel.Text = "Buttons";
			// 
			// ParentParametersLabel
			// 
			this.ParentParametersLabel.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ParentParametersLabel, 5);
			this.ParentParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParentParametersLabel.Location = new System.Drawing.Point(3, 106);
			this.ParentParametersLabel.Name = "ParentParametersLabel";
			this.ParentParametersLabel.Size = new System.Drawing.Size(390, 13);
			this.ParentParametersLabel.TabIndex = 2;
			this.ParentParametersLabel.Text = "Table Views";
			// 
			// TableViewListView
			// 
			this.TableViewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableViewNameColumn,
            this.DataSourceColumn,
            this.SubTablesColumn});
			this.TableViewListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableViewListView.HideSelection = false;
			this.TableViewListView.Location = new System.Drawing.Point(32, 122);
			this.TableViewListView.Name = "TableViewListView";
			this.tableLayoutPanel2.SetRowSpan(this.TableViewListView, 2);
			this.TableViewListView.Size = new System.Drawing.Size(274, 88);
			this.TableViewListView.TabIndex = 8;
			this.TableViewListView.UseCompatibleStateImageBehavior = false;
			this.TableViewListView.View = System.Windows.Forms.View.Details;
			this.TableViewListView.SelectedIndexChanged += new System.EventHandler(this.TableViewListView_SelectedIndexChanged);
			this.TableViewListView.DoubleClick += new System.EventHandler(this.TableViewListView_DoubleClick);
			this.TableViewListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TableViewListView_KeyDown);
			// 
			// TableViewNameColumn
			// 
			this.TableViewNameColumn.Text = "Name";
			// 
			// DataSourceColumn
			// 
			this.DataSourceColumn.Text = "Data Source";
			this.DataSourceColumn.Width = 80;
			// 
			// SubTablesColumn
			// 
			this.SubTablesColumn.Text = "Sub-tables";
			this.SubTablesColumn.Width = 73;
			// 
			// DeleteButtonButton
			// 
			this.DeleteButtonButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteButtonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteButtonButton.Enabled = false;
			this.DeleteButtonButton.Location = new System.Drawing.Point(370, 16);
			this.DeleteButtonButton.Name = "DeleteButtonButton";
			this.DeleteButtonButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteButtonButton.TabIndex = 5;
			this.DeleteButtonButton.UseVisualStyleBackColor = true;
			this.DeleteButtonButton.EnabledChanged += new System.EventHandler(this.DeleteButtonButton_EnabledChanged);
			this.DeleteButtonButton.Click += new System.EventHandler(this.DeleteButtonButton_Click);
			// 
			// EditButtonButton
			// 
			this.EditButtonButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditButtonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditButtonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.EditButtonButton.Enabled = false;
			this.EditButtonButton.Location = new System.Drawing.Point(341, 16);
			this.EditButtonButton.Name = "EditButtonButton";
			this.EditButtonButton.Size = new System.Drawing.Size(23, 23);
			this.EditButtonButton.TabIndex = 4;
			this.EditButtonButton.UseVisualStyleBackColor = true;
			this.EditButtonButton.EnabledChanged += new System.EventHandler(this.EditButtonButton_EnabledChanged);
			this.EditButtonButton.Click += new System.EventHandler(this.EditButtonButton_Click);
			// 
			// NewButtonButton
			// 
			this.NewButtonButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewButtonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewButtonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.NewButtonButton.Location = new System.Drawing.Point(312, 16);
			this.NewButtonButton.Name = "NewButtonButton";
			this.NewButtonButton.Size = new System.Drawing.Size(23, 23);
			this.NewButtonButton.TabIndex = 3;
			this.NewButtonButton.UseVisualStyleBackColor = true;
			this.NewButtonButton.Click += new System.EventHandler(this.NewButtonButton_Click);
			// 
			// NewTableViewButton
			// 
			this.NewTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewTableViewButton.Location = new System.Drawing.Point(312, 122);
			this.NewTableViewButton.Name = "NewTableViewButton";
			this.NewTableViewButton.Size = new System.Drawing.Size(23, 23);
			this.NewTableViewButton.TabIndex = 9;
			this.NewTableViewButton.UseVisualStyleBackColor = true;
			this.NewTableViewButton.Click += new System.EventHandler(this.NewTableViewButton_Click);
			// 
			// EditTableViewButton
			// 
			this.EditTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditTableViewButton.Enabled = false;
			this.EditTableViewButton.Location = new System.Drawing.Point(341, 122);
			this.EditTableViewButton.Name = "EditTableViewButton";
			this.EditTableViewButton.Size = new System.Drawing.Size(23, 23);
			this.EditTableViewButton.TabIndex = 10;
			this.EditTableViewButton.UseVisualStyleBackColor = true;
			this.EditTableViewButton.EnabledChanged += new System.EventHandler(this.EditTableViewButton_EnabledChanged);
			this.EditTableViewButton.Click += new System.EventHandler(this.EditTableViewButton_Click);
			// 
			// DeleteTableViewButton
			// 
			this.DeleteTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteTableViewButton.Enabled = false;
			this.DeleteTableViewButton.Location = new System.Drawing.Point(370, 122);
			this.DeleteTableViewButton.Name = "DeleteTableViewButton";
			this.DeleteTableViewButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteTableViewButton.TabIndex = 11;
			this.DeleteTableViewButton.UseVisualStyleBackColor = true;
			this.DeleteTableViewButton.EnabledChanged += new System.EventHandler(this.DeleteTableViewButton_EnabledChanged);
			this.DeleteTableViewButton.Click += new System.EventHandler(this.DeleteTableViewButton_Click);
			// 
			// ButtonsUpButton
			// 
			this.ButtonsUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.ButtonsUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ButtonsUpButton.Enabled = false;
			this.ButtonsUpButton.Location = new System.Drawing.Point(3, 16);
			this.ButtonsUpButton.Name = "ButtonsUpButton";
			this.ButtonsUpButton.Size = new System.Drawing.Size(23, 23);
			this.ButtonsUpButton.TabIndex = 0;
			this.ButtonsUpButton.UseVisualStyleBackColor = true;
			this.ButtonsUpButton.EnabledChanged += new System.EventHandler(this.ButtonsUpButton_EnabledChanged);
			this.ButtonsUpButton.Click += new System.EventHandler(this.ButtonsUpButton_Click);
			// 
			// ButtonsDownButton
			// 
			this.ButtonsDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.ButtonsDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ButtonsDownButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonsDownButton.Enabled = false;
			this.ButtonsDownButton.Location = new System.Drawing.Point(3, 45);
			this.ButtonsDownButton.Name = "ButtonsDownButton";
			this.ButtonsDownButton.Size = new System.Drawing.Size(23, 23);
			this.ButtonsDownButton.TabIndex = 1;
			this.ButtonsDownButton.UseVisualStyleBackColor = true;
			this.ButtonsDownButton.EnabledChanged += new System.EventHandler(this.ButtonsDownButton_EnabledChanged);
			this.ButtonsDownButton.Click += new System.EventHandler(this.ButtonsDownButton_Click);
			// 
			// TableViewUpButton
			// 
			this.TableViewUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.TableViewUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TableViewUpButton.Enabled = false;
			this.TableViewUpButton.Location = new System.Drawing.Point(3, 122);
			this.TableViewUpButton.Name = "TableViewUpButton";
			this.TableViewUpButton.Size = new System.Drawing.Size(23, 23);
			this.TableViewUpButton.TabIndex = 6;
			this.TableViewUpButton.UseVisualStyleBackColor = true;
			this.TableViewUpButton.EnabledChanged += new System.EventHandler(this.TableViewUpButton_EnabledChanged);
			this.TableViewUpButton.Click += new System.EventHandler(this.TableViewUpButton_Click);
			// 
			// TableViewDownButton
			// 
			this.TableViewDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.TableViewDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TableViewDownButton.Enabled = false;
			this.TableViewDownButton.Location = new System.Drawing.Point(3, 151);
			this.TableViewDownButton.Name = "TableViewDownButton";
			this.TableViewDownButton.Size = new System.Drawing.Size(23, 23);
			this.TableViewDownButton.TabIndex = 7;
			this.TableViewDownButton.UseVisualStyleBackColor = true;
			this.TableViewDownButton.EnabledChanged += new System.EventHandler(this.TableViewDownButton_EnabledChanged);
			this.TableViewDownButton.Click += new System.EventHandler(this.TableViewDownButton_Click);
			// 
			// ParametersGroupBox
			// 
			this.ParametersGroupBox.AutoSize = true;
			this.ParametersGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.SetColumnSpan(this.ParametersGroupBox, 4);
			this.ParametersGroupBox.Controls.Add(this.tableLayoutPanel2);
			this.ParametersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParametersGroupBox.Location = new System.Drawing.Point(3, 109);
			this.ParametersGroupBox.Name = "ParametersGroupBox";
			this.ParametersGroupBox.Size = new System.Drawing.Size(402, 232);
			this.ParametersGroupBox.TabIndex = 1;
			this.ParametersGroupBox.TabStop = false;
			this.ParametersGroupBox.Text = "Details";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.ParametersGroupBox, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.TableViewDetailGroup, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.OkButton, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.CancelButton, 3, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(408, 373);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// TableViewDetailGroup
			// 
			this.TableViewDetailGroup.AutoSize = true;
			this.TableViewDetailGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.SetColumnSpan(this.TableViewDetailGroup, 4);
			this.TableViewDetailGroup.Controls.Add(this.tableLayoutPanel4);
			this.TableViewDetailGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableViewDetailGroup.Location = new System.Drawing.Point(3, 3);
			this.TableViewDetailGroup.Name = "TableViewDetailGroup";
			this.TableViewDetailGroup.Size = new System.Drawing.Size(402, 100);
			this.TableViewDetailGroup.TabIndex = 0;
			this.TableViewDetailGroup.TabStop = false;
			this.TableViewDetailGroup.Text = "Table View Properties";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.TableViewNameTextBox, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.DataSourceLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.DataSourceComboBox, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(396, 81);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// TableViewNameTextBox
			// 
			this.TableViewNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TableViewNameTextBox.Location = new System.Drawing.Point(3, 16);
			this.TableViewNameTextBox.Name = "TableViewNameTextBox";
			this.TableViewNameTextBox.Size = new System.Drawing.Size(390, 22);
			this.TableViewNameTextBox.TabIndex = 0;
			this.TableViewNameTextBox.TooltipText = "Field should not be empty";
			this.TableViewNameTextBox.Valid = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Table View Name";
			// 
			// OkButton
			// 
			this.OkButton.AutoSize = true;
			this.OkButton.Location = new System.Drawing.Point(249, 347);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 2;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.AutoSize = true;
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(330, 347);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// TableViewEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(408, 373);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(424, 412);
			this.Name = "TableViewEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Table View";
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ParametersGroupBox.ResumeLayout(false);
			this.ParametersGroupBox.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.TableViewDetailGroup.ResumeLayout(false);
			this.TableViewDetailGroup.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label DataSourceLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label ParametersLabel;
		private System.Windows.Forms.Label ParentParametersLabel;
		private System.Windows.Forms.GroupBox ParametersGroupBox;
		private System.Windows.Forms.Button NewButtonButton;
		private System.Windows.Forms.Button EditButtonButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button DeleteButtonButton;
		private System.Windows.Forms.Button NewTableViewButton;
		private System.Windows.Forms.Button EditTableViewButton;
		private System.Windows.Forms.Button DeleteTableViewButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.GroupBox TableViewDetailGroup;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.ListView ButtonListView;
		private System.Windows.Forms.ListView TableViewListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox DataSourceComboBox;
		private System.Windows.Forms.Button ButtonsUpButton;
		private System.Windows.Forms.Button ButtonsDownButton;
		private System.Windows.Forms.Button TableViewUpButton;
		private System.Windows.Forms.Button TableViewDownButton;
		private ValidateTextBox TableViewNameTextBox;
		private System.Windows.Forms.ColumnHeader TableViewNameColumn;
		private System.Windows.Forms.ColumnHeader DataSourceColumn;
		private System.Windows.Forms.ColumnHeader SubTablesColumn;
		private System.Windows.Forms.ColumnHeader TextColumn;
		private System.Windows.Forms.ColumnHeader ButtonDataSourceColumn;
	}
}