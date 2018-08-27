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

        private static FacebookAppSettings s_Instance = null;

        private static object s_Lock = new object();

        private FacebookAppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            ComboBoxWebBrowserItems = new List<string>();
        }

        public static FacebookAppSettings LoadFromFile()
        {
            if (s_Instance == null)
            {
                lock (s_Lock)
                {
                    if (s_Instance == null)
                    {
                        try
                        {
                            s_Instance = FileUtils.LoadFromFile<FacebookAppSettings>(r_SettingsFilePath);
                        }
                        catch
                        {
                            s_Instance = new FacebookAppSettings();
                        }
                    }
                }
            }

            return s_Instance;
        }

        public void SaveToFile()
        {
            FileUtils.SaveToFile<FacebookAppSettings>(this, r_SettingsFilePath);
        }

        public void DeleteFile()
        {
            FileUtils.DeleteFile(r_SettingsFilePath);
            s_Instance = null;
        }
    }
}
