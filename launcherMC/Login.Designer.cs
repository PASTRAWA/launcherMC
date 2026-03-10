namespace launcherMC
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new ReaLTaiizor.Controls.Button();
            this.exitBtn = new ReaLTaiizor.Controls.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new ReaLTaiizor.Controls.SpaceButton();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.thunderCheckBox1 = new ReaLTaiizor.Controls.ThunderCheckBox();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(784, 30);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.Image = null;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeBtn.InactiveColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Location = new System.Drawing.Point(724, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.minimizeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.minimizeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = null;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.InactiveColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(754, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.exitBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.exitBtn.Size = new System.Drawing.Size(30, 30);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.thunderCheckBox1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.dungeonHeaderLabel1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 581);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::launcherMC.Properties.Resources._638548475358792693_1;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnLogin.Image = null;
            this.btnLogin.Location = new System.Drawing.Point(12, 529);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoRounding = false;
            this.btnLogin.Size = new System.Drawing.Size(170, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Transparent = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(187)))), ((int)(((byte)(240)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(8, 174);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(88, 20);
            this.dungeonHeaderLabel1.TabIndex = 1;
            this.dungeonHeaderLabel1.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 197);
            this.txtUsername.MaxLength = 16;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // thunderCheckBox1
            // 
            this.thunderCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.thunderCheckBox1.Checked = false;
            this.thunderCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thunderCheckBox1.ForeColor = System.Drawing.Color.White;
            this.thunderCheckBox1.Location = new System.Drawing.Point(12, 235);
            this.thunderCheckBox1.Name = "thunderCheckBox1";
            this.thunderCheckBox1.Size = new System.Drawing.Size(170, 16);
            this.thunderCheckBox1.TabIndex = 3;
            this.thunderCheckBox1.Text = "Kullanıcı adını hatırla";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private ReaLTaiizor.Controls.Button exitBtn;
        private ReaLTaiizor.Controls.Button minimizeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.SpaceButton btnLogin;
        private System.Windows.Forms.PictureBox logo;
        private ReaLTaiizor.Controls.ThunderCheckBox thunderCheckBox1;
    }
}