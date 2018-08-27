using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Ex01.FacebookAppLogic
{
    public class FacebookAppSettings
    {
        private static readonly string r_SettingsFilePath = @"FacebookSettings.json";

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public List<string> ComboBoxWebBrowserItems { get; set; }

        private FacebookAppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            ComboBoxWebBrowserItems = new List<string>();
        }

        public static FacebookAppSettings LoadFromFile()
        {
            FacebookAppSettings settings;
            try
            {
                settings = FileUtils.LoadFromFile<FacebookAppSettings>(r_SettingsFilePath);
            }
            catch
            {
                settings = new FacebookAppSettings();
            }

            return settings;
        }

        public void SaveToFile()
        {
            FileUtils.SaveToFile<FacebookAppSettings>(this, r_SettingsFilePath);
        }

        public void DeleteFile()
        {
            FileUtils.DeleteFile(r_SettingsFilePath);
        }
    }
}
