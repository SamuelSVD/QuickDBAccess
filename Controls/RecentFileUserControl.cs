using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickDBAccess.Controls {
	[DefaultEvent("Click")]
	public partial class RecentFileUserControl : UserControl {
		//public event EventHandler<EventArgs> ButtonClicked;
		public string ProjectName { get { return ProjectNameLabel.Text; } set { ProjectNameLabel.Text = value; } }
		public string ProjectPath { get { return ProjectPathLabel.Text; } set { ProjectPathLabel.Text = value; } }
		public Color HoverColor { get; set; } = Color.White;
		public RecentFileUserControl() {
			InitializeComponent();
		}

		private void c_Click(object sender, EventArgs e) {
			OnClick(e);
		}

		private void c_MouseEnter(object sender, EventArgs e) {
			MousePosCheck();
		}

		private void c_MouseLeave(object sender, EventArgs e) {
			MousePosCheck();
		}

		private void MousePosCheck() {
			Point p = Control.MousePosition;
			if (ProjectPathLabel.ClientRectangle.Contains(ProjectPathLabel.PointToClient(p))) {
				tableLayoutPanel1.BackColor = HoverColor;
			}else if (ProjectNameLabel.ClientRectangle.Contains(ProjectNameLabel.PointToClient(p))) {
				tableLayoutPanel1.BackColor = HoverColor;
			} else if (tableLayoutPanel1.ClientRectangle.Contains(tableLayoutPanel1.PointToClient(p))) {
				tableLayoutPanel1.BackColor = HoverColor;
			} else {
				tableLayoutPanel1.BackColor = BackColor;
			}
		}
	}
}
