using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using launcherMC.Properties;

namespace launcherMC
{
    
    public partial class Login : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public Login()
        {
            InitializeComponent();
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                rememberUsername.Checked = true;
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (rememberUsername.Checked)
            {
                Properties.Settings.Default.username = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.Save();
            }
            string username = txtUsername.Text;
            if (username.Length > 3)
            {
                launcherSettings.USERNAME = username;
                anaMenu mainMenu = new anaMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("isim yanlış");
            }
        }
    }
}
