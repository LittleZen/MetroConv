using EnvDTE;
using MetroFramework;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Converx.FRM.Wizard
{
    public partial class frmWizard : MetroFramework.Forms.MetroForm
    {
        public static string ip = "localhost";
        public static string port = "3306";
        public static string user = "root";
        public static string password = "";
        public static string database = "information_schema"; // DEVE COMBACIARE CON IL NOME DEL DATABASE REMOTO

        public static string databaseType = ""; // Mysql, Postgres, Oracle

        public static string gestionale = "Halley"; // [DA FINIRE] Maggioli, Halley

        // Oracle TSN
        public static string DataSource = ""; // [TO_FINISH]

        public static string contesto = ""; // Contesto del tracciato (protocollo, atti, albo ...)

        public frmWizard()
        {
            this.ControlBox = false;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Hide();
        }

        // Create configuration, create ini file for config, create Visual Studio Assembly reference ... 
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string pathx = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"../../App.config");

            // Get a reference to the current instance of Visual Studio
            DTE dte = (DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");

            // Get a reference to the solution object
            Solution solution = (Solution)dte.Solution;

            // Get a reference to the project you want to add the folder to
            Project project = solution.Projects.Item(1); // Replace 1 with the index or name of your project

            string parentFolder = Directory.GetParent(Assembly.GetEntryAssembly().Location).Parent.Parent.FullName;
            string concatFolder = $@"Comuni\MySQL\Halley\Mucca";

            string localFolder = Path.Combine(parentFolder, concatFolder);

            if (!Directory.Exists(localFolder))
            {
                try
                {
                    Directory.CreateDirectory(localFolder); // local folder

                    // Manually add each subfolder to the project's ProjectItems hierarchy
                    string[] subfolders = concatFolder.Split('\\');
                    ProjectItems projectItems = project.ProjectItems;
                    string folderPath = parentFolder;
                    foreach (string subfolder in subfolders)
                    {
                        folderPath = Path.Combine(folderPath, subfolder);
                        /*
                            if (!Directory.Exists(folderPath)) 
                            {
                                ProjectItem subfolderItem = projectItems.AddFolder(subfolder);
                                projectItems = subfolderItem.ProjectItems;
                            }
                        */
                        // Check if the subfolder already exists before adding
                        if (projectItems.Item(subfolder) == null)
                        {
                            ProjectItem subfolderItem = projectItems.AddFolder(subfolder);
                            projectItems = subfolderItem.ProjectItems;
                        }
                    }

                    // Invoke the refresh button macros
                    dte.Commands.Raise("{1496A755-94DE-11D0-8C3F-00C04FC2AAE2}", 222, null, null);

                    //UIHierarchy solutionExplorer = dte.ToolWindows.SolutionExplorer;
                    //solutionExplorer.DoDefaultAction();

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"\nErrore nella generazione delle cartelle\n\nERROR: {ex}\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MetroMessageBox.Show(this, $"\nCreazione comune completata!\n\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
