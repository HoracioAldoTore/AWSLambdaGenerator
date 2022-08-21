using DatabaseSchemaReader;
using DatabaseSchemaReader.DataSchema;
using MySql.Data.MySqlClient;
using RazorLight;
using System;
using System.Threading.Tasks;

namespace GeneradorAWS
{
    public class Generador
    {       
        const string TEMPLATE_DIR = @"C:\Users\MiUsuario\Downloads\GeneradorAWS\GeneradorAWS\Views";

        public static async Task<string> Generar(string viewFile, DatabaseTable table)
        {
            string result = "";
            //https://github.com/toddams/RazorLight/issues/287

            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(TEMPLATE_DIR)
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
                .UseFileSystemProject(TEMPLATE_DIR)
                .UseMemoryCachingProvider()
                .Build();

            result = await engine.CompileRenderAsync(viewFile, tables);

            return result;
        }

        public static async Task<string> Generar(string viewFile)
        {
            string path = Path.Combine(TEMPLATE_DIR, viewFile);
            string result = await File.ReadAllTextAsync(path);
            return result;
        }
    }
}
