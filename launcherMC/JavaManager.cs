using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcherMC
{
    public class JavaManager
    {

        public string FindJava()
        {
            // JAVA HOME ORTAMI DEĞİŞKENLERİNDE VAR MI KONTROL ET
            string javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");

            if (!string.IsNullOrEmpty(javaHome))
            {
                string path = Path.Combine(javaHome, "bin", "java.exe");
                if (File.Exists(path))
                    return path;
            }
            //PATH DEĞİŞKENİNDE VAR MI KONTROL ET
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "where";
                p.StartInfo.Arguments = "java";
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string result = p.StandardOutput.ReadLine();
                p.WaitForExit();
                if (!string.IsNullOrEmpty(result) && File.Exists(result))
                    return result;
            }
            catch { }
            // 3️⃣ Program Files
            string[] javaFolders =
            {
        @"C:\Program Files\Java",
        @"C:\Program Files (x86)\Java"
    };
            foreach (var folder in javaFolders)
            {
                if (Directory.Exists(folder))
                {
                    foreach (var dir in Directory.GetDirectories(folder))
                    {
                        string javaExe = Path.Combine(dir, "bin", "java.exe");
                        if (File.Exists(javaExe))
                            return javaExe;
                    }
                }
            }
            return "";
        }
        public void setJavaPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Java Executable";
            dialog.Filter = "Java Executable|javaw.exe;java.exe";
            dialog.InitialDirectory = @"C:\Program Files";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.javaPath = dialog.FileName;
                Properties.Settings.Default.isJavaSelectedByUser = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
