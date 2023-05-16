using QuickDBAccess.Model;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace QuickDBAccess {
    class ProgramData {
		public static QuickAccessModel Instance { get; set; }
		public static string CONFIG = AssemblyDirectory + "\\config.xml";
		public static bool ValidConfigLocation = false;
		public static bool ShouldBeValidConfigLocation = false;
		public static bool Changed = false;

		public static string AssemblyDirectory {
            get {
                return Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            }
        }
		public static void LoadConfig() {
			Instance = XMLUtils.LoadFromFile<QuickAccessModel>(ProgramData.CONFIG);
			if (Instance != null && ShouldBeValidConfigLocation) {
				ValidConfigLocation = true;
			}
		}
		public static void OpenConfig() {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Quick DB Access Program | *.qdba|XML File | *.xml";
			ofd.InitialDirectory = AssemblyDirectory;
			if (ofd.ShowDialog() == DialogResult.OK) {
				CONFIG = ofd.FileName;
				LoadConfig();
				ValidConfigLocation = true;
			}
		}
		public static bool SaveConfig() {
			if (ProgramData.Instance == null) return false;
			if (!ValidConfigLocation) {
				return SaveConfigAs();
			} else {
				Instance.SaveToFile(CONFIG);
				Changed = false;
				return true;
			}
		}
		public static bool SaveConfigAs() {
			if (ProgramData.Instance == null) return false;
			SaveFileDialog d = new SaveFileDialog();
			d.Filter = "Quick DB Access Program | *.qdba|XML File | *.xml";
			d.InitialDirectory = AssemblyDirectory;
			if (d.ShowDialog() == DialogResult.OK) {
				Instance.SaveToFile(d.FileName);
				CONFIG = d.FileName;
				ValidConfigLocation = true;
				Changed = false;
				return true;
			}
			return false;
		}
	}
}
