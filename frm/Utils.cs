using System;
using System.IO;
using System.Windows.Forms;

namespace HalleyImport.JMM
{
    internal class Utils
    {
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


    }
}
