using System.Text.Json;
using System.Text.Json.Serialization;

namespace GeneradorAWS.Configuration
{
    public static class ConfigManager
    {
        /// <summary>
        /// Path al archivo de configuracion.
        /// </summary>
        private static string PathToConfig
        {
            get
            {
                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

                string pathToConfig = Path.Combine(strWorkPath, "ConfigDB.json");
                return pathToConfig;
            }            
        }

        /// <summary>
        /// Lee desde el archivo de configuracion.
        /// </summary>
        /// <returns></returns>
        public static ConfigData Load()
        {
            string path = PathToConfig;
            string json = File.ReadAllText(path);

            ConfigData? configData = JsonSerializer.Deserialize<ConfigData>(json);

            return configData;
        }

        /// <summary>
        /// Graba la configuracion en el archivo.
        /// </summary>
        /// <param name="configData"></param>
        public static void Save(ConfigData configData)
        {
            string path = PathToConfig;
            string json = File.ReadAllText(path);

            string jsonData = JsonSerializer.Serialize(configData);
            File.WriteAllText(path, jsonData);
        }
    }
}
