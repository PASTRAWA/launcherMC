using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using CmlLib.Core.Rules;
using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
namespace launcherMC
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public async void LoadVersions()
        {
            try
            {
                var launcher = new MinecraftLauncher();
                var versions = await launcher.GetAllVersionsAsync();
                var releaseVersions = versions.Where(v => v.Type == "release").ToList();
                var items = releaseVersions
                    .Select(v => new { Name = v.Name, Display = "RELEASE : " + v.Name })
                    .ToList();

                versionCombo.DisplayMember = "Display";
                versionCombo.ValueMember = "Name";
                versionCombo.DataSource = items;
                if (versionCombo.Items.Count > 0)
                    versionCombo.SelectedIndex = 0;
            }
            catch
            {
                string mcPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    ".corelauncher",
                    "versions"
                );
                var versions = Directory.GetDirectories(mcPath)
                    .Select(v => Path.GetFileName(v))
                    .ToList();
                var items = versions
                    .Select(v => new { Name = v, Display = "RELEASE : " + v })
                    .ToList();
                versionCombo.DisplayMember = "Display";
                versionCombo.ValueMember = "Name";
                versionCombo.DataSource = items;
                if (versionCombo.Items.Count > 0)
                    versionCombo.SelectedIndex = 0;
            }
        }
        
        //load
        private async void anaMenu_Load(object sender, EventArgs e)
        {
            string url = $"https://mc-heads.net/avatar/{launcherSettings.USERNAME}";
            LoadVersions();
            Console.WriteLine(launcherSettings.USERNAME);
            headPicture.ImageLocation = url;
            headPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = launcherSettings.USERNAME;
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            if(launcherSettings.selectedVersion == null)
            {
                MessageBox.Show("you need to select a version to launch the game", "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            Console.WriteLine("LAUNCHING MINECRAFT WITH THESE SETTINGS", launcherSettings.MaximumRam, launcherSettings.USERNAME);
            LauncherTasks launchGame = new LauncherTasks();
            launcherSettings.selectedVersion = versionCombo.SelectedValue?.ToString();
            launchGame.launchMC();
        }

        private void directoryBtn_Click(object sender, EventArgs e)
        {
            string directory =Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string mcPath = Path.Combine(directory, ".corelauncher");
            try
            {
                Process.Start(mcPath);
            }
            catch
            {
                Directory.CreateDirectory(mcPath);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm FrmSettings = new SettingsForm();
            FrmSettings.Show();
        }
    }
}
