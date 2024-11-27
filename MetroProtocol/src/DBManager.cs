using IniParser;
using IniParser.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Converx.src
{
    public class DBManager
    {
        /// <summary>
        /// Propietà base delle connessioni SQL
        /// </summary>
        public static string ip = "localhost";
        public static string port = "3306";
        public static string user = "root";
        public static string password = "";
        public static string database = "information_schema"; // Deve combaciare con il nome del database remoto

        public static string databaseType = ""; // Mysql, Postgres, Oracle

        public static string gestionale = "Default";

        // Oracle TSN
        public static string DataSource = ""; 


        /// <summary>
        /// Reader generico, viene utilizzato dalle funzioni di deserializzazione per la lettuera dei record del DB
        /// </summary>
        public static IDataReader reader = null;

        /// <summary>
        /// General String Connection
        /// </summary>
        public static DbConnection connection = default(DbConnection);

        /// <summary>
        /// Funzione utilizzata per la generazione dinamica delle classi
        /// </summary>
        public static string getNamespace()
        {
            return ($"Converx.Comuni.{DBManager.databaseType}.{DBManager.gestionale}.{DBManager.database}");
        }

        /// <summary>
        /// Verifica la connessione prima dell'apertuara del MainForm (frmMain)
        /// </summary>
        /// <returns></returns>
        public static bool TestSqlConnection()
        {
            try
            {
                // Open the connection
                DBManager.connection.Open();
                Console.WriteLine("SQL connection opened.");

                DBManager.connection.Close();
                Console.WriteLine("SQL connection closed.");
                return true;
            }
            catch (MySqlException ex)
            {
                // Catch exception 
                DBManager.connection.Close();
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Fatal Error: {ex}", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Recupera la configurazione SQL e aggiorna i connettori
        /// </summary>
        /// <param name="profile"></param>
        /// <param name="ProfileFolder"></param>
        public static void LoadSQLConfiguration(string profile, bool ProfileFolder = true)
        {
            var parser = new FileIniDataParser();
            IniData data;

            try
            {
                data = parser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), $@"config\{profile}.ini"));
                DBManager.database = data[profile]["Database"].Trim();
                DBManager.ip = data[profile]["Server"].Trim();
                DBManager.port = data[profile]["Port"].Trim();
                DBManager.user = data[profile]["UserID"].Trim();
                DBManager.password = data[profile]["Password"].Trim();
                DBManager.databaseType = data[profile]["DatabaseType"].Trim();
                DBManager.gestionale = data[profile]["Gestionale"].Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to retreive configuration!\n\nProfile:{profile}\nProfileFolder:{ProfileFolder}\n\n{ex}");
            }
        }

        /// <summary>
        /// Ritorna il dato letto dal database. Tutti i record sono convertiti a stringa per evitare eccezioni
        /// </summary>
        /// <param name="reader">rappresenta il record attuale</param>
        /// <param name="dbColIndx">rappresenta la colonna del record in esame (reader)</param>
        /// <returns></returns>
        public static string getValFromDB(IDataReader reader, int dbColIndx)
        {
            try
            {
                if (!reader.IsDBNull(dbColIndx))
                    return reader.GetValue(dbColIndx).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n\n {ex.Message}");
            }
            return "";
        }

        /// <summary>
        ///  Esegue qualunque tipo di query, funziona con tutte le tipologie di connessione SQL
        /// </summary>
        /// <param name="query">query to execute</param>
        /// <returns></returns>
        public static void ExecuteQuery(string query)
        {
            DbCommand command = DBManager.connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 2147483;
            reader = command.ExecuteReader();
        }

        /// <summary>
        /// Funzione di deserializzazione dei record 
        /// </summary>
        /// <returns></returns>
        public static string[] Next()
        {
            if (reader == null)
            {
                MessageBox.Show("ERRORE nella funzione DBManager.Next");
                throw new Exception();
            }

            string[] line = new string[reader.FieldCount];

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    line[i] = getValFromDB(reader, i).ToString();
                    //line[i] = getValFromDB(reader, i);
                }
            }
            else
            {
                return null;
            }
            return line;
        }
    }
}
