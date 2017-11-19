using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB_MusicPlayer
{
    /*
     * This Registry handler class is based on the article from Francesco Natali, 17 Dec 2002
     * 
     * Read, write and delete from registry with C#
     * Source: https://www.codeproject.com/Articles/3389/Read-write-and-delete-from-registry-with-C
     */
    class RegistryHandler
    {
        // Set Registry base key
        private static RegistryKey baseRegistryKey = Registry.CurrentUser;
        // Set Registry sub key
        private string subKey = "SOFTWARE\\PeyMedia Studios\\PhantomBot MusicPlayer";

        /*
         * Method to read from Registry
         */
    public string Read(string KeyName)
        {
            RegistryKey rk = baseRegistryKey;
            RegistryKey sk = rk.OpenSubKey(subKey);
            if (sk == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (string)sk.GetValue(KeyName.ToUpper());
                }
                catch (Exception e)
                {
                    ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }
        }

        /*
         * Method to write to Registry
         */
        public bool Write(string KeyName, object Value)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk = rk.CreateSubKey(subKey);
                sk.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }

        /*
         * Method to delete a key from Registry
         */
        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk = rk.CreateSubKey(subKey);
                if (sk == null)
                    return true;
                else
                    sk.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + subKey);
                return false;
            }
        }

        /*
         * Method to count items from Registry
         */
        public int ValueCount()
        {
            try
            {
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk = rk.OpenSubKey(subKey);
                if (sk != null)
                    return sk.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + subKey);
                return 0;
            }
        }

        /*
         * Method to send message
         */
        private void ShowErrorMessage(Exception e, string Title)
        {
                MessageBox.Show(e.Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
