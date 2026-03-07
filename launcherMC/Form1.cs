using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcherMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
        }
        private void girisBTN_Click(object sender, EventArgs e)
        {
            if(txtUsername==null || txtUsername.Text.Length < 3)
            {
                launcherSettings.USERNAME = "XWINDOWMANAGER";
                anaMenu mainMenu = new anaMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                launcherSettings.USERNAME = txtUsername.Text;
                anaMenu mainMenu = new anaMenu();
                mainMenu.Show();
                this.Hide();
            }
        }
    }
}
