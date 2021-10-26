using System.Reflection;
using System.Windows.Forms;

namespace QuickDBAccess.Forms {
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            versionLabel.Text = "Version: " + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
