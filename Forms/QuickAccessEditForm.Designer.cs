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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ConnectionsTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.DeleteConnectionButton = new System.Windows.Forms.Button();
			this.EditConnectionButton = new System.Windows.Forms.Button();
			this.AddConnectionButton = new System.Windows.Forms.Button();
			this.ConnectionsListView = new System.Windows.Forms.ListView();
			this.ConnectionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionDatabase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ConnectionUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourcesTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.DataSourcesListView = new System.Windows.Forms.ListView();
			this.DataSourcesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourcesConnection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DataSourcesSQLCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TableViewTabPage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.TableViewsListView = new System.Windows.Forms.ListView();
			this.TableViewsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TableViewsDataSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TableViewsChildrenCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CloseButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.ConnectionsTabPage.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.DataSourcesTabPage.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.TableViewTabPage.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CloseButton, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 399);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
			this.tabControl1.Controls.Add(this.ConnectionsTabPage);
			this.tabControl1.Controls.Add(this.DataSourcesTabPage);
			this.tabControl1.Controls.Add(this.TableViewTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(492, 364);
			this.tabControl1.TabIndex = 0;
			// 
			// ConnectionsTabPage
			// 
			this.ConnectionsTabPage.Controls.Add(this.tableLayoutPanel2);
			this.ConnectionsTabPage.Location = new System.Drawing.Point(4, 22);
			this.ConnectionsTabPage.Name = "ConnectionsTabPage";
			this.ConnectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ConnectionsTabPage.Size = new System.Drawing.Size(484, 338);
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
			this.tableLayoutPanel2.Controls.Add(this.button3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.DeleteConnectionButton, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.EditConnectionButton, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.AddConnectionButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.ConnectionsListView, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 332);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Location = new System.Drawing.Point(3, 32);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(23, 23);
			this.button3.TabIndex = 6;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// DeleteConnectionButton
			// 
			this.DeleteConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.DeleteConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteConnectionButton.Enabled = false;
			this.DeleteConnectionButton.Location = new System.Drawing.Point(452, 3);
			this.DeleteConnectionButton.Name = "DeleteConnectionButton";
			this.DeleteConnectionButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteConnectionButton.TabIndex = 9;
			this.DeleteConnectionButton.UseVisualStyleBackColor = true;
			// 
			// EditConnectionButton
			// 
			this.EditConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.EditConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditConnectionButton.Enabled = false;
			this.EditConnectionButton.Location = new System.Drawing.Point(423, 3);
			this.EditConnectionButton.Name = "EditConnectionButton";
			this.EditConnectionButton.Size = new System.Drawing.Size(23, 23);
			this.EditConnectionButton.TabIndex = 8;
			this.EditConnectionButton.UseVisualStyleBackColor = true;
			// 
			// AddConnectionButton
			// 
			this.AddConnectionButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddConnectionButton.Location = new System.Drawing.Point(394, 3);
			this.AddConnectionButton.Name = "AddConnectionButton";
			this.AddConnectionButton.Size = new System.Drawing.Size(23, 23);
			this.AddConnectionButton.TabIndex = 7;
			this.AddConnectionButton.UseVisualStyleBackColor = true;
			// 
			// ConnectionsListView
			// 
			this.ConnectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConnectionName,
            this.ConnectionServer,
            this.ConnectionDatabase,
            this.ConnectionUser});
			this.ConnectionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConnectionsListView.HideSelection = false;
			this.ConnectionsListView.Location = new System.Drawing.Point(32, 3);
			this.ConnectionsListView.Name = "ConnectionsListView";
			this.tableLayoutPanel2.SetRowSpan(this.ConnectionsListView, 2);
			this.ConnectionsListView.Size = new System.Drawing.Size(356, 326);
			this.ConnectionsListView.TabIndex = 10;
			this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
			this.ConnectionsListView.View = System.Windows.Forms.View.Details;
			this.ConnectionsListView.SelectedIndexChanged += new System.EventHandler(this.ConnectionsListView_SelectedIndexChanged);
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
			// DataSourcesTabPage
			// 
			this.DataSourcesTabPage.Controls.Add(this.tableLayoutPanel3);
			this.DataSourcesTabPage.Location = new System.Drawing.Point(4, 22);
			this.DataSourcesTabPage.Name = "DataSourcesTabPage";
			this.DataSourcesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.DataSourcesTabPage.Size = new System.Drawing.Size(484, 338);
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
			this.tableLayoutPanel3.Controls.Add(this.button4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.button5, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.button6, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.button7, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.button8, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.DataSourcesListView, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 332);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Location = new System.Drawing.Point(3, 32);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(23, 23);
			this.button4.TabIndex = 6;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Location = new System.Drawing.Point(3, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(23, 23);
			this.button5.TabIndex = 5;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Location = new System.Drawing.Point(452, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(23, 23);
			this.button6.TabIndex = 9;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Location = new System.Drawing.Point(423, 3);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(23, 23);
			this.button7.TabIndex = 8;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.Location = new System.Drawing.Point(394, 3);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(23, 23);
			this.button8.TabIndex = 7;
			this.button8.UseVisualStyleBackColor = true;
			// 
			// DataSourcesListView
			// 
			this.DataSourcesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataSourcesName,
            this.DataSourcesConnection,
            this.DataSourcesSQLCommand});
			this.DataSourcesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataSourcesListView.HideSelection = false;
			this.DataSourcesListView.Location = new System.Drawing.Point(32, 3);
			this.DataSourcesListView.Name = "DataSourcesListView";
			this.tableLayoutPanel3.SetRowSpan(this.DataSourcesListView, 2);
			this.DataSourcesListView.Size = new System.Drawing.Size(356, 326);
			this.DataSourcesListView.TabIndex = 10;
			this.DataSourcesListView.UseCompatibleStateImageBehavior = false;
			this.DataSourcesListView.View = System.Windows.Forms.View.Details;
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
			// TableViewTabPage
			// 
			this.TableViewTabPage.Controls.Add(this.tableLayoutPanel4);
			this.TableViewTabPage.Location = new System.Drawing.Point(4, 22);
			this.TableViewTabPage.Name = "TableViewTabPage";
			this.TableViewTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TableViewTabPage.Size = new System.Drawing.Size(484, 338);
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
			this.tableLayoutPanel4.Controls.Add(this.button9, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.button10, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.button11, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.button12, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.button13, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.TableViewsListView, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(478, 332);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// button9
			// 
			this.button9.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button9.Location = new System.Drawing.Point(3, 32);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(23, 23);
			this.button9.TabIndex = 6;
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button10.Location = new System.Drawing.Point(3, 3);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(23, 23);
			this.button10.TabIndex = 5;
			this.button10.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button11.Location = new System.Drawing.Point(452, 3);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(23, 23);
			this.button11.TabIndex = 9;
			this.button11.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button12.Location = new System.Drawing.Point(423, 3);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(23, 23);
			this.button12.TabIndex = 8;
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button13.Location = new System.Drawing.Point(394, 3);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(23, 23);
			this.button13.TabIndex = 7;
			this.button13.UseVisualStyleBackColor = true;
			// 
			// TableViewsListView
			// 
			this.TableViewsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableViewsName,
            this.TableViewsDataSource,
            this.TableViewsChildrenCount});
			this.TableViewsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableViewsListView.HideSelection = false;
			this.TableViewsListView.Location = new System.Drawing.Point(32, 3);
			this.TableViewsListView.Name = "TableViewsListView";
			this.tableLayoutPanel4.SetRowSpan(this.TableViewsListView, 2);
			this.TableViewsListView.Size = new System.Drawing.Size(356, 326);
			this.TableViewsListView.TabIndex = 10;
			this.TableViewsListView.UseCompatibleStateImageBehavior = false;
			this.TableViewsListView.View = System.Windows.Forms.View.Details;
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
			// CloseButton
			// 
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new System.Drawing.Point(420, 373);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 1;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			// 
			// QuickAccessEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseButton;
			this.ClientSize = new System.Drawing.Size(498, 399);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(514, 438);
			this.Name = "QuickAccessEditForm";
			this.Text = "Edit QDBA Program";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ConnectionsTabPage.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.DataSourcesTabPage.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.TableViewTabPage.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage ConnectionsTabPage;
		private System.Windows.Forms.TabPage DataSourcesTabPage;
		private System.Windows.Forms.TabPage TableViewTabPage;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button AddConnectionButton;
		private System.Windows.Forms.Button EditConnectionButton;
		private System.Windows.Forms.Button DeleteConnectionButton;
		private System.Windows.Forms.ListView ConnectionsListView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ListView DataSourcesListView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
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
	}
}