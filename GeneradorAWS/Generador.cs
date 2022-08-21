using DatabaseSchemaReader;
using DatabaseSchemaReader.DataSchema;
using GeneradorAWS.Configuration;
using MySql.Data.MySqlClient;
using RazorLight;
using System;
using System.Threading.Tasks;

namespace GeneradorAWS
{
    public class Generador
    {               
        public static async Task<string> Generar(string viewFile, DatabaseTable table)
        {
            string result = "";
            //https://github.com/toddams/RazorLight/issues/287

            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(ConfigManager.PathToViews)
                .UseMemoryCachingProvider()
                .Build();

            result = await engine.CompileRenderAsync(viewFile, table);

            return result;
        }

        public static async Task<string> Generar(string viewFile, List<DatabaseTable> tables)
        {
            string result = "";
            //https://github.com/toddams/RazorLight/issues/287

            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(ConfigManager.PathToViews)
                .UseMemoryCachingProvider()
                .Build();

            result = await engine.CompileRenderAsync(viewFile, tables);

            return result;
        }

        public static async Task<string> Generar(string viewFile)
        {
            string path = Path.Combine(ConfigManager.PathToViews, viewFile);
            string result = await File.ReadAllTextAsync(path);
            return result;
        }
    }
}
