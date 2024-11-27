using Converx.Tracciati;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converx.src
{
    internal class Helper
    {
        /// <summary>
        /// Propietà generiche
        /// </summary>
        public static string sep = "\t"; // Costanti utilizzate nei tracciati
        public static string sePipe = "|"; // Utilizzato principalmente per l"estrazione del tracciato seqana
        public static string aCapo = "\n"; // Costanti utilizzate nei tracciati
        public static string converxVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(); // Versione del programma

        // Chunk di generazione, indica quante righe vengono scritte tutte assieme in fase di generazione del tracciato
        public static int Chunk = 1000;

        /// <summary>
        /// Consente di scrivere sulla textbox di riferimento per ogni tracciato. Tale textbox è utilizzata come log system
        /// </summary>
        /// <param name="obj">datagridview di riferimento</param>
        /// <param name="logTowrite">contenuto da scrivere nella datagrid</param>
        public static void WriteLog(MetroFramework.Controls.MetroTextBox obj, string logTowrite)
        {
            obj.AppendText($"[{DateTime.Now.ToString($"dd/MM/yyyy - HH:mm:ss")}]: {logTowrite}\r\n");
        }

        /// <summary>
        /// DEPRECATED, NOT USED, WILL BE REMOVED SOON. NOT USE IT!
        /// </summary>
        /// <param name="obj"></param>
        public static async void Generate(BaseClass obj, bool flag)
        {
            await Task.Run(() =>
            {
                //uffiprot.Generate();
                obj.Generate(flag);
            });
        }

        /// <summary>
        /// Crea una cartella se non esiste nel path passato come parametro
        /// </summary>
        /// <param name="path">path alla cartella</param>
        public static void CreateDirIfNotExist(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        public static string ReturnTracciatoPath(string contesto)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ($"Conversioni\\{DBManager.database}\\{contesto}")); // Si compone di "Desktop\Conversioni\NomedelDB\nomeTracciato\tracciato.txt"
        }

        /// <summary>
        /// Consente di eliminare la configurazione (file ini) di un determinato DB [TO FINISH]
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool RemoveData(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            try
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on delete", $"Unable to delete files from the path given:\n{ex}");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Elimina i caratteri non validi
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Sanitaizer(string p)
        {
            if (p != null || p != "")
            {
                return p.Replace("\r", "")
                        .Replace("\n", "")
                        .Replace("\t", " ")
                        .Replace("{", "")
                        .Replace("}", "")
                        .Replace("€", "euro")
                        .Replace("°", "")
                        .Replace("–", "")
                        .Replace("’", "\"")
                        .Replace("`", "")
                        .Replace("&#8220;", "<") 
                        .Replace("&#8221;", ">") 
                        .Replace("&#8364;", "euro") 
                        .Replace("ì", "i")
                        .Replace("(", "")
                        .Replace(")", "")
                        .Replace("?", "")
                        .Replace("2.B", "2B")
                        .Replace(";", "")
                        .Replace(",", "")
                        .Replace("à", "a")
                        .Replace("è", "e")
                        .Replace("é", "e")
                        .Replace("ò", "o")
                        .Replace("ù", "u")
                        .Replace("è", "e")
                        .Replace("ì", "i")
                        .Replace("'", " ")
                        .Replace("[", "")
                        .Replace("\\", "")
                        .Replace("]", "")
                        .Replace("Ò", "O")
                        .Replace("È", "E")
                        .Replace("À", "A")
                        .Replace("Ù", "U")
                        .Replace("Ì", "I")
                        .Replace("<non presente>", " ")   
                        .Replace("<NON PRESENTE>", " ")   
                        .Replace("<non selezionata>", " ")
                        .Replace("<NON SELEZIONATA>", " ")
                        .Replace(" -   - ", " - ")
                        .Replace(" -  ", "")
                        .Replace("      ", "")
                        .Replace("   -", " - ");
            }
            return "";
        }
    }
}
