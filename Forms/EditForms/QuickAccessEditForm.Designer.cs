namespace QuickDBAccess.Forms {
	partial class QuickAccessEditForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickAccessEditForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ConnectionsTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ConnectionsDownButton = new System.Windows.Forms.Button();
			this.ConnectionsUpButton = new System.Windows.Forms.Button();
			this.DeleteConnectionButton = new System.Windows.Forms.Button();
			this.EditConnectionButton = new System.Windows.Forms.Button();
			this.AddConnectionButton = new System.Windows.Forms.Button();
			this.ConnectionsListView = new System.Windows.Forms.ListView();
			this.ConnectionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionDatabase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionIntegratedSecurity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ImportConnectionButton = new System.Windows.Forms.Button();
			this.ExportConnectionButton = new System.Windows.Forms.Button();
			this.DataSourcesTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.DataSourcesDownButton = new System.Windows.Forms.Button();
			this.DataSourcesUpButton = new System.Windows.Forms.Button();
			this.DeleteDataSourceButton = new System.Windows.Forms.Button();
			this.EditDataSourceButton = new System.Windows.Forms.Button();
			this.NewDataSourceButton = new System.Windows.Forms.Button();
			this.DataSourcesListView = new System.Windows.Forms.ListView();
			this.DataSourcesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourcesConnection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourcesSQLCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ImportDataSourceButton = new System.Windows.Forms.Button();
			this.ExportDataSourceButton = new System.Windows.Forms.Button();
			this.TableViewTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewsDownButton = new System.Windows.Forms.Button();
			this.TableViewsUpButton = new System.Windows.Forms.Button();
			this.DeleteTableViewButton = new System.Windows.Forms.Button();
			this.EditTableViewButton = new System.Windows.Forms.Button();
			this.NewTableViewButton = new System.Windows.Forms.Button();
			this.TableViewsListView = new System.Windows.Forms.ListView();
			this.TableViewsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TableViewsDataSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TableViewsChildrenCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ImportTableViewButton = new System.Windows.Forms.Button();
			this.ExportTableViewButton = new System.Windows.Forms.Button();
			this.ProjectPropertiesTabPage = new System.Windows.Forms.TabPage();
			this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.ProjectNameTextBox = new QuickDBAccess.ValidateTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ConnectionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DuplicateConnectionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DataSourcesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DuplicateDataSourcesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TableViewsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DuplicateTableViewsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.ConnectionsTabPage.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.DataSourcesTabPage.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.TableViewTabPage.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.ProjectPropertiesTabPage.SuspendLayout();
			this.SettingsGroupBox.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.ConnectionsContextMenu.SuspendLayout();
			this.DataSourcesContextMenu.SuspendLayout();
			this.TableViewsContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.OkButton, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.CancelButton, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 767);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
			this.tabControl1.Controls.Add(this.ConnectionsTabPage);
			this.tabControl1.Controls.Add(this.DataSourcesTabPage);
			this.tabControl1.Controls.Add(this.TableViewTabPage);
			this.tabControl1.Controls.Add(this.ProjectPropertiesTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(6, 6);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(984, 699);
			this.tabControl1.TabIndex = 0;
			// 
			// ConnectionsTabPage
			// 
			this.ConnectionsTabPage.Controls.Add(this.tableLayoutPanel2);
			this.ConnectionsTabPage.Location = new System.Drawing.Point(8, 39);
			this.ConnectionsTabPage.Margin = new System.Windows.Forms.Padding(6);
			this.ConnectionsTabPage.Name = "ConnectionsTabPage";
			this.ConnectionsTabPage.Padding = new System.Windows.Forms.Padding(6);
			this.ConnectionsTabPage.Size = new System.Drawing.Size(968, 652);
			this.ConnectionsTabPage.TabIndex = 0;
			this.ConnectionsTabPage.Text = "Connections";
			this.ConnectionsTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.ConnectionsDownButton, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.ConnectionsUpButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.DeleteConnectionButton, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.EditConnectionButton, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.AddConnectionButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.ConnectionsListView, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ImportConnectionButton, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.ExportConnectionButton, 2, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(956, 640);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// ConnectionsDownButton
			// 
			this.ConnectionsDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.ConnectionsDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ConnectionsDownButton.Enabled = false;
			this.ConnectionsDownButton.Location = new System.Drawing.Point(6, 62);
			this.ConnectionsDownButton.Margin = new System.Windows.Forms.Padding(6);
			this.ConnectionsDownButton.Name = "ConnectionsDownButton";
			this.ConnectionsDownButton.Size = new System.Drawing.Size(46, 44);
			this.ConnectionsDownButton.TabIndex = 2;
			this.ConnectionsDownButton.UseVisualStyleBackColor = true;
			this.ConnectionsDownButton.EnabledChanged += new System.EventHandler(this.ConnectionsDownButton_EnabledChanged);
			this.ConnectionsDownButton.Click += new System.EventHandler(this.ConnectionsDownButton_Click);
			// 
			// ConnectionsUpButton
			// 
			this.ConnectionsUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.ConnectionsUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ConnectionsUpButton.Enabled = false;
			this.ConnectionsUpButton.Location = new System.Drawing.Point(6, 6);
			this.ConnectionsUpButton.Margin = new System.Windows.Forms.Padding(6);
			this.ConnectionsUpButton.Name = "ConnectionsUpButton";
			this.ConnectionsUpButton.Size = new System.Drawing.Size(46, 44);
			this.ConnectionsUpButton.TabIndex = 1;
			this.ConnectionsUpButton.UseVisualStyleBackColor = true;
			this.ConnectionsUpButton.EnabledChanged += new System.EventHandler(this.ConnectionsUpButton_EnabledChanged);
			this.ConnectionsUpButton.Click += new System.EventHandler(this.ConnectionsUpButton_Click);
			// 
			// DeleteConnectionButton
			// 
			this.DeleteConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteConnectionButton.Enabled = false;
			this.DeleteConnectionButton.Location = new System.Drawing.Point(904, 6);
			this.DeleteConnectionButton.Margin = new System.Windows.Forms.Padding(6);
			this.DeleteConnectionButton.Name = "DeleteConnectionButton";
			this.DeleteConnectionButton.Size = new System.Drawing.Size(46, 44);
			this.DeleteConnectionButton.TabIndex = 6;
			this.DeleteConnectionButton.UseVisualStyleBackColor = true;
			this.DeleteConnectionButton.EnabledChanged += new System.EventHandler(this.DeleteConnectionButton_EnabledChanged);
			this.DeleteConnectionButton.Click += new System.EventHandler(this.DeleteConnectionButton_Click);
			// 
			// EditConnectionButton
			// 
			this.EditConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditConnectionButton.Enabled = false;
			this.EditConnectionButton.Location = new System.Drawing.Point(846, 6);
			this.EditConnectionButton.Margin = new System.Windows.Forms.Padding(6);
			this.EditConnectionButton.Name = "EditConnectionButton";
			this.EditConnectionButton.Size = new System.Drawing.Size(46, 44);
			this.EditConnectionButton.TabIndex = 5;
			this.EditConnectionButton.UseVisualStyleBackColor = true;
			this.EditConnectionButton.EnabledChanged += new System.EventHandler(this.EditConnectionButton_EnabledChanged);
			this.EditConnectionButton.Click += new System.EventHandler(this.EditConnectionButton_Click);
			// 
			// AddConnectionButton
			// 
			this.AddConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddConnectionButton.Location = new System.Drawing.Point(788, 6);
			this.AddConnectionButton.Margin = new System.Windows.Forms.Padding(6);
			this.AddConnectionButton.Name = "AddConnectionButton";
			this.AddConnectionButton.Size = new System.Drawing.Size(46, 44);
			this.AddConnectionButton.TabIndex = 4;
			this.AddConnectionButton.UseVisualStyleBackColor = true;
			this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButton_Click);
			// 
			// ConnectionsListView
			// 
			this.ConnectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConnectionName,
            this.ConnectionServer,
            this.ConnectionDatabase,
            this.ConnectionUser,
            this.ConnectionIntegratedSecurity});
			this.ConnectionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConnectionsListView.HideSelection = false;
			this.ConnectionsListView.Location = new System.Drawing.Point(64, 6);
			this.ConnectionsListView.Margin = new System.Windows.Forms.Padding(6);
			this.ConnectionsListView.Name = "ConnectionsListView";
			this.tableLayoutPanel2.SetRowSpan(this.ConnectionsListView, 4);
			this.ConnectionsListView.Size = new System.Drawing.Size(712, 628);
			this.ConnectionsListView.TabIndex = 3;
			this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
			this.ConnectionsListView.View = System.Windows.Forms.View.Details;
			this.ConnectionsListView.SelectedIndexChanged += new System.EventHandler(this.ConnectionsListView_SelectedIndexChanged);
			this.ConnectionsListView.DoubleClick += new System.EventHandler(this.ConnectionsListView_DoubleClick);
			this.ConnectionsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionsListView_KeyDown);
			this.ConnectionsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectionsListView_MouseClick);
			// 
			// ConnectionName
			// 
			this.ConnectionName.Text = "Name";
			this.ConnectionName.Width = 90;
			// 
			// ConnectionServer
			// 
			this.ConnectionServer.Text = "Server";
			// 
			// ConnectionDatabase
			// 
			this.ConnectionDatabase.Text = "Database";
			// 
			// ConnectionUser
			// 
			this.ConnectionUser.Text = "User";
			// 
			// ConnectionIntegratedSecurity
			// 
			this.ConnectionIntegratedSecurity.Text = "Integrated Security";
			// 
			// ImportConnectionButton
			// 
			this.ImportConnectionButton.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ImportConnectionButton, 3);
			this.ImportConnectionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ImportConnectionButton.Location = new System.Drawing.Point(785, 561);
			this.ImportConnectionButton.Name = "ImportConnectionButton";
			this.ImportConnectionButton.Size = new System.Drawing.Size(168, 35);
			this.ImportConnectionButton.TabIndex = 7;
			this.ImportConnectionButton.Text = "Import";
			this.ImportConnectionButton.UseVisualStyleBackColor = true;
			this.ImportConnectionButton.Click += new System.EventHandler(this.ImportConnectionButton_Click);
			// 
			// ExportConnectionButton
			// 
			this.ExportConnectionButton.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ExportConnectionButton, 3);
			this.ExportConnectionButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ExportConnectionButton.Location = new System.Drawing.Point(785, 602);
			this.ExportConnectionButton.Name = "ExportConnectionButton";
			this.ExportConnectionButton.Size = new System.Drawing.Size(168, 35);
			this.ExportConnectionButton.TabIndex = 0;
			this.ExportConnectionButton.Text = "Export";
			this.ExportConnectionButton.UseVisualStyleBackColor = true;
			this.ExportConnectionButton.Click += new System.EventHandler(this.ExportConnectionButton_Click);
			// 
			// DataSourcesTabPage
			// 
			this.DataSourcesTabPage.Controls.Add(this.tableLayoutPanel3);
			this.DataSourcesTabPage.Location = new System.Drawing.Point(8, 39);
			this.DataSourcesTabPage.Margin = new System.Windows.Forms.Padding(6);
			this.DataSourcesTabPage.Name = "DataSourcesTabPage";
			this.DataSourcesTabPage.Padding = new System.Windows.Forms.Padding(6);
			this.DataSourcesTabPage.Size = new System.Drawing.Size(968, 652);
			this.DataSourcesTabPage.TabIndex = 1;
			this.DataSourcesTabPage.Text = "Data Sources";
			this.DataSourcesTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 5;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.DataSourcesDownButton, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.DataSourcesUpButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.DeleteDataSourceButton, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.EditDataSourceButton, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.NewDataSourceButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.DataSourcesListView, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.ImportDataSourceButton, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.ExportDataSourceButton, 2, 3);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(956, 640);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// DataSourcesDownButton
			// 
			this.DataSourcesDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.DataSourcesDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DataSourcesDownButton.Enabled = false;
			this.DataSourcesDownButton.Location = new System.Drawing.Point(6, 62);
			this.DataSourcesDownButton.Margin = new System.Windows.Forms.Padding(6);
			this.DataSourcesDownButton.Name = "DataSourcesDownButton";
			this.DataSourcesDownButton.Size = new System.Drawing.Size(46, 44);
			this.DataSourcesDownButton.TabIndex = 2;
			this.DataSourcesDownButton.UseVisualStyleBackColor = true;
			this.DataSourcesDownButton.EnabledChanged += new System.EventHandler(this.DataSourcesDownButton_EnabledChanged);
			this.DataSourcesDownButton.Click += new System.EventHandler(this.DataSourcesDownButton_Click);
			// 
			// DataSourcesUpButton
			// 
			this.DataSourcesUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.DataSourcesUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DataSourcesUpButton.Enabled = false;
			this.DataSourcesUpButton.Location = new System.Drawing.Point(6, 6);
			this.DataSourcesUpButton.Margin = new System.Windows.Forms.Padding(6);
			this.DataSourcesUpButton.Name = "DataSourcesUpButton";
			this.DataSourcesUpButton.Size = new System.Drawing.Size(46, 44);
			this.DataSourcesUpButton.TabIndex = 1;
			this.DataSourcesUpButton.UseVisualStyleBackColor = true;
			this.DataSourcesUpButton.EnabledChanged += new System.EventHandler(this.DataSourcesUpButton_EnabledChanged);
			this.DataSourcesUpButton.Click += new System.EventHandler(this.DataSourcesUpButton_Click);
			// 
			// DeleteDataSourceButton
			// 
			this.DeleteDataSourceButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteDataSourceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteDataSourceButton.Enabled = false;
			this.DeleteDataSourceButton.Location = new System.Drawing.Point(904, 6);
			this.DeleteDataSourceButton.Margin = new System.Windows.Forms.Padding(6);
			this.DeleteDataSourceButton.Name = "DeleteDataSourceButton";
			this.DeleteDataSourceButton.Size = new System.Drawing.Size(46, 44);
			this.DeleteDataSourceButton.TabIndex = 6;
			this.DeleteDataSourceButton.UseVisualStyleBackColor = true;
			this.DeleteDataSourceButton.EnabledChanged += new System.EventHandler(this.DeleteDataSourceButton_EnabledChanged);
			this.DeleteDataSourceButton.Click += new System.EventHandler(this.DeleteDataSourceButton_Click);
			// 
			// EditDataSourceButton
			// 
			this.EditDataSourceButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditDataSourceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditDataSourceButton.Enabled = false;
			this.EditDataSourceButton.Location = new System.Drawing.Point(846, 6);
			this.EditDataSourceButton.Margin = new System.Windows.Forms.Padding(6);
			this.EditDataSourceButton.Name = "EditDataSourceButton";
			this.EditDataSourceButton.Size = new System.Drawing.Size(46, 44);
			this.EditDataSourceButton.TabIndex = 5;
			this.EditDataSourceButton.UseVisualStyleBackColor = true;
			this.EditDataSourceButton.EnabledChanged += new System.EventHandler(this.EditDataSourceButton_EnabledChanged);
			this.EditDataSourceButton.Click += new System.EventHandler(this.EditDataSourceButton_Click);
			// 
			// NewDataSourceButton
			// 
			this.NewDataSourceButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewDataSourceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewDataSourceButton.Location = new System.Drawing.Point(788, 6);
			this.NewDataSourceButton.Margin = new System.Windows.Forms.Padding(6);
			this.NewDataSourceButton.Name = "NewDataSourceButton";
			this.NewDataSourceButton.Size = new System.Drawing.Size(46, 44);
			this.NewDataSourceButton.TabIndex = 4;
			this.NewDataSourceButton.UseVisualStyleBackColor = true;
			this.NewDataSourceButton.Click += new System.EventHandler(this.NewDataSourceButton_Click);
			// 
			// DataSourcesListView
			// 
			this.DataSourcesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataSourcesName,
            this.DataSourcesConnection,
            this.DataSourcesSQLCommand});
			this.DataSourcesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataSourcesListView.HideSelection = false;
			this.DataSourcesListView.Location = new System.Drawing.Point(64, 6);
			this.DataSourcesListView.Margin = new System.Windows.Forms.Padding(6);
			this.DataSourcesListView.Name = "DataSourcesListView";
			this.tableLayoutPanel3.SetRowSpan(this.DataSourcesListView, 4);
			this.DataSourcesListView.Size = new System.Drawing.Size(712, 628);
			this.DataSourcesListView.TabIndex = 3;
			this.DataSourcesListView.UseCompatibleStateImageBehavior = false;
			this.DataSourcesListView.View = System.Windows.Forms.View.Details;
			this.DataSourcesListView.SelectedIndexChanged += new System.EventHandler(this.DataSourcesListView_SelectedIndexChanged);
			this.DataSourcesListView.DoubleClick += new System.EventHandler(this.DataSourcesListView_DoubleClick);
			this.DataSourcesListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataSourcesListView_KeyDown);
			this.DataSourcesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataSourcesListView_MouseClick);
			// 
			// DataSourcesName
			// 
			this.DataSourcesName.Text = "Name";
			this.DataSourcesName.Width = 106;
			// 
			// DataSourcesConnection
			// 
			this.DataSourcesConnection.Text = "Connection";
			this.DataSourcesConnection.Width = 72;
			// 
			// DataSourcesSQLCommand
			// 
			this.DataSourcesSQLCommand.Text = "SQL Command";
			this.DataSourcesSQLCommand.Width = 114;
			// 
			// ImportDataSourceButton
			// 
			this.ImportDataSourceButton.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.ImportDataSourceButton, 3);
			this.ImportDataSourceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ImportDataSourceButton.Location = new System.Drawing.Point(785, 561);
			this.ImportDataSourceButton.Name = "ImportDataSourceButton";
			this.ImportDataSourceButton.Size = new System.Drawing.Size(168, 35);
			this.ImportDataSourceButton.TabIndex = 7;
			this.ImportDataSourceButton.Text = "Import";
			this.ImportDataSourceButton.UseVisualStyleBackColor = true;
			this.ImportDataSourceButton.Click += new System.EventHandler(this.ImportDataSourceButton_Click);
			// 
			// ExportDataSourceButton
			// 
			this.ExportDataSourceButton.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.ExportDataSourceButton, 3);
			this.ExportDataSourceButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ExportDataSourceButton.Location = new System.Drawing.Point(785, 602);
			this.ExportDataSourceButton.Name = "ExportDataSourceButton";
			this.ExportDataSourceButton.Size = new System.Drawing.Size(168, 35);
			this.ExportDataSourceButton.TabIndex = 8;
			this.ExportDataSourceButton.Text = "Export";
			this.ExportDataSourceButton.UseVisualStyleBackColor = true;
			this.ExportDataSourceButton.Click += new System.EventHandler(this.ExportDataSourceButton_Click);
			// 
			// TableViewTabPage
			// 
			this.TableViewTabPage.Controls.Add(this.tableLayoutPanel4);
			this.TableViewTabPage.Location = new System.Drawing.Point(8, 39);
			this.TableViewTabPage.Margin = new System.Windows.Forms.Padding(6);
			this.TableViewTabPage.Name = "TableViewTabPage";
			this.TableViewTabPage.Padding = new System.Windows.Forms.Padding(6);
			this.TableViewTabPage.Size = new System.Drawing.Size(968, 652);
			this.TableViewTabPage.TabIndex = 2;
			this.TableViewTabPage.Text = "Table Views";
			this.TableViewTabPage.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 5;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.TableViewsDownButton, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.TableViewsUpButton, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.DeleteTableViewButton, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.EditTableViewButton, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.NewTableViewButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.TableViewsListView, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.ImportTableViewButton, 2, 2);
			this.tableLayoutPanel4.Controls.Add(this.ExportTableViewButton, 2, 3);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(956, 640);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// TableViewsDownButton
			// 
			this.TableViewsDownButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.down_disabled;
			this.TableViewsDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TableViewsDownButton.Enabled = false;
			this.TableViewsDownButton.Location = new System.Drawing.Point(6, 62);
			this.TableViewsDownButton.Margin = new System.Windows.Forms.Padding(6);
			this.TableViewsDownButton.Name = "TableViewsDownButton";
			this.TableViewsDownButton.Size = new System.Drawing.Size(46, 44);
			this.TableViewsDownButton.TabIndex = 2;
			this.TableViewsDownButton.UseVisualStyleBackColor = true;
			this.TableViewsDownButton.EnabledChanged += new System.EventHandler(this.TableViewsDownButton_EnabledChanged);
			this.TableViewsDownButton.Click += new System.EventHandler(this.TableViewsDownButton_Click);
			// 
			// TableViewsUpButton
			// 
			this.TableViewsUpButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.up_disabled;
			this.TableViewsUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TableViewsUpButton.Enabled = false;
			this.TableViewsUpButton.Location = new System.Drawing.Point(6, 6);
			this.TableViewsUpButton.Margin = new System.Windows.Forms.Padding(6);
			this.TableViewsUpButton.Name = "TableViewsUpButton";
			this.TableViewsUpButton.Size = new System.Drawing.Size(46, 44);
			this.TableViewsUpButton.TabIndex = 1;
			this.TableViewsUpButton.UseVisualStyleBackColor = true;
			this.TableViewsUpButton.EnabledChanged += new System.EventHandler(this.TableViewsUpButton_EnabledChanged);
			this.TableViewsUpButton.Click += new System.EventHandler(this.TableViewsUpButton_Click);
			// 
			// DeleteTableViewButton
			// 
			this.DeleteTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete_disabled;
			this.DeleteTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteTableViewButton.Enabled = false;
			this.DeleteTableViewButton.Location = new System.Drawing.Point(904, 6);
			this.DeleteTableViewButton.Margin = new System.Windows.Forms.Padding(6);
			this.DeleteTableViewButton.Name = "DeleteTableViewButton";
			this.DeleteTableViewButton.Size = new System.Drawing.Size(46, 44);
			this.DeleteTableViewButton.TabIndex = 6;
			this.DeleteTableViewButton.UseVisualStyleBackColor = true;
			this.DeleteTableViewButton.EnabledChanged += new System.EventHandler(this.DeleteTableViewButton_EnabledChanged);
			this.DeleteTableViewButton.Click += new System.EventHandler(this.DeleteTableViewButton_Click);
			// 
			// EditTableViewButton
			// 
			this.EditTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit_disabled;
			this.EditTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditTableViewButton.Enabled = false;
			this.EditTableViewButton.Location = new System.Drawing.Point(846, 6);
			this.EditTableViewButton.Margin = new System.Windows.Forms.Padding(6);
			this.EditTableViewButton.Name = "EditTableViewButton";
			this.EditTableViewButton.Size = new System.Drawing.Size(46, 44);
			this.EditTableViewButton.TabIndex = 5;
			this.EditTableViewButton.UseVisualStyleBackColor = true;
			this.EditTableViewButton.EnabledChanged += new System.EventHandler(this.EditTableViewButton_EnabledChanged);
			this.EditTableViewButton.Click += new System.EventHandler(this.EditTableViewButton_Click);
			// 
			// NewTableViewButton
			// 
			this.NewTableViewButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.NewTableViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewTableViewButton.Location = new System.Drawing.Point(788, 6);
			this.NewTableViewButton.Margin = new System.Windows.Forms.Padding(6);
			this.NewTableViewButton.Name = "NewTableViewButton";
			this.NewTableViewButton.Size = new System.Drawing.Size(46, 44);
			this.NewTableViewButton.TabIndex = 4;
			this.NewTableViewButton.UseVisualStyleBackColor = true;
			this.NewTableViewButton.Click += new System.EventHandler(this.NewTableViewButton_Click);
			// 
			// TableViewsListView
			// 
			this.TableViewsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableViewsName,
            this.TableViewsDataSource,
            this.TableViewsChildrenCount});
			this.TableViewsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableViewsListView.HideSelection = false;
			this.TableViewsListView.Location = new System.Drawing.Point(64, 6);
			this.TableViewsListView.Margin = new System.Windows.Forms.Padding(6);
			this.TableViewsListView.Name = "TableViewsListView";
			this.tableLayoutPanel4.SetRowSpan(this.TableViewsListView, 4);
			this.TableViewsListView.Size = new System.Drawing.Size(712, 628);
			this.TableViewsListView.TabIndex = 3;
			this.TableViewsListView.UseCompatibleStateImageBehavior = false;
			this.TableViewsListView.View = System.Windows.Forms.View.Details;
			this.TableViewsListView.SelectedIndexChanged += new System.EventHandler(this.TableViewsListView_SelectedIndexChanged);
			this.TableViewsListView.DoubleClick += new System.EventHandler(this.TableViewsListView_DoubleClick);
			this.TableViewsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TableViewsListView_KeyDown);
			this.TableViewsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableViewsListView_MouseClick);
			// 
			// TableViewsName
			// 
			this.TableViewsName.Text = "Name";
			this.TableViewsName.Width = 101;
			// 
			// TableViewsDataSource
			// 
			this.TableViewsDataSource.Text = "Data Source";
			this.TableViewsDataSource.Width = 138;
			// 
			// TableViewsChildrenCount
			// 
			this.TableViewsChildrenCount.Text = "Sub-tables";
			this.TableViewsChildrenCount.Width = 92;
			// 
			// ImportTableViewButton
			// 
			this.ImportTableViewButton.AutoSize = true;
			this.tableLayoutPanel4.SetColumnSpan(this.ImportTableViewButton, 3);
			this.ImportTableViewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ImportTableViewButton.Location = new System.Drawing.Point(785, 561);
			this.ImportTableViewButton.Name = "ImportTableViewButton";
			this.ImportTableViewButton.Size = new System.Drawing.Size(168, 35);
			this.ImportTableViewButton.TabIndex = 7;
			this.ImportTableViewButton.Text = "Import";
			this.ImportTableViewButton.UseVisualStyleBackColor = true;
			this.ImportTableViewButton.Click += new System.EventHandler(this.ImportTableViewButton_Click);
			// 
			// ExportTableViewButton
			// 
			this.ExportTableViewButton.AutoSize = true;
			this.tableLayoutPanel4.SetColumnSpan(this.ExportTableViewButton, 3);
			this.ExportTableViewButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ExportTableViewButton.Location = new System.Drawing.Point(785, 602);
			this.ExportTableViewButton.Name = "ExportTableViewButton";
			this.ExportTableViewButton.Size = new System.Drawing.Size(168, 35);
			this.ExportTableViewButton.TabIndex = 8;
			this.ExportTableViewButton.Text = "Export";
			this.ExportTableViewButton.UseVisualStyleBackColor = true;
			this.ExportTableViewButton.Click += new System.EventHandler(this.ExportTableViewButton_Click);
			// 
			// ProjectPropertiesTabPage
			// 
			this.ProjectPropertiesTabPage.Controls.Add(this.SettingsGroupBox);
			this.ProjectPropertiesTabPage.Location = new System.Drawing.Point(8, 39);
			this.ProjectPropertiesTabPage.Margin = new System.Windows.Forms.Padding(6);
			this.ProjectPropertiesTabPage.Name = "ProjectPropertiesTabPage";
			this.ProjectPropertiesTabPage.Padding = new System.Windows.Forms.Padding(6);
			this.ProjectPropertiesTabPage.Size = new System.Drawing.Size(968, 652);
			this.ProjectPropertiesTabPage.TabIndex = 3;
			this.ProjectPropertiesTabPage.Text = "Properties";
			this.ProjectPropertiesTabPage.UseVisualStyleBackColor = true;
			// 
			// SettingsGroupBox
			// 
			this.SettingsGroupBox.AutoSize = true;
			this.SettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SettingsGroupBox.Controls.Add(this.tableLayoutPanel5);
			this.SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.SettingsGroupBox.Location = new System.Drawing.Point(6, 6);
			this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(6);
			this.SettingsGroupBox.Name = "SettingsGroupBox";
			this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(6);
			this.SettingsGroupBox.Size = new System.Drawing.Size(956, 102);
			this.SettingsGroupBox.TabIndex = 0;
			this.SettingsGroupBox.TabStop = false;
			this.SettingsGroupBox.Text = "Project Properties";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.AutoSize = true;
			this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.Controls.Add(this.ProjectNameTextBox, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 30);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(944, 66);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// ProjectNameTextBox
			// 
			this.ProjectNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ProjectNameTextBox.Location = new System.Drawing.Point(165, 12);
			this.ProjectNameTextBox.Margin = new System.Windows.Forms.Padding(12);
			this.ProjectNameTextBox.Name = "ProjectNameTextBox";
			this.ProjectNameTextBox.Size = new System.Drawing.Size(778, 42);
			this.ProjectNameTextBox.TabIndex = 1;
			this.ProjectNameTextBox.TooltipText = null;
			this.ProjectNameTextBox.Valid = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(6, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 66);
			this.label1.TabIndex = 0;
			this.label1.Text = "Project Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(678, 717);
			this.OkButton.Margin = new System.Windows.Forms.Padding(6);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(150, 44);
			this.OkButton.TabIndex = 8;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(840, 717);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(150, 44);
			this.CancelButton.TabIndex = 9;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// ConnectionsContextMenu
			// 
			this.ConnectionsContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.ConnectionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuplicateConnectionsMenuItem});
			this.ConnectionsContextMenu.Name = "ConnectionsContextMenu";
			this.ConnectionsContextMenu.Size = new System.Drawing.Size(190, 42);
			// 
			// DuplicateConnectionsMenuItem
			// 
			this.DuplicateConnectionsMenuItem.Name = "DuplicateConnectionsMenuItem";
			this.DuplicateConnectionsMenuItem.Size = new System.Drawing.Size(189, 38);
			this.DuplicateConnectionsMenuItem.Text = "Duplicate";
			this.DuplicateConnectionsMenuItem.Click += new System.EventHandler(this.DuplicateConnectionToolStripMenuItem_Click);
			// 
			// DataSourcesContextMenu
			// 
			this.DataSourcesContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.DataSourcesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuplicateDataSourcesMenuItem});
			this.DataSourcesContextMenu.Name = "ConnectionsContextMenu";
			this.DataSourcesContextMenu.Size = new System.Drawing.Size(190, 42);
			// 
			// DuplicateDataSourcesMenuItem
			// 
			this.DuplicateDataSourcesMenuItem.Name = "DuplicateDataSourcesMenuItem";
			this.DuplicateDataSourcesMenuItem.Size = new System.Drawing.Size(189, 38);
			this.DuplicateDataSourcesMenuItem.Text = "Duplicate";
			this.DuplicateDataSourcesMenuItem.Click += new System.EventHandler(this.DuplicateDataSourcesMenuItem_Click);
			// 
			// TableViewsContextMenu
			// 
			this.TableViewsContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.TableViewsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuplicateTableViewsMenuItem});
			this.TableViewsContextMenu.Name = "ConnectionsContextMenu";
			this.TableViewsContextMenu.Size = new System.Drawing.Size(190, 42);
			// 
			// DuplicateTableViewsMenuItem
			// 
			this.DuplicateTableViewsMenuItem.Name = "DuplicateTableViewsMenuItem";
			this.DuplicateTableViewsMenuItem.Size = new System.Drawing.Size(189, 38);
			this.DuplicateTableViewsMenuItem.Text = "Duplicate";
			this.DuplicateTableViewsMenuItem.Click += new System.EventHandler(this.DuplicateTableViewsMenuItem_Click);
			// 
			// QuickAccessEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 767);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(1002, 777);
			this.Name = "QuickAccessEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit QDBA Program";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ConnectionsTabPage.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.DataSourcesTabPage.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.TableViewTabPage.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ProjectPropertiesTabPage.ResumeLayout(false);
			this.ProjectPropertiesTabPage.PerformLayout();
			this.SettingsGroupBox.ResumeLayout(false);
			this.SettingsGroupBox.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ConnectionsContextMenu.ResumeLayout(false);
			this.DataSourcesContextMenu.ResumeLayout(false);
			this.TableViewsContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage ConnectionsTabPage;
		private System.Windows.Forms.TabPage DataSourcesTabPage;
		private System.Windows.Forms.TabPage TableViewTabPage;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button ConnectionsUpButton;
		private System.Windows.Forms.Button ConnectionsDownButton;
		private System.Windows.Forms.Button AddConnectionButton;
		private System.Windows.Forms.Button EditConnectionButton;
		private System.Windows.Forms.Button DeleteConnectionButton;
		private System.Windows.Forms.ListView ConnectionsListView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button DataSourcesDownButton;
		private System.Windows.Forms.Button DataSourcesUpButton;
		private System.Windows.Forms.Button DeleteDataSourceButton;
		private System.Windows.Forms.Button EditDataSourceButton;
		private System.Windows.Forms.Button NewDataSourceButton;
		private System.Windows.Forms.ListView DataSourcesListView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button TableViewsDownButton;
		private System.Windows.Forms.Button TableViewsUpButton;
		private System.Windows.Forms.Button DeleteTableViewButton;
		private System.Windows.Forms.Button EditTableViewButton;
		private System.Windows.Forms.Button NewTableViewButton;
		private System.Windows.Forms.ListView TableViewsListView;
		private System.Windows.Forms.ColumnHeader ConnectionName;
		private System.Windows.Forms.ColumnHeader ConnectionServer;
		private System.Windows.Forms.ColumnHeader ConnectionDatabase;
		private System.Windows.Forms.ColumnHeader ConnectionUser;
		private System.Windows.Forms.ColumnHeader DataSourcesName;
		private System.Windows.Forms.ColumnHeader DataSourcesConnection;
		private System.Windows.Forms.ColumnHeader DataSourcesSQLCommand;
		private System.Windows.Forms.ColumnHeader TableViewsName;
		private System.Windows.Forms.ColumnHeader TableViewsDataSource;
		private System.Windows.Forms.ColumnHeader TableViewsChildrenCount;
		private System.Windows.Forms.TabPage ProjectPropertiesTabPage;
		private System.Windows.Forms.GroupBox SettingsGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private ValidateTextBox ProjectNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.ColumnHeader ConnectionIntegratedSecurity;
		private System.Windows.Forms.ContextMenuStrip ConnectionsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem DuplicateConnectionsMenuItem;
		private System.Windows.Forms.ContextMenuStrip DataSourcesContextMenu;
		private System.Windows.Forms.ToolStripMenuItem DuplicateDataSourcesMenuItem;
		private System.Windows.Forms.ContextMenuStrip TableViewsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem DuplicateTableViewsMenuItem;
		private System.Windows.Forms.Button ImportConnectionButton;
		private System.Windows.Forms.Button ExportConnectionButton;
		private System.Windows.Forms.Button ImportDataSourceButton;
		private System.Windows.Forms.Button ExportDataSourceButton;
		private System.Windows.Forms.Button ImportTableViewButton;
		private System.Windows.Forms.Button ExportTableViewButton;
	}
}