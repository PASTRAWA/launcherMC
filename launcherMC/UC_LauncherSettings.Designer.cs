namespace launcherMC
{
    partial class UC_LauncherSettings
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
            this.lblLauncherBehavior = new ReaLTaiizor.Controls.BigLabel();
            this.gbGameStarts = new System.Windows.Forms.GroupBox();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.rbHide = new System.Windows.Forms.RadioButton();
            this.rbKeepOpen = new System.Windows.Forms.RadioButton();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new ReaLTaiizor.Controls.LabelEdit();
            this.btnApply = new ReaLTaiizor.Controls.Button();
            this.gbGameStarts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLauncherBehavior
            // 
            this.lblLauncherBehavior.AutoSize = true;
            this.lblLauncherBehavior.BackColor = System.Drawing.Color.Transparent;
            this.lblLauncherBehavior.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblLauncherBehavior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblLauncherBehavior.Location = new System.Drawing.Point(84, 5);
            this.lblLauncherBehavior.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblLauncherBehavior.Name = "lblLauncherBehavior";
            this.lblLauncherBehavior.Size = new System.Drawing.Size(294, 46);
            this.lblLauncherBehavior.TabIndex = 3;
            this.lblLauncherBehavior.Text = "Launcher Behavior";
            // 
            // gbGameStarts
            // 
            this.gbGameStarts.Controls.Add(this.rbClose);
            this.gbGameStarts.Controls.Add(this.rbHide);
            this.gbGameStarts.Controls.Add(this.rbKeepOpen);
            this.gbGameStarts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGameStarts.Location = new System.Drawing.Point(115, 64);
            this.gbGameStarts.Name = "gbGameStarts";
            this.gbGameStarts.Size = new System.Drawing.Size(211, 99);
            this.gbGameStarts.TabIndex = 4;
            this.gbGameStarts.TabStop = false;
            this.gbGameStarts.Text = "When the game starts";
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClose.Location = new System.Drawing.Point(15, 65);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(131, 17);
            this.rbClose.TabIndex = 7;
            this.rbClose.TabStop = true;
            this.rbClose.Text = "Close the launcher";
            this.rbClose.UseVisualStyleBackColor = true;
            // 
            // rbHide
            // 
            this.rbHide.AutoSize = true;
            this.rbHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHide.Location = new System.Drawing.Point(15, 42);
            this.rbHide.Name = "rbHide";
            this.rbHide.Size = new System.Drawing.Size(126, 17);
            this.rbHide.TabIndex = 6;
            this.rbHide.TabStop = true;
            this.rbHide.Text = "Hide the launcher";
            this.rbHide.UseVisualStyleBackColor = true;
            // 
            // rbKeepOpen
            // 
            this.rbKeepOpen.AutoSize = true;
            this.rbKeepOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKeepOpen.Location = new System.Drawing.Point(15, 19);
            this.rbKeepOpen.Name = "rbKeepOpen";
            this.rbKeepOpen.Size = new System.Drawing.Size(165, 17);
            this.rbKeepOpen.TabIndex = 5;
            this.rbKeepOpen.TabStop = true;
            this.rbKeepOpen.Text = "Keep the launcher open ";
            this.rbKeepOpen.UseVisualStyleBackColor = true;
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(190, 184);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(136, 21);
            this.cbLanguage.TabIndex = 5;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(41, 185);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(143, 15);
            this.lblLanguage.TabIndex = 14;
            this.lblLanguage.Text = "Launcher Language :";
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
            this.btnApply.TabIndex = 25;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // UC_LauncherSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.gbGameStarts);
            this.Controls.Add(this.lblLauncherBehavior);
            this.Name = "UC_LauncherSettings";
            this.Size = new System.Drawing.Size(450, 520);
            this.gbGameStarts.ResumeLayout(false);
            this.gbGameStarts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblLauncherBehavior;
        private System.Windows.Forms.GroupBox gbGameStarts;
        private System.Windows.Forms.RadioButton rbHide;
        private System.Windows.Forms.RadioButton rbKeepOpen;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.ComboBox cbLanguage;
        private ReaLTaiizor.Controls.LabelEdit lblLanguage;
        private ReaLTaiizor.Controls.Button btnApply;
    }
}
