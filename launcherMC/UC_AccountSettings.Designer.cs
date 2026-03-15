namespace launcherMC
{
    partial class UC_AccountSettings
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBodySkin = new System.Windows.Forms.PictureBox();
            this.lblAccountSettings = new ReaLTaiizor.Controls.BigLabel();
            this.btnLogOut = new ReaLTaiizor.Controls.Button();
            this.lblUsername = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBodySkin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBodySkin
            // 
            this.pbBodySkin.Location = new System.Drawing.Point(147, 124);
            this.pbBodySkin.Name = "pbBodySkin";
            this.pbBodySkin.Size = new System.Drawing.Size(165, 310);
            this.pbBodySkin.TabIndex = 0;
            this.pbBodySkin.TabStop = false;
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountSettings.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblAccountSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAccountSettings.Location = new System.Drawing.Point(94, 11);
            this.lblAccountSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(274, 46);
            this.lblAccountSettings.TabIndex = 4;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogOut.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogOut.Image = null;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogOut.Location = new System.Drawing.Point(141, 440);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogOut.Size = new System.Drawing.Size(171, 55);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Press To Log Out";
            this.btnLogOut.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Sienna;
            this.lblUsername.Location = new System.Drawing.Point(184, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "USERNAME";
            // 
            // UC_AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblAccountSettings);
            this.Controls.Add(this.pbBodySkin);
            this.Name = "UC_AccountSettings";
            this.Size = new System.Drawing.Size(450, 520);
            this.Load += new System.EventHandler(this.UC_AccountSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBodySkin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBodySkin;
        private ReaLTaiizor.Controls.BigLabel lblAccountSettings;
        private ReaLTaiizor.Controls.Button btnLogOut;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblUsername;
    }
}
