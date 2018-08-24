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

        public static void DeleteFile()
        {
            FileUtils.DeleteFile(r_SettingsFilePath);
        }





        //public static FacebookAppSettings LoadFromFile()
        //{
        //    FacebookAppSettings settings = null;
        //    StreamReader fileToLoad = null;
        //    try
        //    {
        //        fileToLoad = File.OpenText(r_SettingsFilePath);
        //        JsonSerializer serializer = new JsonSerializer();
        //        settings = (FacebookAppSettings)serializer.Deserialize(fileToLoad, typeof(FacebookAppSettings));
        //    }
        //    catch
        //    {
        //        settings = new FacebookAppSettings();
        //    }

        //    return settings; 
        //}

        //public static void DeleteFile()
        //{
        //    File.Delete(r_SettingsFilePath);
        //}

        //public void SaveToFile()
        //{
        //    using (FileStream fileToSave = File.Open(r_SettingsFilePath, FileMode.Create, FileAccess.Write))
        //    using (StreamWriter writer = new StreamWriter(fileToSave))
        //    {
        //        JsonSerializer serializer = new JsonSerializer();
        //        serializer.Formatting = Formatting.Indented;
        //        serializer.Serialize(writer, this);
        //    }
        //}
    }
}
