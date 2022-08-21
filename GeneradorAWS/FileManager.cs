using GeneradorAWS.Configuration;

namespace GeneradorAWS
{
    /// <summary>
    /// Periste el codigo generado a un archivo en disco.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Directori de salida.        
        /// </summary>
        private static string OutputPath
        {
            get
            {
                ConfigData configData = ConfigManager.Load();
                return configData.OutputPath;
            }
        }

        private static string GetFullPath(string fileName)
        {
            string path = Path.Combine(OutputPath, fileName);
            return path;
        }

        /// <summary>
        /// Elimina el contenido del directorio de salida.
        /// </summary>
        public static void Clean()
        {         
            if(Directory.Exists(OutputPath))
            {
                Directory.Delete(OutputPath, true);                
            }
            Directory.CreateDirectory(OutputPath);
        }

        public static void CraeteDirectory(string path)
        {
            string[] directorios = path.Split('\\');
            string dir = OutputPath;
            for (int i = 0; i < directorios.Length; i++)
            {
                dir = Path.Combine(dir, directorios[i]);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
        }

        /// <summary>
        /// Crea el directorio y el archivo en donde se persiste el código.
        /// </summary>
        /// <param name="fileName">
        /// El formato es: "dirA\dirB\file"
        /// </param>
        /// <param name="codigo"></param>
        public static void Save(string fileName, string codigo)
        {
            string[] directorios = fileName.Split('\\');
            //Quita el archivo (file), dejando solo los directorios.
            directorios = directorios.Take(directorios.Length - 1).ToArray();
            string onlyDirectories = string.Join('\\', directorios);

            CraeteDirectory(onlyDirectories);

            string path = GetFullPath(fileName);
            File.WriteAllText(path, codigo);
        }

        public static void Save(Dictionary<string, string> codigoFilePairs)
        {
            foreach(KeyValuePair<string, string> pair in codigoFilePairs)
            {
                string fileName = pair.Key;
                string codigo = pair.Value;
                Save(fileName, codigo);
            }
        }
    }
}
