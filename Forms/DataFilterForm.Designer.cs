namespace QuickDBAccess.Forms {
	partial class DataFilterForm {
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
			this.ColumnComboBox = new System.Windows.Forms.ComboBox();
			this.ExpressionComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TextTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 3);
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.ColumnComboBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ExpressionComboBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextTextBox, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 46);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ColumnComboBox
			// 
			this.ColumnComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ColumnComboBox.FormattingEnabled = true;
			this.ColumnComboBox.Location = new System.Drawing.Point(3, 16);
			this.ColumnComboBox.Name = "ColumnComboBox";
			this.ColumnComboBox.Size = new System.Drawing.Size(164, 21);
			this.ColumnComboBox.TabIndex = 1;
			this.ColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnComboBox_SelectedIndexChanged);
			// 
			// ExpressionComboBox
			// 
			this.ExpressionComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ExpressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExpressionComboBox.FormattingEnabled = true;
			this.ExpressionComboBox.Location = new System.Drawing.Point(173, 16);
			this.ExpressionComboBox.Name = "ExpressionComboBox";
			this.ExpressionComboBox.Size = new System.Drawing.Size(164, 21);
			this.ExpressionComboBox.TabIndex = 1;
			this.ExpressionComboBox.SelectedIndexChanged += new System.EventHandler(this.ExpressionComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Column";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(173, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Expression";
			// 
			// TextTextBox
			// 
			this.TextTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TextTextBox.Location = new System.Drawing.Point(343, 16);
			this.TextTextBox.Name = "TextTextBox";
			this.TextTextBox.Size = new System.Drawing.Size(165, 20);
			this.TextTextBox.TabIndex = 2;
			this.TextTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(343, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Text";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.OkButton, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.CancelButton, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.ClearButton, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 75);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(352, 49);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 1;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(433, 49);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 2;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(3, 49);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 1;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// DataFilterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataFilterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Filter Data";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.ComboBox ColumnComboBox;
		private System.Windows.Forms.ComboBox ExpressionComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TextTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ClearButton;
	}
}