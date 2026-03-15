using System.ComponentModel;

namespace launcherMC
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblSettings = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.controlBox = new ReaLTaiizor.Controls.NightControlBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAccount = new ReaLTaiizor.Controls.Button();
            this.btnLauncherBehavior = new ReaLTaiizor.Controls.Button();
            this.btnGameSettings = new ReaLTaiizor.Controls.Button();
            this.btnAdvanced = new ReaLTaiizor.Controls.Button();
            this.topPanel.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.topPanel.Controls.Add(this.lblSettings);
            this.topPanel.Controls.Add(this.controlBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(600, 30);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(-1, 6);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(170, 20);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "Core Launcher Settings";
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.controlBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.controlBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox.DefaultLocation = true;
            this.controlBox.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.controlBox.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.controlBox.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.controlBox.EnableMaximizeButton = true;
            this.controlBox.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.controlBox.EnableMinimizeButton = true;
            this.controlBox.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.controlBox.Location = new System.Drawing.Point(461, 0);
            this.controlBox.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.controlBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.controlBox.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.controlBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(139, 31);
            this.controlBox.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContent.Location = new System.Drawing.Point(150, 30);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(450, 520);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAdvanced);
            this.pnlButtons.Controls.Add(this.btnAccount);
            this.pnlButtons.Controls.Add(this.btnLauncherBehavior);
            this.pnlButtons.Controls.Add(this.btnGameSettings);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 30);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(150, 520);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAccount.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAccount.Image = null;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAccount.Location = new System.Drawing.Point(0, 120);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAccount.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAccount.Size = new System.Drawing.Size(150, 50);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account & Customization";
            this.btnAccount.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLauncherBehavior
            // 
            this.btnLauncherBehavior.BackColor = System.Drawing.Color.Transparent;
            this.btnLauncherBehavior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLauncherBehavior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLauncherBehavior.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnLauncherBehavior.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLauncherBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLauncherBehavior.Image = null;
            this.btnLauncherBehavior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLauncherBehavior.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLauncherBehavior.Location = new System.Drawing.Point(0, 60);
            this.btnLauncherBehavior.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnLauncherBehavior.Name = "btnLauncherBehavior";
            this.btnLauncherBehavior.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnLauncherBehavior.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnLauncherBehavior.Size = new System.Drawing.Size(150, 50);
            this.btnLauncherBehavior.TabIndex = 1;
            this.btnLauncherBehavior.Text = "Launcher";
            this.btnLauncherBehavior.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLauncherBehavior.Click += new System.EventHandler(this.btnLauncherBehavior_Click);
            // 
            // btnGameSettings
            // 
            this.btnGameSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnGameSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnGameSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameSettings.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnGameSettings.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnGameSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGameSettings.Image = null;
            this.btnGameSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameSettings.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnGameSettings.Location = new System.Drawing.Point(0, 0);
            this.btnGameSettings.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnGameSettings.Name = "btnGameSettings";
            this.btnGameSettings.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnGameSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnGameSettings.Size = new System.Drawing.Size(150, 50);
            this.btnGameSettings.TabIndex = 0;
            this.btnGameSettings.Text = "Game";
            this.btnGameSettings.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGameSettings.Click += new System.EventHandler(this.btnGameSettings_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanced.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAdvanced.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdvanced.Image = null;
            this.btnAdvanced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvanced.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAdvanced.Location = new System.Drawing.Point(0, 180);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAdvanced.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnAdvanced.Size = new System.Drawing.Size(150, 50);
            this.btnAdvanced.TabIndex = 3;
            this.btnAdvanced.Text = "Advanced ";
            this.btnAdvanced.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoreLauncher";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private ReaLTaiizor.Controls.NightControlBox controlBox;
        private System.Windows.Forms.Panel pnlContent;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblSettings;
        private System.Windows.Forms.Panel pnlButtons;
        private ReaLTaiizor.Controls.Button btnGameSettings;
        private ReaLTaiizor.Controls.Button btnLauncherBehavior;
        private ReaLTaiizor.Controls.Button btnAccount;
        private ReaLTaiizor.Controls.Button btnAdvanced;
    }
}