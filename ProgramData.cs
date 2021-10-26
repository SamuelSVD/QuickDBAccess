using System.Diagnostics;
using System.IO;

namespace QuickDBAccess {
    class ProgramData {
        public static string CONFIG = AssemblyDirectory + "\\config.xml";
        public static string AssemblyDirectory {
            get {
                return Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            }
        }
    }
}
