using QuickDBAccess.Model;
using System.Diagnostics;
using System.IO;
using Utils;

namespace QuickDBAccess {
    class ProgramData {
		public static QuickAccessModel Instance { get; set; }
		public static string CONFIG = AssemblyDirectory + "\\config.xml";
        public static string AssemblyDirectory {
            get {
                return Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            }
        }
		public static void LoadConfig() {
			Instance = XMLUtils.LoadFromFile<QuickAccessModel>(ProgramData.CONFIG);
		}
		public static void SaveConfig() {
			Instance.SaveToFile(CONFIG);
		}
	}
}
