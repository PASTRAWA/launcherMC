using launcherMC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace launcherMC
{
    public partial class UC_GameSettings : UserControl
    {
        public UC_GameSettings()
        {
            InitializeComponent();
        }
        MinecraftFolder minecraftFolder = new MinecraftFolder();
        JavaManager javaManager = new JavaManager();
        launcherSettings launcherSettings = new launcherSettings();

        private void UC_GameSettings_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.selectedMinecraftPath != null)
            {
                txtMinecraftPath.Text = Properties.Settings.Default.selectedMinecraftPath;
            }
            else
            {
                Properties.Settings.Default.selectedMinecraftPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.corelauncher";
                Properties.Settings.Default.Save();
                txtMinecraftPath.Text = Properties.Settings.Default.selectedMinecraftPath;
            }

            if (Properties.Settings.Default.isJavaSelectedByUser == true)
            {
                Console.WriteLine("java path selected by user.");
                txtJavaPath.Text = Properties.Settings.Default.javaPath;
            }
            else
            {
                txtJavaPath.Text = javaManager.FindJava();
            }
        }
        private void btnSelectJava_Click(object sender, EventArgs e)
        {
            javaManager.setJavaPath();
            txtJavaPath.Text = Properties.Settings.Default.javaPath;
            Properties.Settings.Default.isJavaSelectedByUser = true;
            Properties.Settings.Default.Save();
        }

        private void btnFindJava_Click(object sender, EventArgs e)
        {
            javaManager.FindJava();
            txtJavaPath.Text = javaManager.FindJava();
            Properties.Settings.Default.isJavaSelectedByUser = false;
            Properties.Settings.Default.defaultJavaPath = txtJavaPath.Text;
            Properties.Settings.Default.Save();
        }
        private void btnMinecraftFolder_Click(object sender, EventArgs e)
        {
            minecraftFolder.SetMinecraftPath();
            txtMinecraftPath.Text = minecraftFolder.selectedFolderPath;
        }

        private void btnDefaultFolder_Click(object sender, EventArgs e) 
        {
            minecraftFolder.UseDefaultMinecraftPath();
            txtMinecraftPath.Text = minecraftFolder.selectedFolderPath;
        }

    }
}
