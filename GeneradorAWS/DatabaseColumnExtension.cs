namespace DatabaseSchemaReader.DataSchema
{
    public static class DatabaseColumnExtension
    {
        public static string ConvertTo(this DatabaseColumn column)
        {
            string name = column.NetDataType().ToString();
            name = name.Replace("System.", "");
            name = "Convert.To" + name;
            return name;
        }
    }
}
