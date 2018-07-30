using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
namespace Ex01.FacebookApp
{
    public class FacebookSettings
    {
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public Size LastWindowSize { get; set; }

        private FacebookSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            LastWindowSize = new Size(1395, 564);
        }

        public void saveToFile()
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

            using (FileStream fileToSave = File.Open(@"FacebookSettings.json", FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileToSave))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, this);
            }
        }

        public static FacebookSettings LoadFromFile()
        {
            FacebookSettings settings = null;
            StreamReader fileToLoad = null;
            try
            {
                fileToLoad = File.OpenText(@"FacebookSettings.json");
                JsonSerializer serializer = new JsonSerializer();
                settings = (FacebookSettings)serializer.Deserialize(fileToLoad, typeof(FacebookSettings));

            }
            catch
            {
                settings = new FacebookSettings();
            }
            return settings; 
        }
    }
}
