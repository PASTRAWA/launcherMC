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
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using CmlLib.Core.Rules;
using CmlLib.Core.VersionMetadata;
namespace launcherMC
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            launchMC();
        }

        public async void launchMC()
        {
            var selectedVersion = comboBox1.SelectedItem.ToString();
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
            foreach (var version in releaseVersions)
            {
                comboBox1.Items.Add(version.Name);
            }
        }
        //load
        private async void anaMenu_Load(object sender, EventArgs e)
        {
            loadVersions();
            Console.WriteLine(launcherSettings.USERNAME);
        }
    }
}
