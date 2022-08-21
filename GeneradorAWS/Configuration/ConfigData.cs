namespace GeneradorAWS.Configuration
{
    /// <summary>
    /// Representacion en objetos de la configuracion.
    /// </summary>
    public class ConfigData
    {
        public string ConnectionString { get; set; }

        /// <summary>
        /// Nombre de la solución que agrupa los proyectos generados.
        /// </summary>
        public string SolutionName { get; set; }

        /// <summary>
        /// Directorio en el que se escriben los archivos generados.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// Nombre de la base de datos.
        /// </summary>
        /// <remarks>
        /// El nombre de la base de datos se extrae del ConnectionString.
        /// </remarks>
        public string Database
        {
            get
            {
                const string DATABASE = "database";
                //"ConnectionString": "server=database-horacio.cluster-cd1b3rbisqnk.us-east-1.rds.amazonaws.com; database = UsuariosDB; uid = MiUsuario; pwd = MiClave",
                string[] partes = ConnectionString.Split(';');
                string dbName = partes.Where(p => p.ToLower().Trim().StartsWith(DATABASE)).First();
                dbName = dbName.Split("=")[1].Trim();
                return dbName;
            }
        }
    }
}
