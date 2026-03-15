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
    public partial class UC_AccountSettings : UserControl
    {
        public UC_AccountSettings()
        {
            InitializeComponent();
        }

        private void UC_AccountSettings_Load(object sender, EventArgs e)
        {
            string url = $"https://mc-heads.net/player/{launcherSettings.USERNAME}";
            pbBodySkin.ImageLocation = url;
            pbBodySkin.SizeMode = PictureBoxSizeMode.StretchImage;
            lblUsername.Text = launcherSettings.USERNAME;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
