using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSchemaReader;
using GeneradorAWS;
using MySql.Data.MySqlClient;
using GeneradorAWS.Configuration;
using DatabaseSchemaReader.DataSchema;
using MySqlX.XDevAPI;

namespace GeneradorAWS
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonGenerar_Click(object sender, EventArgs e)
		{
			Generar();
		}

		private async void Generar()
		{
			ConfigData configData = ConfigManager.Load();

			Dictionary<string, string> codigoFilePairs = new Dictionary<string, string>();

			MySqlConnection mySqlConnection = new MySqlConnection(configData.ConnectionString);

			//https://github.com/martinjw/dbschemareader/wiki/Overview
			var dbReader = new DatabaseReader(mySqlConnection);
			dbReader.Owner = configData.Database;
			var schema = dbReader.ReadAll();
			string codigo;
			List<DatabaseTable> validTables = GetValidTables(schema.Tables);

			foreach (var table in validTables)
			{
				codigo = await Generador.Generar("Function.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\Function.cs", codigo);

				codigo = await Generador.Generar("ErrorCodes.cshtml");
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\ErrorCodes.cs", codigo);

				codigo = await Generador.Generar("Result.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\Result.cs", codigo);

				codigo = await Generador.Generar("Entity.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\{table.Name}.cs", codigo);

				codigo = await Generador.Generar("aws-lambda-tools-defaults.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\aws-lambda-tools-defaults.json", codigo);

				codigo = await Generador.Generar("project.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\Lambda{table.Name}.csproj", codigo);

				codigo = await Generador.Generar("launchSettings.cshtml", table);
				codigoFilePairs.Add(@$"{configData.SolutionName}\Lambda{table.Name}\Properties\launchSettings.json", codigo);

				//Crea el directorio vacío, sin archivos.
				FileManager.CraeteDirectory(@$"{configData.SolutionName}\Lambda{table.Name}\Properties\PublishProfiles");
			}

			codigo = await Generador.Generar("Solution.cshtml", validTables);
			codigoFilePairs.Add(@$"{configData.SolutionName}\{configData.SolutionName}.sln", codigo);

			FileManager.Clean();
			FileManager.Save(codigoFilePairs);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			//Lee la configuración desde un archivo JSON
			ConfigData configData = ConfigManager.Load();
			textBoxConnectionString.Text = configData.ConnectionString;
			textBoxSolutionName.Text = configData.SolutionName;
			textBoxOutputPath.Text = configData.OutputPath;
		}

		private void linkLabelSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//Persiste la configuración en un archivo JSON
			ConfigData configData = ConfigManager.Load();
			configData.ConnectionString = textBoxConnectionString.Text;
			configData.SolutionName = textBoxSolutionName.Text;
			configData.OutputPath = textBoxOutputPath.Text;

			ConfigManager.Save(configData);
		}

        /// <summary>
        /// Evalúa si la tabla posee la estructura necesaria para poder generar código a partir de ellas.
        /// </summary>
        /// <param name="tables"></param>
        /// <returns>
		/// Retorna las tablas que poseen la estructura necesaria para poder generar código a partir de ellas.
		/// </returns>
        private List<DatabaseTable> GetValidTables(List<DatabaseTable> tables)
		{
            List<DatabaseTable> validTables = tables;
            validTables = validTables.Where(t => t.HasNetDataType()).ToList();
            validTables = validTables.Where(t => t.HasCompositeKey == false).ToList();
            validTables = validTables.Where(t => t.PrimaryKey != null).ToList();
			return validTables;
        }
    }
}
