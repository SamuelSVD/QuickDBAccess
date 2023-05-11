namespace QuickDBAccess.Forms {
	partial class DataSourceEditForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceEditForm));
			this.ParameterListView = new System.Windows.Forms.ListView();
			this.PNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PAutoSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ParentParametersLabel = new System.Windows.Forms.Label();
			this.ParentParameterListView = new System.Windows.Forms.ListView();
			this.PPNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PPTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PPAutoSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NewParameterButton = new System.Windows.Forms.Button();
			this.EditParameterButton = new System.Windows.Forms.Button();
			this.DeleteParameterButton = new System.Windows.Forms.Button();
			this.NewParentParameterButton = new System.Windows.Forms.Button();
			this.EditParentParameterButton = new System.Windows.Forms.Button();
			this.DeleteParentParameterButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.QueryGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.QueryLabel = new System.Windows.Forms.Label();
			this.ParametersLabel = new System.Windows.Forms.Label();
			this.QueryRichTextBox = new System.Windows.Forms.RichTextBox();
			this.ParentParameterUpButton = new System.Windows.Forms.Button();
			this.ParameterUpButton = new System.Windows.Forms.Button();
			this.ParameterDownButton = new System.Windows.Forms.Button();
			this.ParentParameterDownButton = new System.Windows.Forms.Button();
			this.TableViewDetailGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.DataSourceNameTextBox = new QuickDBAccess.ValidateTextBox();
			this.ConnectionComboBox = new System.Windows.Forms.ComboBox();
			this.ConnectionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3.SuspendLayout();
			this.QueryGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.TableViewDetailGroup.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// ParameterListView
			// 
			this.ParameterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PNameColumn,
            this.PTypeColumn,
            this.PAutoSourceColumn});
			this.ParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParameterListView.HideSelection = false;
			this.ParameterListView.Location = new System.Drawing.Point(32, 136);
			this.ParameterListView.Name = "ParameterListView";
			this.tableLayoutPanel1.SetRowSpan(this.ParameterListView, 2);
			this.ParameterListView.Size = new System.Drawing.Size(316, 76);
			this.ParameterListView.TabIndex = 5;
			this.ParameterListView.UseCompatibleStateImageBehavior = false;
			this.ParameterListView.View = System.Windows.Forms.View.Details;
			this.ParameterListView.SelectedIndexChanged += new System.EventHandler(this.ParameterListView_SelectedIndexChanged);
			this.ParameterListView.DoubleClick += new System.EventHandler(this.ParameterListView_DoubleClick);
			// 
			// PNameColumn
			// 
			this.PNameColumn.Text = "Name";
			this.PNameColumn.Width = 101;
			// 
			// PTypeColumn
			// 
			this.PTypeColumn.Text = "Type";
			// 
			// PAutoSourceColumn
			// 
			this.PAutoSourceColumn.Text = "Auto Source Column";
			this.PAutoSourceColumn.Width = 121;
			// 
			// ParentParametersLabel
			// 
			this.ParentParametersLabel.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.ParentParametersLabel, 5);
			this.ParentParametersLabel.Location = new System.Drawing.Point(3, 215);
			this.ParentParametersLabel.Name = "ParentParametersLabel";
			this.ParentParametersLabel.Size = new System.Drawing.Size(94, 13);
			this.ParentParametersLabel.TabIndex = 2;
			this.ParentParametersLabel.Text = "Parent Parameters";
			// 
			// ParentParameterListView
			// 
			this.ParentParameterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PPNameColumn,
            this.PPTypeColumn,
            this.PPAutoSourceColumn});
			this.ParentParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParentParameterListView.HideSelection = false;
			this.ParentParameterListView.Location = new System.Drawing.Point(32, 231);
			this.ParentParameterListView.Name = "ParentParameterListView";
			this.tableLayoutPanel1.SetRowSpan(this.ParentParameterListView, 2);
			this.ParentParameterListView.Size = new System.Drawing.Size(316, 77);
			this.ParentParameterListView.TabIndex = 11;
			this.ParentParameterListView.UseCompatibleStateImageBehavior = false;
			this.ParentParameterListView.View = System.Windows.Forms.View.Details;
			this.ParentParameterListView.SelectedIndexChanged += new System.EventHandler(this.ParentParameterListView_SelectedIndexChanged);
			this.ParentParameterListView.DoubleClick += new System.EventHandler(this.ParentParameterListView_DoubleClick);
			// 
			// PPNameColumn
			// 
			this.PPNameColumn.Text = "Name";
			this.PPNameColumn.Width = 100;
			// 
			// PPTypeColumn
			// 
			this.PPTypeColumn.Text = "Type";
			// 
			// PPAutoSourceColumn
			// 
			this.PPAutoSourceColumn.Text = "Auto Source Column";
			this.PPAutoSourceColumn.Width = 120;
			// 
			// NewParameterButton
			// 
			this.NewParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewParameterButton.Location = new System.Drawing.Point(354, 136);
			this.NewParameterButton.Name = "NewParameterButton";
			this.NewParameterButton.Size = new System.Drawing.Size(23, 23);
			this.NewParameterButton.TabIndex = 6;
			this.NewParameterButton.UseVisualStyleBackColor = true;
			this.NewParameterButton.Click += new System.EventHandler(this.AddParameterButton_Click);
			// 
			// EditParameterButton
			// 
			this.EditParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParameterButton.Enabled = false;
			this.EditParameterButton.Location = new System.Drawing.Point(383, 136);
			this.EditParameterButton.Name = "EditParameterButton";
			this.EditParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParameterButton.TabIndex = 7;
			this.EditParameterButton.UseVisualStyleBackColor = true;
			this.EditParameterButton.EnabledChanged += new System.EventHandler(this.EditParameterButton_EnabledChanged);
			this.EditParameterButton.Click += new System.EventHandler(this.EditParameterButton_Click);
			// 
			// DeleteParameterButton
			// 
			this.DeleteParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParameterButton.Enabled = false;
			this.DeleteParameterButton.Location = new System.Drawing.Point(412, 136);
			this.DeleteParameterButton.Name = "DeleteParameterButton";
			this.DeleteParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParameterButton.TabIndex = 8;
			this.DeleteParameterButton.UseVisualStyleBackColor = true;
			this.DeleteParameterButton.EnabledChanged += new System.EventHandler(this.DeleteParameterButton_EnabledChanged);
			this.DeleteParameterButton.Click += new System.EventHandler(this.DeleteParameterButton_Click);
			// 
			// NewParentParameterButton
			// 
			this.NewParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewParentParameterButton.Location = new System.Drawing.Point(354, 231);
			this.NewParentParameterButton.Name = "NewParentParameterButton";
			this.NewParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.NewParentParameterButton.TabIndex = 12;
			this.NewParentParameterButton.UseVisualStyleBackColor = true;
			this.NewParentParameterButton.Click += new System.EventHandler(this.AddParentParameterButton_Click);
			// 
			// EditParentParameterButton
			// 
			this.EditParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParentParameterButton.Enabled = false;
			this.EditParentParameterButton.Location = new System.Drawing.Point(383, 231);
			this.EditParentParameterButton.Name = "EditParentParameterButton";
			this.EditParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParentParameterButton.TabIndex = 13;
			this.EditParentParameterButton.UseVisualStyleBackColor = true;
			this.EditParentParameterButton.EnabledChanged += new System.EventHandler(this.EditParentParameterButton_EnabledChanged);
			this.EditParentParameterButton.Click += new System.EventHandler(this.EditParentParameterButton_Click);
			// 
			// DeleteParentParameterButton
			// 
			this.DeleteParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParentParameterButton.Enabled = false;
			this.DeleteParentParameterButton.Location = new System.Drawing.Point(412, 231);
			this.DeleteParentParameterButton.Name = "DeleteParentParameterButton";
			this.DeleteParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParentParameterButton.TabIndex = 14;
			this.DeleteParentParameterButton.UseVisualStyleBackColor = true;
			this.DeleteParentParameterButton.EnabledChanged += new System.EventHandler(this.DeleteParentParameterButton_EnabledChanged);
			this.DeleteParentParameterButton.Click += new System.EventHandler(this.DeleteParentParameterButton_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.QueryGroupBox, 0, 1);
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
			this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 471);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// QueryGroupBox
			// 
			this.QueryGroupBox.AutoSize = true;
			this.QueryGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.SetColumnSpan(this.QueryGroupBox, 4);
			this.QueryGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.QueryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QueryGroupBox.Location = new System.Drawing.Point(3, 109);
			this.QueryGroupBox.Name = "QueryGroupBox";
			this.QueryGroupBox.Size = new System.Drawing.Size(444, 330);
			this.QueryGroupBox.TabIndex = 1;
			this.QueryGroupBox.TabStop = false;
			this.QueryGroupBox.Text = "Query Details";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.ParentParameterListView, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.ParameterListView, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.QueryLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ParametersLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.QueryRichTextBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.DeleteParameterButton, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.EditParameterButton, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.NewParameterButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.ParentParameterUpButton, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.ParentParametersLabel, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.NewParentParameterButton, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.EditParentParameterButton, 3, 6);
			this.tableLayoutPanel1.Controls.Add(this.DeleteParentParameterButton, 4, 6);
			this.tableLayoutPanel1.Controls.Add(this.ParameterUpButton, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.ParameterDownButton, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.ParentParameterDownButton, 0, 7);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 311);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// QueryLabel
			// 
			this.QueryLabel.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.QueryLabel, 5);
			this.QueryLabel.Location = new System.Drawing.Point(3, 0);
			this.QueryLabel.Name = "QueryLabel";
			this.QueryLabel.Size = new System.Drawing.Size(35, 13);
			this.QueryLabel.TabIndex = 1;
			this.QueryLabel.Text = "Query";
			// 
			// ParametersLabel
			// 
			this.ParametersLabel.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.ParametersLabel, 5);
			this.ParametersLabel.Location = new System.Drawing.Point(3, 120);
			this.ParametersLabel.Name = "ParametersLabel";
			this.ParametersLabel.Size = new System.Drawing.Size(60, 13);
			this.ParametersLabel.TabIndex = 1;
			this.ParametersLabel.Text = "Parameters";
			// 
			// QueryRichTextBox
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.QueryRichTextBox, 5);
			this.QueryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QueryRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.QueryRichTextBox.Name = "QueryRichTextBox";
			this.QueryRichTextBox.Size = new System.Drawing.Size(432, 101);
			this.QueryRichTextBox.TabIndex = 2;
			this.QueryRichTextBox.Text = "";
			this.QueryRichTextBox.TextChanged += new System.EventHandler(this.QueryRichTextBox_TextChanged);
			// 
			// ParentParameterUpButton
			// 
			this.ParentParameterUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.ParentParameterUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ParentParameterUpButton.Enabled = false;
			this.ParentParameterUpButton.Location = new System.Drawing.Point(3, 231);
			this.ParentParameterUpButton.Name = "ParentParameterUpButton";
			this.ParentParameterUpButton.Size = new System.Drawing.Size(23, 23);
			this.ParentParameterUpButton.TabIndex = 9;
			this.ParentParameterUpButton.UseVisualStyleBackColor = true;
			this.ParentParameterUpButton.EnabledChanged += new System.EventHandler(this.ParentParameterUpButton_EnabledChanged);
			this.ParentParameterUpButton.Click += new System.EventHandler(this.ParentParameterUpButton_Click);
			// 
			// ParameterUpButton
			// 
			this.ParameterUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.ParameterUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ParameterUpButton.Enabled = false;
			this.ParameterUpButton.Location = new System.Drawing.Point(3, 136);
			this.ParameterUpButton.Name = "ParameterUpButton";
			this.ParameterUpButton.Size = new System.Drawing.Size(23, 23);
			this.ParameterUpButton.TabIndex = 3;
			this.ParameterUpButton.UseVisualStyleBackColor = true;
			this.ParameterUpButton.EnabledChanged += new System.EventHandler(this.ParameterUpButton_EnabledChanged);
			this.ParameterUpButton.Click += new System.EventHandler(this.ParameterUpButton_Click);
			// 
			// ParameterDownButton
			// 
			this.ParameterDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.ParameterDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ParameterDownButton.Enabled = false;
			this.ParameterDownButton.Location = new System.Drawing.Point(3, 165);
			this.ParameterDownButton.Name = "ParameterDownButton";
			this.ParameterDownButton.Size = new System.Drawing.Size(23, 23);
			this.ParameterDownButton.TabIndex = 4;
			this.ParameterDownButton.UseVisualStyleBackColor = true;
			this.ParameterDownButton.EnabledChanged += new System.EventHandler(this.ParameterDownButton_EnabledChanged);
			this.ParameterDownButton.Click += new System.EventHandler(this.ParameterDownButton_Click);
			// 
			// ParentParameterDownButton
			// 
			this.ParentParameterDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.ParentParameterDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ParentParameterDownButton.Enabled = false;
			this.ParentParameterDownButton.Location = new System.Drawing.Point(3, 260);
			this.ParentParameterDownButton.Name = "ParentParameterDownButton";
			this.ParentParameterDownButton.Size = new System.Drawing.Size(23, 23);
			this.ParentParameterDownButton.TabIndex = 10;
			this.ParentParameterDownButton.UseVisualStyleBackColor = true;
			this.ParentParameterDownButton.EnabledChanged += new System.EventHandler(this.ParentParameterDownButton_EnabledChanged);
			this.ParentParameterDownButton.Click += new System.EventHandler(this.ParentParameterDownButton_Click);
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
			this.TableViewDetailGroup.Size = new System.Drawing.Size(444, 100);
			this.TableViewDetailGroup.TabIndex = 0;
			this.TableViewDetailGroup.TabStop = false;
			this.TableViewDetailGroup.Text = "Data Source Properties";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.DataSourceNameTextBox, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.ConnectionComboBox, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.ConnectionLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(438, 81);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// DataSourceNameTextBox
			// 
			this.DataSourceNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceNameTextBox.Location = new System.Drawing.Point(3, 16);
			this.DataSourceNameTextBox.Name = "DataSourceNameTextBox";
			this.DataSourceNameTextBox.Size = new System.Drawing.Size(432, 22);
			this.DataSourceNameTextBox.TabIndex = 0;
			this.DataSourceNameTextBox.TooltipText = "Field should not be empty";
			this.DataSourceNameTextBox.Valid = false;
			// 
			// ConnectionComboBox
			// 
			this.ConnectionComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConnectionComboBox.FormattingEnabled = true;
			this.ConnectionComboBox.Location = new System.Drawing.Point(3, 57);
			this.ConnectionComboBox.Name = "ConnectionComboBox";
			this.ConnectionComboBox.Size = new System.Drawing.Size(432, 21);
			this.ConnectionComboBox.TabIndex = 1;
			this.ConnectionComboBox.SelectedIndexChanged += new System.EventHandler(this.ConnectionComboBox_SelectedIndexChanged);
			// 
			// ConnectionLabel
			// 
			this.ConnectionLabel.AutoSize = true;
			this.ConnectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConnectionLabel.Location = new System.Drawing.Point(3, 41);
			this.ConnectionLabel.Name = "ConnectionLabel";
			this.ConnectionLabel.Size = new System.Drawing.Size(432, 13);
			this.ConnectionLabel.TabIndex = 5;
			this.ConnectionLabel.Text = "Connection";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data Source Name";
			// 
			// OkButton
			// 
			this.OkButton.AutoSize = true;
			this.OkButton.Location = new System.Drawing.Point(291, 445);
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
			this.CancelButton.Location = new System.Drawing.Point(372, 445);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// DataSourceEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(450, 471);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(466, 510);
			this.Name = "DataSourceEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Data Source";
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.QueryGroupBox.ResumeLayout(false);
			this.QueryGroupBox.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.TableViewDetailGroup.ResumeLayout(false);
			this.TableViewDetailGroup.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label ParentParametersLabel;
		private System.Windows.Forms.Button NewParameterButton;
		private System.Windows.Forms.Button EditParameterButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button DeleteParameterButton;
		private System.Windows.Forms.Button NewParentParameterButton;
		private System.Windows.Forms.Button EditParentParameterButton;
		private System.Windows.Forms.Button DeleteParentParameterButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.GroupBox TableViewDetailGroup;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.ListView ParameterListView;
		private System.Windows.Forms.ListView ParentParameterListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox QueryGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label QueryLabel;
		private System.Windows.Forms.Label ParametersLabel;
		private System.Windows.Forms.RichTextBox QueryRichTextBox;
		private System.Windows.Forms.ComboBox ConnectionComboBox;
		private System.Windows.Forms.Label ConnectionLabel;
		private System.Windows.Forms.Button ParentParameterUpButton;
		private System.Windows.Forms.Button ParameterUpButton;
		private System.Windows.Forms.Button ParameterDownButton;
		private System.Windows.Forms.Button ParentParameterDownButton;
		private ValidateTextBox DataSourceNameTextBox;
		private System.Windows.Forms.ColumnHeader PTypeColumn;
		private System.Windows.Forms.ColumnHeader PNameColumn;
		private System.Windows.Forms.ColumnHeader PAutoSourceColumn;
		private System.Windows.Forms.ColumnHeader PPTypeColumn;
		private System.Windows.Forms.ColumnHeader PPNameColumn;
		private System.Windows.Forms.ColumnHeader PPAutoSourceColumn;
	}
}