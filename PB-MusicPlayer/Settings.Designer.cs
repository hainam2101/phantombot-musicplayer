namespace PB_MusicPlayer
{
    partial class Settings
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.credentialsHeader = new System.Windows.Forms.Label();
            this.credentialsNameLabel = new System.Windows.Forms.Label();
            this.credentialsPasswordLabel = new System.Windows.Forms.Label();
            this.credentialsName = new System.Windows.Forms.TextBox();
            this.credentialsPassword = new System.Windows.Forms.TextBox();
            this.hostHeader = new System.Windows.Forms.Label();
            this.HostInfoLabel = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.hostExapmlesLabel = new System.Windows.Forms.Label();
            this.songHeader = new System.Windows.Forms.Label();
            this.songOutputLabel = new System.Windows.Forms.Label();
            this.songOutputPre = new System.Windows.Forms.Label();
            this.songPath = new System.Windows.Forms.Label();
            this.songButtonPath = new System.Windows.Forms.Button();
            this.songFormat = new System.Windows.Forms.TextBox();
            this.songFormatLabel = new System.Windows.Forms.Label();
            this.settingsPicture = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(93, 30);
            this.header.TabIndex = 0;
            this.header.Text = "Settings";
            // 
            // credentialsHeader
            // 
            this.credentialsHeader.AutoSize = true;
            this.credentialsHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsHeader.Location = new System.Drawing.Point(13, 57);
            this.credentialsHeader.Name = "credentialsHeader";
            this.credentialsHeader.Size = new System.Drawing.Size(214, 20);
            this.credentialsHeader.TabIndex = 1;
            this.credentialsHeader.Text = "Your PhantomBot credentials";
            // 
            // credentialsNameLabel
            // 
            this.credentialsNameLabel.AutoSize = true;
            this.credentialsNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsNameLabel.Location = new System.Drawing.Point(14, 86);
            this.credentialsNameLabel.Name = "credentialsNameLabel";
            this.credentialsNameLabel.Size = new System.Drawing.Size(177, 17);
            this.credentialsNameLabel.TabIndex = 2;
            this.credentialsNameLabel.Text = "PhantomBot Login Username";
            // 
            // credentialsPasswordLabel
            // 
            this.credentialsPasswordLabel.AutoSize = true;
            this.credentialsPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsPasswordLabel.Location = new System.Drawing.Point(14, 143);
            this.credentialsPasswordLabel.Name = "credentialsPasswordLabel";
            this.credentialsPasswordLabel.Size = new System.Drawing.Size(174, 17);
            this.credentialsPasswordLabel.TabIndex = 3;
            this.credentialsPasswordLabel.Text = "PhantomBot Login Password";
            // 
            // credentialsName
            // 
            this.credentialsName.Location = new System.Drawing.Point(17, 108);
            this.credentialsName.Name = "credentialsName";
            this.credentialsName.Size = new System.Drawing.Size(304, 20);
            this.credentialsName.TabIndex = 4;
            // 
            // credentialsPassword
            // 
            this.credentialsPassword.Location = new System.Drawing.Point(17, 165);
            this.credentialsPassword.Name = "credentialsPassword";
            this.credentialsPassword.PasswordChar = '•';
            this.credentialsPassword.Size = new System.Drawing.Size(304, 20);
            this.credentialsPassword.TabIndex = 5;
            // 
            // hostHeader
            // 
            this.hostHeader.AutoSize = true;
            this.hostHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostHeader.Location = new System.Drawing.Point(620, 57);
            this.hostHeader.Name = "hostHeader";
            this.hostHeader.Size = new System.Drawing.Size(169, 20);
            this.hostHeader.TabIndex = 6;
            this.hostHeader.Text = "Your PhantomBot host";
            // 
            // HostInfoLabel
            // 
            this.HostInfoLabel.AutoSize = true;
            this.HostInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostInfoLabel.Location = new System.Drawing.Point(535, 86);
            this.HostInfoLabel.Name = "HostInfoLabel";
            this.HostInfoLabel.Size = new System.Drawing.Size(254, 34);
            this.HostInfoLabel.TabIndex = 7;
            this.HostInfoLabel.Text = "The webpage your controlpanel is located\r\nwithout the path (only the host)";
            this.HostInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(485, 165);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(304, 20);
            this.host.TabIndex = 8;
            // 
            // hostExapmlesLabel
            // 
            this.hostExapmlesLabel.AutoSize = true;
            this.hostExapmlesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostExapmlesLabel.Location = new System.Drawing.Point(488, 126);
            this.hostExapmlesLabel.Name = "hostExapmlesLabel";
            this.hostExapmlesLabel.Size = new System.Drawing.Size(301, 34);
            this.hostExapmlesLabel.TabIndex = 9;
            this.hostExapmlesLabel.Text = "Examples:\r\nhttp://127.0.0.1:25000 , https://example.com:25000";
            this.hostExapmlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // songHeader
            // 
            this.songHeader.AutoSize = true;
            this.songHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songHeader.Location = new System.Drawing.Point(13, 220);
            this.songHeader.Name = "songHeader";
            this.songHeader.Size = new System.Drawing.Size(158, 20);
            this.songHeader.TabIndex = 10;
            this.songHeader.Text = "Current Song options";
            // 
            // songOutputLabel
            // 
            this.songOutputLabel.AutoSize = true;
            this.songOutputLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songOutputLabel.Location = new System.Drawing.Point(14, 247);
            this.songOutputLabel.Name = "songOutputLabel";
            this.songOutputLabel.Size = new System.Drawing.Size(99, 17);
            this.songOutputLabel.TabIndex = 11;
            this.songOutputLabel.Text = "Output file path";
            // 
            // songOutputPre
            // 
            this.songOutputPre.AutoSize = true;
            this.songOutputPre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songOutputPre.Location = new System.Drawing.Point(14, 269);
            this.songOutputPre.Name = "songOutputPre";
            this.songOutputPre.Size = new System.Drawing.Size(102, 17);
            this.songOutputPre.TabIndex = 12;
            this.songOutputPre.Text = "File output path:";
            // 
            // songPath
            // 
            this.songPath.AutoSize = true;
            this.songPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPath.Location = new System.Drawing.Point(112, 269);
            this.songPath.Name = "songPath";
            this.songPath.Size = new System.Drawing.Size(45, 17);
            this.songPath.TabIndex = 13;
            this.songPath.Text = "(none)";
            // 
            // songButtonPath
            // 
            this.songButtonPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songButtonPath.Location = new System.Drawing.Point(17, 293);
            this.songButtonPath.Name = "songButtonPath";
            this.songButtonPath.Size = new System.Drawing.Size(304, 23);
            this.songButtonPath.TabIndex = 15;
            this.songButtonPath.Text = "Select";
            this.songButtonPath.UseVisualStyleBackColor = true;
            this.songButtonPath.Click += new System.EventHandler(this.SongButtonPath_Click);
            // 
            // songFormat
            // 
            this.songFormat.Location = new System.Drawing.Point(17, 348);
            this.songFormat.Name = "songFormat";
            this.songFormat.Size = new System.Drawing.Size(304, 20);
            this.songFormat.TabIndex = 17;
            this.songFormat.Text = "%SONG%";
            // 
            // songFormatLabel
            // 
            this.songFormatLabel.AutoSize = true;
            this.songFormatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songFormatLabel.Location = new System.Drawing.Point(14, 326);
            this.songFormatLabel.Name = "songFormatLabel";
            this.songFormatLabel.Size = new System.Drawing.Size(123, 17);
            this.songFormatLabel.TabIndex = 16;
            this.songFormatLabel.Text = "Song output format";
            // 
            // settingsPicture
            // 
            this.settingsPicture.Image = global::PB_MusicPlayer.Properties.Resources.settings;
            this.settingsPicture.Location = new System.Drawing.Point(589, 226);
            this.settingsPicture.Name = "settingsPicture";
            this.settingsPicture.Size = new System.Drawing.Size(328, 200);
            this.settingsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPicture.TabIndex = 18;
            this.settingsPicture.TabStop = false;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Green;
            this.save.Location = new System.Drawing.Point(485, 335);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(146, 33);
            this.save.TabIndex = 19;
            this.save.Text = "Save Settings";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save);
            this.Controls.Add(this.settingsPicture);
            this.Controls.Add(this.songFormat);
            this.Controls.Add(this.songFormatLabel);
            this.Controls.Add(this.songButtonPath);
            this.Controls.Add(this.songPath);
            this.Controls.Add(this.songOutputPre);
            this.Controls.Add(this.songOutputLabel);
            this.Controls.Add(this.songHeader);
            this.Controls.Add(this.hostExapmlesLabel);
            this.Controls.Add(this.host);
            this.Controls.Add(this.HostInfoLabel);
            this.Controls.Add(this.hostHeader);
            this.Controls.Add(this.credentialsPassword);
            this.Controls.Add(this.credentialsName);
            this.Controls.Add(this.credentialsPasswordLabel);
            this.Controls.Add(this.credentialsNameLabel);
            this.Controls.Add(this.credentialsHeader);
            this.Controls.Add(this.header);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(804, 382);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label credentialsHeader;
        private System.Windows.Forms.Label credentialsNameLabel;
        private System.Windows.Forms.Label credentialsPasswordLabel;
        private System.Windows.Forms.TextBox credentialsName;
        private System.Windows.Forms.TextBox credentialsPassword;
        private System.Windows.Forms.Label hostHeader;
        private System.Windows.Forms.Label HostInfoLabel;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label hostExapmlesLabel;
        private System.Windows.Forms.Label songHeader;
        private System.Windows.Forms.Label songOutputLabel;
        private System.Windows.Forms.Label songOutputPre;
        private System.Windows.Forms.Label songPath;
        private System.Windows.Forms.Button songButtonPath;
        private System.Windows.Forms.TextBox songFormat;
        private System.Windows.Forms.Label songFormatLabel;
        private System.Windows.Forms.PictureBox settingsPicture;
        private System.Windows.Forms.Button save;
    }
}
