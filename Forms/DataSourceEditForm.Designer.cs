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
			this.ParentParametersLabel = new System.Windows.Forms.Label();
			this.ParentParameterListView = new System.Windows.Forms.ListView();
			this.AddParameterButton = new System.Windows.Forms.Button();
			this.EditParameterButton = new System.Windows.Forms.Button();
			this.DeleteParameterButton = new System.Windows.Forms.Button();
			this.AddParentParameterButton = new System.Windows.Forms.Button();
			this.EditParentParameterButton = new System.Windows.Forms.Button();
			this.DeleteParentParameterButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.QueryGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.QueryLabel = new System.Windows.Forms.Label();
			this.ParametersLabel = new System.Windows.Forms.Label();
			this.QueryRichTextBox = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.TableViewDetailGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.ConnectionComboBox = new System.Windows.Forms.ComboBox();
			this.ConnectionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DataSourceNameTextBox = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel3.SuspendLayout();
			this.QueryGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.TableViewDetailGroup.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// ParameterListView
			// 
			this.ParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParameterListView.HideSelection = false;
			this.ParameterListView.Location = new System.Drawing.Point(32, 87);
			this.ParameterListView.Name = "ParameterListView";
			this.tableLayoutPanel1.SetRowSpan(this.ParameterListView, 2);
			this.ParameterListView.Size = new System.Drawing.Size(311, 52);
			this.ParameterListView.TabIndex = 0;
			this.ParameterListView.UseCompatibleStateImageBehavior = false;
			// 
			// ParentParametersLabel
			// 
			this.ParentParametersLabel.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.ParentParametersLabel, 5);
			this.ParentParametersLabel.Location = new System.Drawing.Point(3, 142);
			this.ParentParametersLabel.Name = "ParentParametersLabel";
			this.ParentParametersLabel.Size = new System.Drawing.Size(94, 13);
			this.ParentParametersLabel.TabIndex = 2;
			this.ParentParametersLabel.Text = "Parent Parameters";
			// 
			// ParentParameterListView
			// 
			this.ParentParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParentParameterListView.HideSelection = false;
			this.ParentParameterListView.Location = new System.Drawing.Point(32, 158);
			this.ParentParameterListView.Name = "ParentParameterListView";
			this.tableLayoutPanel1.SetRowSpan(this.ParentParameterListView, 2);
			this.ParentParameterListView.Size = new System.Drawing.Size(311, 52);
			this.ParentParameterListView.TabIndex = 3;
			this.ParentParameterListView.UseCompatibleStateImageBehavior = false;
			// 
			// AddParameterButton
			// 
			this.AddParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddParameterButton.Location = new System.Drawing.Point(349, 87);
			this.AddParameterButton.Name = "AddParameterButton";
			this.AddParameterButton.Size = new System.Drawing.Size(23, 23);
			this.AddParameterButton.TabIndex = 4;
			this.AddParameterButton.UseVisualStyleBackColor = true;
			// 
			// EditParameterButton
			// 
			this.EditParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.EditParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParameterButton.Location = new System.Drawing.Point(378, 87);
			this.EditParameterButton.Name = "EditParameterButton";
			this.EditParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParameterButton.TabIndex = 4;
			this.EditParameterButton.UseVisualStyleBackColor = true;
			// 
			// DeleteParameterButton
			// 
			this.DeleteParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.DeleteParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParameterButton.Location = new System.Drawing.Point(407, 87);
			this.DeleteParameterButton.Name = "DeleteParameterButton";
			this.DeleteParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParameterButton.TabIndex = 4;
			this.DeleteParameterButton.UseVisualStyleBackColor = true;
			// 
			// AddParentParameterButton
			// 
			this.AddParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddParentParameterButton.Location = new System.Drawing.Point(349, 158);
			this.AddParentParameterButton.Name = "AddParentParameterButton";
			this.AddParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.AddParentParameterButton.TabIndex = 4;
			this.AddParentParameterButton.UseVisualStyleBackColor = true;
			// 
			// EditParentParameterButton
			// 
			this.EditParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.EditParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParentParameterButton.Location = new System.Drawing.Point(378, 158);
			this.EditParentParameterButton.Name = "EditParentParameterButton";
			this.EditParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParentParameterButton.TabIndex = 4;
			this.EditParentParameterButton.UseVisualStyleBackColor = true;
			this.EditParentParameterButton.Click += new System.EventHandler(this.EditParentParameterButton_Click);
			// 
			// DeleteParentParameterButton
			// 
			this.DeleteParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.DeleteParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParentParameterButton.Location = new System.Drawing.Point(407, 158);
			this.DeleteParentParameterButton.Name = "DeleteParentParameterButton";
			this.DeleteParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParentParameterButton.TabIndex = 4;
			this.DeleteParentParameterButton.UseVisualStyleBackColor = true;
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
			this.tableLayoutPanel3.Controls.Add(this.button8, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.button7, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.button1, 3, 2);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 371);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// QueryGroupBox
			// 
			this.QueryGroupBox.AutoSize = true;
			this.QueryGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.SetColumnSpan(this.QueryGroupBox, 4);
			this.QueryGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.QueryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QueryGroupBox.Location = new System.Drawing.Point(3, 107);
			this.QueryGroupBox.Name = "QueryGroupBox";
			this.QueryGroupBox.Size = new System.Drawing.Size(439, 232);
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
			this.tableLayoutPanel1.Controls.Add(this.AddParameterButton, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.button2, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.ParentParametersLabel, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.AddParentParameterButton, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.EditParentParameterButton, 3, 6);
			this.tableLayoutPanel1.Controls.Add(this.DeleteParentParameterButton, 4, 6);
			this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.button5, 0, 7);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 213);
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
			this.ParametersLabel.Location = new System.Drawing.Point(3, 71);
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
			this.QueryRichTextBox.Size = new System.Drawing.Size(427, 52);
			this.QueryRichTextBox.TabIndex = 3;
			this.QueryRichTextBox.Text = "";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Location = new System.Drawing.Point(3, 158);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Location = new System.Drawing.Point(3, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(23, 23);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Location = new System.Drawing.Point(3, 116);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(23, 23);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Location = new System.Drawing.Point(3, 187);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(23, 23);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button2_Click);
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
			this.TableViewDetailGroup.Size = new System.Drawing.Size(439, 98);
			this.TableViewDetailGroup.TabIndex = 6;
			this.TableViewDetailGroup.TabStop = false;
			this.TableViewDetailGroup.Text = "Data Source Properties";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.ConnectionComboBox, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.ConnectionLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.DataSourceNameTextBox, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(433, 79);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// ConnectionComboBox
			// 
			this.ConnectionComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConnectionComboBox.FormattingEnabled = true;
			this.ConnectionComboBox.Location = new System.Drawing.Point(3, 55);
			this.ConnectionComboBox.Name = "ConnectionComboBox";
			this.ConnectionComboBox.Size = new System.Drawing.Size(427, 21);
			this.ConnectionComboBox.TabIndex = 6;
			// 
			// ConnectionLabel
			// 
			this.ConnectionLabel.AutoSize = true;
			this.ConnectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConnectionLabel.Location = new System.Drawing.Point(3, 39);
			this.ConnectionLabel.Name = "ConnectionLabel";
			this.ConnectionLabel.Size = new System.Drawing.Size(427, 13);
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
			// DataSourceNameTextBox
			// 
			this.DataSourceNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceNameTextBox.Location = new System.Drawing.Point(3, 16);
			this.DataSourceNameTextBox.Name = "DataSourceNameTextBox";
			this.DataSourceNameTextBox.Size = new System.Drawing.Size(427, 20);
			this.DataSourceNameTextBox.TabIndex = 1;
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.Location = new System.Drawing.Point(205, 345);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 5;
			this.button8.Text = "OK";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.Location = new System.Drawing.Point(286, 345);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 5;
			this.button7.Text = "Apply";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(367, 345);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// DataSourceEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DataSourceEditForm";
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
		private System.Windows.Forms.Button AddParameterButton;
		private System.Windows.Forms.Button EditParameterButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button DeleteParameterButton;
		private System.Windows.Forms.Button AddParentParameterButton;
		private System.Windows.Forms.Button EditParentParameterButton;
		private System.Windows.Forms.Button DeleteParentParameterButton;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox TableViewDetailGroup;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.ListView ParameterListView;
		private System.Windows.Forms.ListView ParentParameterListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox DataSourceNameTextBox;
		private System.Windows.Forms.GroupBox QueryGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label QueryLabel;
		private System.Windows.Forms.Label ParametersLabel;
		private System.Windows.Forms.RichTextBox QueryRichTextBox;
		private System.Windows.Forms.ComboBox ConnectionComboBox;
		private System.Windows.Forms.Label ConnectionLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}