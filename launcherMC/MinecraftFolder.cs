using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcherMC
{
    public class MinecraftFolder
    {
        public string selectedFolderPath = null;
        public void SetMinecraftPath()
        {
            FolderBrowserDialog gameDirectory = new FolderBrowserDialog();
            gameDirectory.RootFolder = Environment.SpecialFolder.ApplicationData;
            if (gameDirectory.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = gameDirectory.SelectedPath;
                Properties.Settings.Default.selectedMinecraftPath = selectedFolderPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("no folders were selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void UseDefaultMinecraftPath()
        {
            selectedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.corelauncher";
            Properties.Settings.Default.selectedMinecraftPath = selectedFolderPath;
            Properties.Settings.Default.Save();
        }   

    }   
}
