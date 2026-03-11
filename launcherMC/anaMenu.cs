using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using CmlLib.Core.Rules;
using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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


        public async void launchMC()
        {
            var selectedVersion = versionCombo.SelectedValue?.ToString();
            var launchOptions = new MLaunchOption
            {
                Session = MSession.CreateOfflineSession(launcherSettings.USERNAME),
                MaximumRamMb = launcherSettings.MaximumRam,
                MinimumRamMb = launcherSettings.MinimumRam,
                ScreenWidth = launcherSettings.Width,
                ScreenHeight = launcherSettings.Height,
                FullScreen = launcherSettings.fullScreen,
                //JavaPath = launcherSettings.JavaPath,
                //ServerIp = launcherSettings.joinServer
                VersionType = "CUSTOMLAUNCHER",
                GameLauncherName = "CUSTOMLAUNCHER"
            };
            var path = new MinecraftPath("C:\\Users\\Eren\\source\\repos\\launcherMC\\launcherMC\\game\\");
            var launcher = new MinecraftLauncher(path);
            //logs
            launcher.FileProgressChanged += (sender, args) =>
            {
                Console.WriteLine($"Name: {args.Name}");
                Console.WriteLine($"Type: {args.EventType}");
                Console.WriteLine($"Total: {args.TotalTasks}");
                Console.WriteLine($"Progressed: {args.ProgressedTasks}");
            };
            launcher.ByteProgressChanged += (sender, args) =>
            {
                Console.WriteLine($"{args.ProgressedBytes} bytes / {args.TotalBytes} bytes");
            };

            // Install
            await launcher.InstallAsync(selectedVersion.ToString());

            var process = await launcher.BuildProcessAsync(selectedVersion,launchOptions);


            //LAUNCH
            var processWrapper = new ProcessWrapper(process);

            processWrapper.OutputReceived += (sender, log) =>
                Console.WriteLine($"[Game] {log}");

            processWrapper.StartWithEvents();
            var exitCode = await processWrapper.WaitForExitTaskAsync();
            Console.WriteLine($"Game exited with code: {exitCode}");
        }

        public async void loadVersions()
        {
            var launcher = new MinecraftLauncher();
            var versions = await launcher.GetAllVersionsAsync();
            var releaseVersions = versions.Where(v => v.Type == "release").ToList();

            // Create a lightweight list with display and value members so the combo
            // can show "RELEASE : <name>" but SelectedValue will be just the name.
            var items = releaseVersions
                .Select(v => new { Name = v.Name, Display = "RELEASE : " + v.Name })
                .ToList();

            versionCombo.DisplayMember = "Display";
            versionCombo.ValueMember = "Name";
            versionCombo.DataSource = items;
            if (versionCombo.Items.Count > 0)
                versionCombo.SelectedIndex = 0;
        }
        //load
        private async void anaMenu_Load(object sender, EventArgs e)
        {
            string url = $"https://mc-heads.net/avatar/{launcherSettings.USERNAME}";
            loadVersions();
            Console.WriteLine(launcherSettings.USERNAME);
            headPicture.ImageLocation = url;
            headPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = launcherSettings.USERNAME;
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LAUNCHING MINECRAFT WITH THESE SETTINGS", launcherSettings.MaximumRam, launcherSettings.USERNAME);
            launchMC();
        }
    }
}
