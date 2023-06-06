using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickDBAccess.Utils {
	internal static class ControlUtils {
		public static void SetTooltip(this Control c, string tooltip) {
			ToolTip t = new ToolTip();
			t.AutoPopDelay = 5000;
			t.InitialDelay = 1000;
			t.ReshowDelay = 500;
			t.ShowAlways = false;

			t.SetToolTip(c, tooltip);
		}
	}
}
