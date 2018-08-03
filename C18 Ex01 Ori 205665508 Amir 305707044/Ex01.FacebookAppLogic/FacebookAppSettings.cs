using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;

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

        public  void saveToFile()
        {
            //Stream fileStream = null;
            //StreamWriter writer = null;
            //JsonWriter jsonGenerator = null;

            //try
            //{
            //    fileStream = new FileStream(@"FacebookAppSettings.json", FileMode.Truncate);
            //    writer = new StreamWriter(fileStream);
            //    jsonGenerator = new JsonTextWriter(writer);

            //    jsonGenerator.Formatting = Formatting.Indented;

            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(jsonGenerator, this);
            //}
            //finally
            //{
            //    fileStream.Dispose();
            //    writer.Dispose();
            //}

            using (FileStream fileToSave = File.Open(r_SettingsFilePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileToSave))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, this);
            }
        }

        public static FacebookAppSettings LoadFromFile()
        {
            FacebookAppSettings settings = null;
            StreamReader fileToLoad = null;
            try
            {
                fileToLoad = File.OpenText(r_SettingsFilePath);
                JsonSerializer serializer = new JsonSerializer();
                settings = (FacebookAppSettings)serializer.Deserialize(fileToLoad, typeof(FacebookAppSettings));

            }
            catch
            {
                settings = new FacebookAppSettings();
            }
            return settings; 
        }

        public static void DeleteFile()
        {
            File.Delete(r_SettingsFilePath);
        }

    }
}
