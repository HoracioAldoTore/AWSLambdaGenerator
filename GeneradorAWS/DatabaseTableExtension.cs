using DatabaseSchemaReader.DataSchema;
using System.Runtime.CompilerServices;

namespace DatabaseSchemaReader.DataSchema
{
    public static class DatabaseTableExtension
    {
        /// <summary>
        /// Nombre de la tabla como variable C#.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string NameVar(this DatabaseTable table)
        {
            string name = table.Name.ToLower();
            return name;
        }

        /// <summary>
        /// Nombre de la tabla en plural.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string NamePlural(this DatabaseTable table)
        {
            string name = $"{table.Name.ToLower()}s";
            return name;
        }

        /// <summary>
        /// Nombre de la primary Key para usar como variable.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string PrimaryKeyVar(this DatabaseTable table)
        {            
            string name = table.PrimaryKey.Columns[0].ToLower().Trim();
            return name;
        }

        /// <summary>
        /// Nombre real del campo primary key
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string PrimaryKeyName(this DatabaseTable table)
        {
            string name = table.PrimaryKey.Columns[0];
            return name;
        }

        /// <summary>
        /// Evalúa si la tabla posee todas sus columnas con tipos de datos 
        /// convertibles a C# para poder generar código a partir de ella.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static bool HasNetDataType(this DatabaseTable table)
        {
            bool isValid = !table.Columns.Any(col => col.NetDataType() == null);

            return isValid;
        }
    }
}
