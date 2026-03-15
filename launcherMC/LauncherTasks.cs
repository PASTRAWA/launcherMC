using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;

namespace launcherMC
{
    public class LauncherTasks
    {

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public async Task launchMC()
        {
            var launchOptions = new MLaunchOption()
            {
                Session = MSession.CreateLegacyOfflineSession(launcherSettings.USERNAME),
                MaximumRamMb = launcherSettings.MaximumRam,
                MinimumRamMb = launcherSettings.MinimumRam,
                ScreenWidth = launcherSettings.Width,
                ScreenHeight = launcherSettings.Height,
                FullScreen = launcherSettings.fullScreen,
                //JavaPath = launcherSettings.JavaPath,
                //ServerIp = launcherSettings.joinServer
                VersionType = "0.0.1",
                GameLauncherName = "CoreLauncher"
            };
            string selectedVersion = launcherSettings.selectedVersion;
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string mcPath = Path.Combine(directory, ".corelauncher");
            var path = new MinecraftPath(mcPath);
            var launcher = new MinecraftLauncher(path);
            launcher.FileProgressChanged += (sender, args) =>
            {
                Console.WriteLine($"Name: {args.Name}");
                Console.WriteLine($"Type: {args.EventType}");
                Console.WriteLine($"Total: {args.TotalTasks}");
                Console.WriteLine($"Progressed: {args.ProgressedTasks}");
            };
            //Logs
            launcher.ByteProgressChanged += (sender, args) =>
            {
                Console.WriteLine($"{args.ProgressedBytes} bytes / {args.TotalBytes} bytes");
            };
            // Install
            await launcher.InstallAsync(selectedVersion.ToString());
            var process = await launcher.BuildProcessAsync(selectedVersion, launchOptions);
            //LAUNCH
            var processWrapper = new ProcessWrapper(process);

            processWrapper.OutputReceived += (sender, log) =>
                Console.WriteLine($"[Game] {log}");

            processWrapper.StartWithEvents();
            var exitCode = await processWrapper.WaitForExitTaskAsync();
            Console.WriteLine($"Game exited with code: {exitCode}");
        }
    }
}