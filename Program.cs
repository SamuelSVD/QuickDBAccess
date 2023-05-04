using QuickDBAccess.Forms;
using QuickDBAccess.Utils;
using System;
using System.Windows.Forms;

namespace QuickDBAccess {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static bool DEBUG = false;
		[STAThread]
		static void Main(string[] args) {
			CreateCommandlineParameters(args);
			if (ArgUtils.Handle(args)) {
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}
		public static void CreateCommandlineParameters(string[] args) {
			ArgUtils.AddHandle(
				new ArgUtils.ArgHandler(
					false,
					"-p",
					1,
					debugParameter));
			ArgUtils.AddHandle(
				new ArgUtils.ArgHandler(
					false,
					"-c",
					1,
					setConfigPath));
			ArgUtils.AddHandle(
				new ArgUtils.ArgHandler(
					false,
					"-d",
					saveDemo));
			ArgUtils.AddHandle(
				new ArgUtils.ArgHandler(
					false,
					"-debug",
					debug));
			ArgUtils.AddHandle(
				new ArgUtils.ArgHandler(
					false,
					setConfigPath));
		}
		private static void debugParameter(object sender, EventArgs e) {
			ArgUtils.ArgHandlerParams p = (ArgUtils.ArgHandlerParams)e;
			string st = "";
			foreach (string s in p.parameters) st += s + " ";
			MessageBox.Show(string.Format("{0} {1} {2}", p.handler.flag, p.parameters.Count.ToString(), st));
		}
		private static void setConfigPath(object sender, EventArgs e) {
			ArgUtils.ArgHandlerParams p = (ArgUtils.ArgHandlerParams)e;
			if (p.parameters.Count == 1) {
				ProgramData.CONFIG = p.parameters[0];
				ProgramData.ShouldBeValidConfigLocation = true;
			}
		}
		private static void saveDemo(object sender, EventArgs e) {
			MessageBox.Show("Demo!");
			Environment.Exit(0);
		}
		private static void debug(object sender, EventArgs e) {
			Program.DEBUG = true;
		}
	}
}
