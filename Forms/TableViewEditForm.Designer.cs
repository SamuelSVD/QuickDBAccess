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
			this.ParameterListView = new System.Windows.Forms.ListView();
			this.ParametersLabel = new System.Windows.Forms.Label();
			this.ParentParametersLabel = new System.Windows.Forms.Label();
			this.ParentParameterListView = new System.Windows.Forms.ListView();
			this.DeleteParameterButton = new System.Windows.Forms.Button();
			this.EditParameterButton = new System.Windows.Forms.Button();
			this.AddParameterButton = new System.Windows.Forms.Button();
			this.AddParentParameterButton = new System.Windows.Forms.Button();
			this.EditParentParameterButton = new System.Windows.Forms.Button();
			this.DeleteParentParameterButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewDetailGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.TableViewNameTextBox = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.DataSourceLabel.Location = new System.Drawing.Point(3, 39);
			this.DataSourceLabel.Name = "DataSourceLabel";
			this.DataSourceLabel.Size = new System.Drawing.Size(67, 13);
			this.DataSourceLabel.TabIndex = 0;
			this.DataSourceLabel.Text = "Data Source";
			// 
			// DataSourceComboBox
			// 
			this.DataSourceComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataSourceComboBox.FormattingEnabled = true;
			this.DataSourceComboBox.Location = new System.Drawing.Point(3, 55);
			this.DataSourceComboBox.Name = "DataSourceComboBox";
			this.DataSourceComboBox.Size = new System.Drawing.Size(348, 21);
			this.DataSourceComboBox.TabIndex = 2;
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
			this.tableLayoutPanel2.Controls.Add(this.ParameterListView, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.ParametersLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ParentParametersLabel, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.ParentParameterListView, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.DeleteParameterButton, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.EditParameterButton, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.AddParameterButton, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.AddParentParameterButton, 2, 4);
			this.tableLayoutPanel2.Controls.Add(this.EditParentParameterButton, 3, 4);
			this.tableLayoutPanel2.Controls.Add(this.DeleteParentParameterButton, 4, 4);
			this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.button4, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.button5, 0, 5);
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 142);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// ParameterListView
			// 
			this.ParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParameterListView.HideSelection = false;
			this.ParameterListView.Location = new System.Drawing.Point(32, 16);
			this.ParameterListView.Name = "ParameterListView";
			this.tableLayoutPanel2.SetRowSpan(this.ParameterListView, 2);
			this.ParameterListView.Size = new System.Drawing.Size(232, 52);
			this.ParameterListView.TabIndex = 0;
			this.ParameterListView.UseCompatibleStateImageBehavior = false;
			// 
			// ParametersLabel
			// 
			this.ParametersLabel.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ParametersLabel, 5);
			this.ParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParametersLabel.Location = new System.Drawing.Point(3, 0);
			this.ParametersLabel.Name = "ParametersLabel";
			this.ParametersLabel.Size = new System.Drawing.Size(348, 13);
			this.ParametersLabel.TabIndex = 1;
			this.ParametersLabel.Text = "Buttons";
			// 
			// ParentParametersLabel
			// 
			this.ParentParametersLabel.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.ParentParametersLabel, 5);
			this.ParentParametersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParentParametersLabel.Location = new System.Drawing.Point(3, 71);
			this.ParentParametersLabel.Name = "ParentParametersLabel";
			this.ParentParametersLabel.Size = new System.Drawing.Size(348, 13);
			this.ParentParametersLabel.TabIndex = 2;
			this.ParentParametersLabel.Text = "Table Views";
			// 
			// ParentParameterListView
			// 
			this.ParentParameterListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParentParameterListView.HideSelection = false;
			this.ParentParameterListView.Location = new System.Drawing.Point(32, 87);
			this.ParentParameterListView.Name = "ParentParameterListView";
			this.tableLayoutPanel2.SetRowSpan(this.ParentParameterListView, 2);
			this.ParentParameterListView.Size = new System.Drawing.Size(232, 52);
			this.ParentParameterListView.TabIndex = 3;
			this.ParentParameterListView.UseCompatibleStateImageBehavior = false;
			// 
			// DeleteParameterButton
			// 
			this.DeleteParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.DeleteParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParameterButton.Location = new System.Drawing.Point(328, 16);
			this.DeleteParameterButton.Name = "DeleteParameterButton";
			this.DeleteParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParameterButton.TabIndex = 4;
			this.DeleteParameterButton.UseVisualStyleBackColor = true;
			// 
			// EditParameterButton
			// 
			this.EditParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.EditParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParameterButton.Location = new System.Drawing.Point(299, 16);
			this.EditParameterButton.Name = "EditParameterButton";
			this.EditParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParameterButton.TabIndex = 4;
			this.EditParameterButton.UseVisualStyleBackColor = true;
			// 
			// AddParameterButton
			// 
			this.AddParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddParameterButton.Location = new System.Drawing.Point(270, 16);
			this.AddParameterButton.Name = "AddParameterButton";
			this.AddParameterButton.Size = new System.Drawing.Size(23, 23);
			this.AddParameterButton.TabIndex = 4;
			this.AddParameterButton.UseVisualStyleBackColor = true;
			// 
			// AddParentParameterButton
			// 
			this.AddParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.add;
			this.AddParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddParentParameterButton.Location = new System.Drawing.Point(270, 87);
			this.AddParentParameterButton.Name = "AddParentParameterButton";
			this.AddParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.AddParentParameterButton.TabIndex = 4;
			this.AddParentParameterButton.UseVisualStyleBackColor = true;
			// 
			// EditParentParameterButton
			// 
			this.EditParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.edit;
			this.EditParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditParentParameterButton.Location = new System.Drawing.Point(299, 87);
			this.EditParentParameterButton.Name = "EditParentParameterButton";
			this.EditParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.EditParentParameterButton.TabIndex = 4;
			this.EditParentParameterButton.UseVisualStyleBackColor = true;
			// 
			// DeleteParentParameterButton
			// 
			this.DeleteParentParameterButton.BackgroundImage = global::QuickDBAccess.Properties.Resources.delete;
			this.DeleteParentParameterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteParentParameterButton.Location = new System.Drawing.Point(328, 87);
			this.DeleteParentParameterButton.Name = "DeleteParentParameterButton";
			this.DeleteParentParameterButton.Size = new System.Drawing.Size(23, 23);
			this.DeleteParentParameterButton.TabIndex = 4;
			this.DeleteParentParameterButton.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Location = new System.Drawing.Point(3, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Location = new System.Drawing.Point(3, 45);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(23, 23);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::QuickDBAccess.Properties.Resources.up;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Location = new System.Drawing.Point(3, 87);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(23, 23);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::QuickDBAccess.Properties.Resources.down;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Location = new System.Drawing.Point(3, 116);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(23, 23);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// ParametersGroupBox
			// 
			this.ParametersGroupBox.AutoSize = true;
			this.ParametersGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.SetColumnSpan(this.ParametersGroupBox, 4);
			this.ParametersGroupBox.Controls.Add(this.tableLayoutPanel2);
			this.ParametersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParametersGroupBox.Location = new System.Drawing.Point(3, 107);
			this.ParametersGroupBox.Name = "ParametersGroupBox";
			this.ParametersGroupBox.Size = new System.Drawing.Size(360, 161);
			this.ParametersGroupBox.TabIndex = 4;
			this.ParametersGroupBox.TabStop = false;
			this.ParametersGroupBox.Text = "Details";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.ParametersGroupBox, 0, 1);
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
			this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 300);
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
			this.TableViewDetailGroup.Size = new System.Drawing.Size(360, 98);
			this.TableViewDetailGroup.TabIndex = 6;
			this.TableViewDetailGroup.TabStop = false;
			this.TableViewDetailGroup.Text = "Table View Properties";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.DataSourceLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.DataSourceComboBox, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.TableViewNameTextBox, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(354, 79);
			this.tableLayoutPanel4.TabIndex = 0;
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
			// TableViewNameTextBox
			// 
			this.TableViewNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TableViewNameTextBox.Location = new System.Drawing.Point(3, 16);
			this.TableViewNameTextBox.Name = "TableViewNameTextBox";
			this.TableViewNameTextBox.Size = new System.Drawing.Size(348, 20);
			this.TableViewNameTextBox.TabIndex = 1;
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.Location = new System.Drawing.Point(126, 274);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 5;
			this.button8.Text = "OK";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.Location = new System.Drawing.Point(207, 274);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 5;
			this.button7.Text = "Apply";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(288, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// TableViewEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TableViewEditForm";
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
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label DataSourceLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label ParametersLabel;
		private System.Windows.Forms.Label ParentParametersLabel;
		private System.Windows.Forms.GroupBox ParametersGroupBox;
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
		private System.Windows.Forms.TextBox TableViewNameTextBox;
		private System.Windows.Forms.ComboBox DataSourceComboBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}