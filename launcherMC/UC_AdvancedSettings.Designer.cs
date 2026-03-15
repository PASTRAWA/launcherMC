namespace launcherMC
{
    partial class UC_AdvancedSettings
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
            this.lblAdvancedSettings = new ReaLTaiizor.Controls.BigLabel();
            this.cbFullScreen = new ReaLTaiizor.Controls.HopeCheckBox();
            this.gbVersions = new System.Windows.Forms.GroupBox();
            this.cbReleaseVersions = new ReaLTaiizor.Controls.HopeCheckBox();
            this.cbSnapshotVersions = new ReaLTaiizor.Controls.HopeCheckBox();
            this.cbBetaVersions = new ReaLTaiizor.Controls.HopeCheckBox();
            this.txtJvmArguments = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.lblUsername = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.btnApply = new ReaLTaiizor.Controls.Button();
            this.gbVersions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdvancedSettings
            // 
            this.lblAdvancedSettings.AutoSize = true;
            this.lblAdvancedSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvancedSettings.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblAdvancedSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAdvancedSettings.Location = new System.Drawing.Point(80, 11);
            this.lblAdvancedSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAdvancedSettings.Name = "lblAdvancedSettings";
            this.lblAdvancedSettings.Size = new System.Drawing.Size(298, 46);
            this.lblAdvancedSettings.TabIndex = 5;
            this.lblAdvancedSettings.Text = "Advanced Settings";
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFullScreen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.cbFullScreen.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.cbFullScreen.Enable = true;
            this.cbFullScreen.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbFullScreen.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbFullScreen.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.cbFullScreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFullScreen.ForeColor = System.Drawing.Color.White;
            this.cbFullScreen.Location = new System.Drawing.Point(88, 200);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(338, 20);
            this.cbFullScreen.TabIndex = 19;
            this.cbFullScreen.Text = "Show log screen when the game started";
            this.cbFullScreen.UseVisualStyleBackColor = true;
            // 
            // gbVersions
            // 
            this.gbVersions.Controls.Add(this.cbBetaVersions);
            this.gbVersions.Controls.Add(this.cbSnapshotVersions);
            this.gbVersions.Controls.Add(this.cbReleaseVersions);
            this.gbVersions.Location = new System.Drawing.Point(88, 81);
            this.gbVersions.Name = "gbVersions";
            this.gbVersions.Size = new System.Drawing.Size(338, 100);
            this.gbVersions.TabIndex = 20;
            this.gbVersions.TabStop = false;
            this.gbVersions.Text = "Show versions";
            // 
            // cbReleaseVersions
            // 
            this.cbReleaseVersions.AutoSize = true;
            this.cbReleaseVersions.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbReleaseVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbReleaseVersions.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.cbReleaseVersions.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.cbReleaseVersions.Enable = true;
            this.cbReleaseVersions.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbReleaseVersions.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbReleaseVersions.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.cbReleaseVersions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReleaseVersions.ForeColor = System.Drawing.Color.White;
            this.cbReleaseVersions.Location = new System.Drawing.Point(6, 19);
            this.cbReleaseVersions.Name = "cbReleaseVersions";
            this.cbReleaseVersions.Size = new System.Drawing.Size(93, 20);
            this.cbReleaseVersions.TabIndex = 21;
            this.cbReleaseVersions.Text = "Release";
            this.cbReleaseVersions.UseVisualStyleBackColor = true;
            // 
            // cbSnapshotVersions
            // 
            this.cbSnapshotVersions.AutoSize = true;
            this.cbSnapshotVersions.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbSnapshotVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSnapshotVersions.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.cbSnapshotVersions.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.cbSnapshotVersions.Enable = true;
            this.cbSnapshotVersions.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbSnapshotVersions.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbSnapshotVersions.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.cbSnapshotVersions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSnapshotVersions.ForeColor = System.Drawing.Color.White;
            this.cbSnapshotVersions.Location = new System.Drawing.Point(6, 45);
            this.cbSnapshotVersions.Name = "cbSnapshotVersions";
            this.cbSnapshotVersions.Size = new System.Drawing.Size(106, 20);
            this.cbSnapshotVersions.TabIndex = 22;
            this.cbSnapshotVersions.Text = "Snapshot";
            this.cbSnapshotVersions.UseVisualStyleBackColor = true;
            // 
            // cbBetaVersions
            // 
            this.cbBetaVersions.AutoSize = true;
            this.cbBetaVersions.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbBetaVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBetaVersions.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.cbBetaVersions.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.cbBetaVersions.Enable = true;
            this.cbBetaVersions.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbBetaVersions.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbBetaVersions.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.cbBetaVersions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBetaVersions.ForeColor = System.Drawing.Color.White;
            this.cbBetaVersions.Location = new System.Drawing.Point(6, 71);
            this.cbBetaVersions.Name = "cbBetaVersions";
            this.cbBetaVersions.Size = new System.Drawing.Size(69, 20);
            this.cbBetaVersions.TabIndex = 23;
            this.cbBetaVersions.Text = "Beta";
            this.cbBetaVersions.UseVisualStyleBackColor = true;
            // 
            // txtJvmArguments
            // 
            this.txtJvmArguments.AutoWordSelection = false;
            this.txtJvmArguments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtJvmArguments.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtJvmArguments.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtJvmArguments.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtJvmArguments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtJvmArguments.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtJvmArguments.IsDerivedStyle = true;
            this.txtJvmArguments.Lines = null;
            this.txtJvmArguments.Location = new System.Drawing.Point(88, 278);
            this.txtJvmArguments.MaxLength = 32767;
            this.txtJvmArguments.Name = "txtJvmArguments";
            this.txtJvmArguments.ReadOnly = false;
            this.txtJvmArguments.Size = new System.Drawing.Size(338, 163);
            this.txtJvmArguments.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txtJvmArguments.StyleManager = null;
            this.txtJvmArguments.TabIndex = 21;
            this.txtJvmArguments.ThemeAuthor = "Taiizor";
            this.txtJvmArguments.ThemeName = "MetroLight";
            this.txtJvmArguments.WordWrap = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(90, 255);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(265, 20);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Jvm Arguments for advanced users :";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnApply.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnApply.Image = null;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnApply.Location = new System.Drawing.Point(338, 486);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnApply.Name = "btnApply";
            this.btnApply.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnApply.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.btnApply.Size = new System.Drawing.Size(112, 34);
            this.btnApply.TabIndex = 24;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // UC_AdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtJvmArguments);
            this.Controls.Add(this.gbVersions);
            this.Controls.Add(this.cbFullScreen);
            this.Controls.Add(this.lblAdvancedSettings);
            this.Name = "UC_AdvancedSettings";
            this.Size = new System.Drawing.Size(450, 520);
            this.gbVersions.ResumeLayout(false);
            this.gbVersions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblAdvancedSettings;
        private ReaLTaiizor.Controls.HopeCheckBox cbFullScreen;
        private System.Windows.Forms.GroupBox gbVersions;
        private ReaLTaiizor.Controls.HopeCheckBox cbBetaVersions;
        private ReaLTaiizor.Controls.HopeCheckBox cbSnapshotVersions;
        private ReaLTaiizor.Controls.HopeCheckBox cbReleaseVersions;
        private ReaLTaiizor.Controls.MetroRichTextBox txtJvmArguments;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblUsername;
        private ReaLTaiizor.Controls.Button btnApply;
    }
}
