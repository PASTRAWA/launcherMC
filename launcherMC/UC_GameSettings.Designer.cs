namespace launcherMC
{
    partial class UC_GameSettings
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
            this.btnSelectJava = new ReaLTaiizor.Controls.Button();
            this.lblGameSettings = new ReaLTaiizor.Controls.BigLabel();
            this.numericWidth = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericHeight = new ReaLTaiizor.Controls.CrownNumeric();
            this.lblResolution = new ReaLTaiizor.Controls.LabelEdit();
            this.lblWidth = new ReaLTaiizor.Controls.LabelEdit();
            this.lblHeight = new ReaLTaiizor.Controls.LabelEdit();
            this.txtJavaPath = new System.Windows.Forms.TextBox();
            this.lblJavaPath = new ReaLTaiizor.Controls.LabelEdit();
            this.lblMcFolder = new ReaLTaiizor.Controls.LabelEdit();
            this.txtMinecraftPath = new System.Windows.Forms.TextBox();
            this.btnMinecraftFolder = new ReaLTaiizor.Controls.Button();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.numericRamUsage = new ReaLTaiizor.Controls.CrownNumeric();
            this.lblInMb = new ReaLTaiizor.Controls.LabelEdit();
            this.cbFullScreen = new ReaLTaiizor.Controls.HopeCheckBox();
            this.btnApply = new ReaLTaiizor.Controls.Button();
            this.btnFindJava = new ReaLTaiizor.Controls.Button();
            this.btnDefaultFolder = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRamUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectJava
            // 
            this.btnSelectJava.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectJava.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSelectJava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectJava.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSelectJava.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSelectJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelectJava.Image = null;
            this.btnSelectJava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectJava.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSelectJava.Location = new System.Drawing.Point(55, 92);
            this.btnSelectJava.Name = "btnSelectJava";
            this.btnSelectJava.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSelectJava.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnSelectJava.Size = new System.Drawing.Size(189, 34);
            this.btnSelectJava.TabIndex = 0;
            this.btnSelectJava.Text = "Select Java";
            this.btnSelectJava.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSelectJava.Click += new System.EventHandler(this.btnSelectJava_Click);
            // 
            // lblGameSettings
            // 
            this.lblGameSettings.AutoSize = true;
            this.lblGameSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblGameSettings.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblGameSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGameSettings.Location = new System.Drawing.Point(107, 5);
            this.lblGameSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblGameSettings.Name = "lblGameSettings";
            this.lblGameSettings.Size = new System.Drawing.Size(237, 46);
            this.lblGameSettings.TabIndex = 2;
            this.lblGameSettings.Text = "Game Settings";
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(301, 223);
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(120, 20);
            this.numericWidth.TabIndex = 3;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(301, 257);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
            this.numericHeight.TabIndex = 4;
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResolution.ForeColor = System.Drawing.Color.White;
            this.lblResolution.Location = new System.Drawing.Point(298, 205);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(126, 15);
            this.lblResolution.TabIndex = 5;
            this.lblResolution.Text = "Minecraft Resolution :";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblWidth.ForeColor = System.Drawing.Color.White;
            this.lblWidth.Location = new System.Drawing.Point(253, 228);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 15);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width :";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(248, 262);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 15);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height :";
            // 
            // txtJavaPath
            // 
            this.txtJavaPath.Location = new System.Drawing.Point(131, 66);
            this.txtJavaPath.Name = "txtJavaPath";
            this.txtJavaPath.Size = new System.Drawing.Size(303, 20);
            this.txtJavaPath.TabIndex = 9;
            // 
            // lblJavaPath
            // 
            this.lblJavaPath.AutoSize = true;
            this.lblJavaPath.BackColor = System.Drawing.Color.Transparent;
            this.lblJavaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJavaPath.ForeColor = System.Drawing.Color.White;
            this.lblJavaPath.Location = new System.Drawing.Point(25, 66);
            this.lblJavaPath.Name = "lblJavaPath";
            this.lblJavaPath.Size = new System.Drawing.Size(81, 15);
            this.lblJavaPath.TabIndex = 10;
            this.lblJavaPath.Text = "Java Path  :";
            // 
            // lblMcFolder
            // 
            this.lblMcFolder.AutoSize = true;
            this.lblMcFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblMcFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMcFolder.ForeColor = System.Drawing.Color.White;
            this.lblMcFolder.Location = new System.Drawing.Point(5, 146);
            this.lblMcFolder.Name = "lblMcFolder";
            this.lblMcFolder.Size = new System.Drawing.Size(120, 15);
            this.lblMcFolder.TabIndex = 13;
            this.lblMcFolder.Text = "Minecraft Folder :";
            // 
            // txtMinecraftPath
            // 
            this.txtMinecraftPath.Location = new System.Drawing.Point(131, 141);
            this.txtMinecraftPath.Name = "txtMinecraftPath";
            this.txtMinecraftPath.Size = new System.Drawing.Size(303, 20);
            this.txtMinecraftPath.TabIndex = 12;
            // 
            // btnMinecraftFolder
            // 
            this.btnMinecraftFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnMinecraftFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinecraftFolder.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMinecraftFolder.Image = null;
            this.btnMinecraftFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinecraftFolder.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.Location = new System.Drawing.Point(55, 167);
            this.btnMinecraftFolder.Name = "btnMinecraftFolder";
            this.btnMinecraftFolder.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnMinecraftFolder.Size = new System.Drawing.Size(189, 34);
            this.btnMinecraftFolder.TabIndex = 11;
            this.btnMinecraftFolder.Text = "Select Minecraft Folder";
            this.btnMinecraftFolder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinecraftFolder.Click += new System.EventHandler(this.btnMinecraftFolder_Click);
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(321, 280);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(82, 15);
            this.labelEdit3.TabIndex = 15;
            this.labelEdit3.Text = "RAM Usage  :";
            // 
            // numericRamUsage
            // 
            this.numericRamUsage.Location = new System.Drawing.Point(301, 298);
            this.numericRamUsage.Name = "numericRamUsage";
            this.numericRamUsage.Size = new System.Drawing.Size(120, 20);
            this.numericRamUsage.TabIndex = 16;
            // 
            // lblInMb
            // 
            this.lblInMb.AutoSize = true;
            this.lblInMb.BackColor = System.Drawing.Color.Transparent;
            this.lblInMb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInMb.ForeColor = System.Drawing.Color.White;
            this.lblInMb.Location = new System.Drawing.Point(252, 298);
            this.lblInMb.Name = "lblInMb";
            this.lblInMb.Size = new System.Drawing.Size(45, 15);
            this.lblInMb.TabIndex = 17;
            this.lblInMb.Text = "In MB :";
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
            this.cbFullScreen.Location = new System.Drawing.Point(28, 228);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(206, 20);
            this.cbFullScreen.TabIndex = 18;
            this.cbFullScreen.Text = "Start Game Full Screen";
            this.cbFullScreen.UseVisualStyleBackColor = true;
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
            // btnFindJava
            // 
            this.btnFindJava.BackColor = System.Drawing.Color.Transparent;
            this.btnFindJava.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnFindJava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindJava.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnFindJava.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnFindJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFindJava.Image = null;
            this.btnFindJava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindJava.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnFindJava.Location = new System.Drawing.Point(250, 92);
            this.btnFindJava.Name = "btnFindJava";
            this.btnFindJava.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnFindJava.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnFindJava.Size = new System.Drawing.Size(189, 34);
            this.btnFindJava.TabIndex = 26;
            this.btnFindJava.Text = "Find Java";
            this.btnFindJava.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFindJava.Click += new System.EventHandler(this.btnFindJava_Click);
            // 
            // btnDefaultFolder
            // 
            this.btnDefaultFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnDefaultFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefaultFolder.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDefaultFolder.Image = null;
            this.btnDefaultFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefaultFolder.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.Location = new System.Drawing.Point(250, 167);
            this.btnDefaultFolder.Name = "btnDefaultFolder";
            this.btnDefaultFolder.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDefaultFolder.Size = new System.Drawing.Size(189, 34);
            this.btnDefaultFolder.TabIndex = 27;
            this.btnDefaultFolder.Text = "Use Default Folder";
            this.btnDefaultFolder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDefaultFolder.Click += new System.EventHandler(this.btnDefaultFolder_Click);
            // 
            // UC_GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnDefaultFolder);
            this.Controls.Add(this.btnFindJava);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbFullScreen);
            this.Controls.Add(this.lblInMb);
            this.Controls.Add(this.numericRamUsage);
            this.Controls.Add(this.labelEdit3);
            this.Controls.Add(this.lblMcFolder);
            this.Controls.Add(this.txtMinecraftPath);
            this.Controls.Add(this.btnMinecraftFolder);
            this.Controls.Add(this.lblJavaPath);
            this.Controls.Add(this.txtJavaPath);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.lblGameSettings);
            this.Controls.Add(this.btnSelectJava);
            this.Name = "UC_GameSettings";
            this.Size = new System.Drawing.Size(450, 520);
            this.Load += new System.EventHandler(this.UC_GameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRamUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.Button btnSelectJava;
        private ReaLTaiizor.Controls.BigLabel lblGameSettings;
        private ReaLTaiizor.Controls.CrownNumeric numericWidth;
        private ReaLTaiizor.Controls.CrownNumeric numericHeight;
        private ReaLTaiizor.Controls.LabelEdit lblResolution;
        private ReaLTaiizor.Controls.LabelEdit lblWidth;
        private ReaLTaiizor.Controls.LabelEdit lblHeight;
        private System.Windows.Forms.TextBox txtJavaPath;
        private ReaLTaiizor.Controls.LabelEdit lblJavaPath;
        private ReaLTaiizor.Controls.LabelEdit lblMcFolder;
        private System.Windows.Forms.TextBox txtMinecraftPath;
        private ReaLTaiizor.Controls.Button btnMinecraftFolder;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.CrownNumeric numericRamUsage;
        private ReaLTaiizor.Controls.LabelEdit lblInMb;
        private ReaLTaiizor.Controls.HopeCheckBox cbFullScreen;
        private ReaLTaiizor.Controls.Button btnApply;
        private ReaLTaiizor.Controls.Button btnFindJava;
        private ReaLTaiizor.Controls.Button btnDefaultFolder;
    }
}
