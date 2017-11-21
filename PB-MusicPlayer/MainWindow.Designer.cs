namespace PB_MusicPlayer
{
    partial class MainWindow
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.playerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.joinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.spendItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 382);
            this.panel1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerMenu,
            this.settingsMenu,
            this.version,
            this.joinMenu,
            this.aboutMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.mainMenu.Size = new System.Drawing.Size(804, 29);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // playerMenu
            // 
            this.playerMenu.Image = global::PB_MusicPlayer.Properties.Resources.youtube;
            this.playerMenu.Name = "playerMenu";
            this.playerMenu.Size = new System.Drawing.Size(143, 21);
            this.playerMenu.Text = "PB YouTube Player";
            this.playerMenu.Click += new System.EventHandler(this.PlayerMenu_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.Image = global::PB_MusicPlayer.Properties.Resources.settings;
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(82, 21);
            this.settingsMenu.Text = "Settings";
            this.settingsMenu.Click += new System.EventHandler(this.SettingsMenu_Click);
            // 
            // version
            // 
            this.version.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.version.Enabled = false;
            this.version.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(57, 21);
            this.version.Text = "Version";
            // 
            // joinMenu
            // 
            this.joinMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.joinMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.joinMenu.Image = global::PB_MusicPlayer.Properties.Resources.discord;
            this.joinMenu.Name = "joinMenu";
            this.joinMenu.Size = new System.Drawing.Size(184, 21);
            this.joinMenu.Text = "Join our Discord channel!";
            this.joinMenu.Click += new System.EventHandler(this.JoinMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem,
            this.changelogItem,
            this.aboutSeparator1,
            this.reportItem,
            this.leaveItem,
            this.aboutSeparator2,
            this.spendItem});
            this.aboutMenu.Image = global::PB_MusicPlayer.Properties.Resources.info;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(71, 21);
            this.aboutMenu.Text = "About";
            // 
            // aboutItem
            // 
            this.aboutItem.Image = global::PB_MusicPlayer.Properties.Resources.info;
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(196, 22);
            this.aboutItem.Text = "About the developer";
            this.aboutItem.Click += new System.EventHandler(this.AboutItem_Click);
            // 
            // changelogItem
            // 
            this.changelogItem.Image = global::PB_MusicPlayer.Properties.Resources.list;
            this.changelogItem.Name = "changelogItem";
            this.changelogItem.Size = new System.Drawing.Size(196, 22);
            this.changelogItem.Text = "Changelog";
            this.changelogItem.Click += new System.EventHandler(this.ChangelogItem_Click);
            // 
            // aboutSeparator1
            // 
            this.aboutSeparator1.Name = "aboutSeparator1";
            this.aboutSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // reportItem
            // 
            this.reportItem.Image = global::PB_MusicPlayer.Properties.Resources.bug;
            this.reportItem.Name = "reportItem";
            this.reportItem.Size = new System.Drawing.Size(196, 22);
            this.reportItem.Text = "Report a bug";
            this.reportItem.Click += new System.EventHandler(this.ReportItem_Click);
            // 
            // leaveItem
            // 
            this.leaveItem.Image = global::PB_MusicPlayer.Properties.Resources.comment;
            this.leaveItem.Name = "leaveItem";
            this.leaveItem.Size = new System.Drawing.Size(196, 22);
            this.leaveItem.Text = "Leave a comment";
            this.leaveItem.Click += new System.EventHandler(this.LeaveItem_Click);
            // 
            // aboutSeparator2
            // 
            this.aboutSeparator2.Name = "aboutSeparator2";
            this.aboutSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // spendItem
            // 
            this.spendItem.Image = global::PB_MusicPlayer.Properties.Resources.donate;
            this.spendItem.Name = "spendItem";
            this.spendItem.Size = new System.Drawing.Size(196, 22);
            this.spendItem.Text = "Spend a coffee";
            this.spendItem.Click += new System.EventHandler(this.SpendItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "Music Player for PhantomBot";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem playerMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem version;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem changelogItem;
        private System.Windows.Forms.ToolStripSeparator aboutSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportItem;
        private System.Windows.Forms.ToolStripMenuItem leaveItem;
        private System.Windows.Forms.ToolStripSeparator aboutSeparator2;
        private System.Windows.Forms.ToolStripMenuItem spendItem;
        private System.Windows.Forms.ToolStripMenuItem joinMenu;
    }
}

