using QuickDBAccess.Forms;
using QuickDBAccess.Utils;
using System;
using System.Text;
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
					"-debug",
					debug));
			ArgUtils.AddHelpHandle(
				new ArgUtils.ArgHandler(
					false,
					"-h",
					help
					));
			ArgUtils.AddHelpHandle(
				new ArgUtils.ArgHandler(
					false,
					"--help",
					help
					));
			ArgUtils.AddHelpHandle(
				new ArgUtils.ArgHandler(
					false,
					"/?",
					help
					));
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
		private static void debug(object sender, EventArgs e) {
			Program.DEBUG = true;
		}
		private static void help(object sender, EventArgs e) {
			StringBuilder sb = new StringBuilder();
			sb.Append("QuickDBAccess is a tool that works as a front end application to a database. See below for valid commandline parameters");
			sb.Append("\n");
			sb.Append("\n");
			sb.Append("QuickDBAccess.exe [<path>] [-c <path>] [-d] [-h | --help | /?]");
			sb.Append("\n");
			sb.Append("    ");
			sb.Append("\n");
			sb.Append("    <path> - path to .qdba file to open");
			sb.Append("\n");
			sb.Append("    -c     - set starting .qdba file to open as the input <path>");
			sb.Append("\n");
			sb.Append("    -d     - display debug information");
			sb.Append("\n");
			sb.Append("    -h | --help | /?    - display help");
			sb.Append("\n");
			MessageBox.Show(sb.ToString(), "QuickDBAccess - Help");
		}
	}
}
