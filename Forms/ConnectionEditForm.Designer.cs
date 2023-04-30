﻿namespace QuickDBAccess.Forms {
	partial class ConnectionEditForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionEditForm));
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewDetailGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.UserTextBox = new QuickDBAccess.ValidateTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.DatabaseTextBox = new QuickDBAccess.ValidateTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ServerTextBox = new QuickDBAccess.ValidateTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ConnectionNameTextBox = new QuickDBAccess.ValidateTextBox();
			this.ConnectionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new QuickDBAccess.ValidateTextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3.SuspendLayout();
			this.TableViewDetailGroup.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.TableViewDetailGroup, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.OkButton, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.CancelButton, 3, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(306, 259);
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
			this.TableViewDetailGroup.Size = new System.Drawing.Size(300, 224);
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
			this.tableLayoutPanel4.Controls.Add(this.UserTextBox, 0, 7);
			this.tableLayoutPanel4.Controls.Add(this.label4, 0, 8);
			this.tableLayoutPanel4.Controls.Add(this.DatabaseTextBox, 0, 5);
			this.tableLayoutPanel4.Controls.Add(this.label3, 0, 6);
			this.tableLayoutPanel4.Controls.Add(this.ServerTextBox, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.ConnectionNameTextBox, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.ConnectionLabel, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.PasswordTextBox, 0, 9);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 10;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(294, 205);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// UserTextBox
			// 
			this.UserTextBox.Location = new System.Drawing.Point(3, 139);
			this.UserTextBox.Name = "UserTextBox";
			this.UserTextBox.Size = new System.Drawing.Size(288, 22);
			this.UserTextBox.TabIndex = 6;
			this.UserTextBox.TooltipText = "Field should not be empty";
			this.UserTextBox.Valid = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(3, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(288, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Password";
			// 
			// DatabaseTextBox
			// 
			this.DatabaseTextBox.Location = new System.Drawing.Point(3, 98);
			this.DatabaseTextBox.Name = "DatabaseTextBox";
			this.DatabaseTextBox.Size = new System.Drawing.Size(288, 22);
			this.DatabaseTextBox.TabIndex = 6;
			this.DatabaseTextBox.TooltipText = "Field should not be empty";
			this.DatabaseTextBox.Valid = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(3, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(288, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "User";
			// 
			// ServerTextBox
			// 
			this.ServerTextBox.Location = new System.Drawing.Point(3, 57);
			this.ServerTextBox.Name = "ServerTextBox";
			this.ServerTextBox.Size = new System.Drawing.Size(288, 22);
			this.ServerTextBox.TabIndex = 6;
			this.ServerTextBox.TooltipText = "Field should not be empty";
			this.ServerTextBox.Valid = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(3, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Database";
			// 
			// ConnectionNameTextBox
			// 
			this.ConnectionNameTextBox.Location = new System.Drawing.Point(3, 16);
			this.ConnectionNameTextBox.Name = "ConnectionNameTextBox";
			this.ConnectionNameTextBox.Size = new System.Drawing.Size(288, 22);
			this.ConnectionNameTextBox.TabIndex = 6;
			this.ConnectionNameTextBox.TooltipText = "Field should not be empty";
			this.ConnectionNameTextBox.Valid = false;
			// 
			// ConnectionLabel
			// 
			this.ConnectionLabel.AutoSize = true;
			this.ConnectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConnectionLabel.Location = new System.Drawing.Point(3, 41);
			this.ConnectionLabel.Name = "ConnectionLabel";
			this.ConnectionLabel.Size = new System.Drawing.Size(288, 13);
			this.ConnectionLabel.TabIndex = 5;
			this.ConnectionLabel.Text = "Server";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Connection Name";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(3, 180);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(288, 22);
			this.PasswordTextBox.TabIndex = 6;
			this.PasswordTextBox.TooltipText = "Field should not be empty";
			this.PasswordTextBox.Valid = false;
			// 
			// OkButton
			// 
			this.OkButton.AutoSize = true;
			this.OkButton.Location = new System.Drawing.Point(147, 233);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 5;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.AutoSize = true;
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(228, 233);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// ConnectionEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConnectionEditForm";
			this.Text = "Edit Connection";
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.GroupBox TableViewDetailGroup;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ConnectionLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private ValidateTextBox UserTextBox;
		private ValidateTextBox DatabaseTextBox;
		private ValidateTextBox ServerTextBox;
		private ValidateTextBox ConnectionNameTextBox;
		private ValidateTextBox PasswordTextBox;
	}
}