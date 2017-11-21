using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Web;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PB_MusicPlayer
{
    public partial class MainWindow : Form
    {
        private RegistryHandler Registry;
        public ChromiumWebBrowser chromeBrowser;
        // Domain for internal requests
        public string baseDomain = "https://phantombot-musicplayer.marceldeglau.de/";
        // Internal variable of verson
        public string softwareVersion = Application.ProductVersion;
        // Variable timer for checking song detection
        private System.Timers.Timer detectionTimer;
        // Variable for active song detection
        private bool songDetection = false;
        // Variable for browser is ready
        private bool browserReady = false;

        /*
         * Start actions when program is started
         */
        public MainWindow()
        {
            // Init Registry handler
            Registry = new RegistryHandler();
            // Set form and componnents
            InitializeComponent();
            // Apply program version
            version.Text = "Version " + softwareVersion;
            // Initialize Chromium webbrowswer
            InitializeChromium();
        }

        /*
         * Initialize Chromium webbrowswer
         */
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        /*
         * Execute when windows is loaded done
         */
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Start embeded player
            OpenPlayer();
            // Check programs current version (backgound)
            Task task = Task.Run((Action)CheckAppVersion);
        }

        /*
         * Do when window should closed
         */
        private void MainWindow_Close(object sender, FormClosedEventArgs e)
        {
            // Check if is a timer running
            if (detectionTimer != null)
            {
                detectionTimer.Stop();
            }
            Cef.Shutdown();
        }

        /*
         * Open player panel / frame
         */
        private void OpenPlayer()
        {
            // Set browserReady to false
            browserReady = false;
            // If the app is not configured
            if (Registry.ValueCount() != 5)
            {
                chromeBrowser = new ChromiumWebBrowser();
                chromeBrowser.LoadHtml(PB_MusicPlayer.Properties.Resources.not_configured_page);
            }
            // When the app is configured
            else
            {
                // Get credentials and parse them into the host
                string str = Registry.Read("host");
                string[] splitchar = new string[] { "://" };
                string[] strArr = str.Split(splitchar, StringSplitOptions.None);
                chromeBrowser = new ChromiumWebBrowser(strArr[0] + "://" + Registry.Read("credentialsName") + ":" + Registry.Read("credentialsPassword") + "@" + strArr[1] + "/ytplayer");
                chromeBrowser.FrameLoadEnd += (sender, args) =>
                {
                    // Wait for the MainFrame to finish loading
                    if (args.Frame.IsMain)
                    {
                        // Call the browser is now ready to talk to it
                        browserReady = true;
                    }
                };
                chromeBrowser.LoadingStateChanged += OnBrowserloadComplete;
            }

            // Apply the frame to panel
            panel1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        /*
         * When you do click on the player menu item
         */
        private void PlayerMenu_Click(object sender, EventArgs e)
        {
            // Clear complete panel
            panel1.Controls.Clear();
            chromeBrowser.Dispose();
            songDetection = false;
            // Check if is a timer running
            if (detectionTimer != null)
            {
                detectionTimer.Stop();
            }
            // Open normal player
            OpenPlayer();
        }

        /*
         * When you do click on the settings menu item
         */
        private void SettingsMenu_Click(object sender, EventArgs e)
        {
            // Clear complete panel
            panel1.Controls.Clear();
            chromeBrowser.Dispose();
            // Check if is a timer running
            if (detectionTimer != null)
            {
                detectionTimer.Stop();
            }
            songDetection = false;
            // Create setting dialog and open it
            Settings settings = new Settings();
            panel1.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
            settings.Show();
        }

        /*
         * When Chromium brower is loaded complete
         */
        private void OnBrowserloadComplete(object sender, LoadingStateChangedEventArgs e)
        {
            // When song detection is not started
            if (songDetection == false)
            {
                // Do start it
                songDetection = true;
                // Runned in backgound 
                Task task = Task.Run((Action)DetectCurrentSong);
            }
        }

        /*
         * Task for freqently song detection
         */
        private void DetectCurrentSong()
        {
            // Start timer for song detection
            detectionTimer = new System.Timers.Timer();
            detectionTimer.Elapsed += new ElapsedEventHandler(GetSong);
            detectionTimer.Interval = 7500;
            detectionTimer.Enabled = true;
        }

        /*
         * Method which is triggerd for song detection
         */
        private void GetSong(object source, ElapsedEventArgs e)
        {
            // Get current song from PhantomBot via JavaScript
            var script = String.Format("$('#currentSong > strong').html();");
            string outputFormat = Registry.Read("songFormat");

            // Check if browser is ready
            if (browserReady == true)
            {
                // Wait on result
                chromeBrowser.EvaluateScriptAsync(script).ContinueWith(x =>
                {
                    var response = x.Result;

                    if (response.Success && response.Result != null)
                    {
                        // Format restult to users output
                        outputFormat = outputFormat.Replace("%SONG%", WebUtility.HtmlDecode(response.Result.ToString()));
                        // Write ouptput into file
                        System.IO.File.WriteAllText(@Registry.Read("songPath") + @"\current_song.txt", outputFormat);
                    }
                });
            }

        }

        /*
         * Check version of program
         */
        private void CheckAppVersion()
        {
            // Get current version from webserver
            string webVersion = (new WebClient().DownloadString(baseDomain + "version"));
            webVersion = System.Text.RegularExpressions.Regex.Replace(webVersion, @"\t|\n|\r", "");

            // Is not current version send message for update
            if (webVersion != softwareVersion)
            {
                MessageBox.Show("New version is available now! Your current installed version is " + softwareVersion + ".\r\n\r\nThe new version " + webVersion + " can now be downloaded now, upgrade as soon as possible!", "New version available!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(baseDomain + "download");
            }
        }

        /*
         * Methods for clicking on items
         */
        private void AboutItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "about");
        }
        private void SpendItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "donate");
        }
        private void ChangelogItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "changelog");
        }
        private void ReportItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "bugs");
        }
        private void LeaveItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "comment");
        }
        private void JoinMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(baseDomain + "discord");
        }
    }
}
