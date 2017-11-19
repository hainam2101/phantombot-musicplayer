using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PB_MusicPlayer
{
    public partial class Settings : UserControl
    {
        private RegistryHandler Registry;

        /*
         * Start actions when component is started
         */
        public Settings()
        {
            // Init Registry handler
            Registry = new RegistryHandler();
            // Set form and componnents
            InitializeComponent();
        }

        /*
         * Function to delect output directory
         */
        private void SongButtonPath_Click(object sender, EventArgs e)
        {
            // Open directorx file dialog
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // Display path in settings
                songPath.Text = dialog.FileName;
            }
        }

        /*
         * Save settings to Registry
         */
        private void Save_Click(object sender, EventArgs e)
        {
            /*
             * Save Directory to Registry
             */
            if (Directory.Exists(songPath.Text))
            {
                Registry.Write("songPath", songPath.Text);
            } else
            {
                ShowErrorMessage("The current song file output is not valid!");
            }

            /*
             * Save song format to Registry
             */
            Regex r = new Regex(@"^.*%SONG%.*$", RegexOptions.IgnoreCase);
            if (r.IsMatch(songFormat.Text))
            {
                Registry.Write("songFormat", songFormat.Text);
            } else
            {
                ShowErrorMessage("The current song output does not contain the %SONG% !");
            }

            /*
             * Save credential username to Registry
             */
            if (!String.IsNullOrEmpty(credentialsName.Text))
            {
                Registry.Write("credentialsName", credentialsName.Text);
            } else
            {
                ShowErrorMessage("The credentials username could not be empty!");
            }

            /*
             * Save credential password to Registry
             */
            if (!String.IsNullOrEmpty(credentialsPassword.Text))
            {
                Registry.Write("credentialsPassword", credentialsPassword.Text);
            }
            else
            {
                ShowErrorMessage("The credentials password could not be empty!");
            }

            /*
             * Save host to Registry
             */
            Regex r1 = new Regex(@"^(https?://)(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])(:[0-9]*)*$", RegexOptions.IgnoreCase);
            Regex r2 = new Regex(@"^(https?://)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])(:[0-9]*)*$", RegexOptions.IgnoreCase);
            if (r1.IsMatch(host.Text))
            {
                Registry.Write("host", host.Text);
            }
            else if (r2.IsMatch(host.Text))
            {
                Registry.Write("host", host.Text);
                
            } else
            {
                ShowErrorMessage("The entered host does not match the requirements.");
            }

            MessageBox.Show("Settings was successfully saved!", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /*
         * Method to send message
         */
        private void ShowErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Could not save settings!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
         * Load settings from Registry to panel
         */
        private void Settings_Load(object sender, EventArgs e)
        {
            if(Registry.Read("songPath") != null)
            {
                songPath.Text = Registry.Read("songPath");
            }

            if (Registry.Read("songFormat") != null)
            {
                songFormat.Text = Registry.Read("songFormat");
            }

            if (Registry.Read("credentialsName") != null)
            {
                credentialsName.Text = Registry.Read("credentialsName");
            }

            if (Registry.Read("credentialsPassword") != null)
            {
                credentialsPassword.Text = Registry.Read("credentialsPassword");
            }

            if (Registry.Read("host") != null)
            {
                host.Text = Registry.Read("host");
            }
        }
    }
}
