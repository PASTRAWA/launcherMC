using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace launcherMC
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
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

        private void showControl(Control control)
        {
            pnlContent.Controls.Clear(); // Önceki ekranı sil
            control.Dock = DockStyle.Fill; // Paneli tamamen kapla
            pnlContent.Controls.Add(control); // Yeni ekranı ekle
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            UC_GameSettings gameSettings = new UC_GameSettings();
            showControl(gameSettings);
        }

        private void btnGameSettings_Click(object sender, EventArgs e)
        {
            UC_GameSettings gameSettings = new UC_GameSettings();
            showControl(gameSettings);
        }

        private void btnLauncherBehavior_Click(object sender, EventArgs e)
        {
            UC_LauncherSettings launcherSettings = new UC_LauncherSettings();
            showControl(launcherSettings);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UC_AccountSettings accountSettings = new UC_AccountSettings();
            showControl(accountSettings);
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            UC_AdvancedSettings advancedSettings = new UC_AdvancedSettings();
            showControl(advancedSettings);
        }
    }
}