using Converx.src;
using HalleyImport.JMM;
using IniParser;
using IniParser.Model;
using MetroFramework;
using MetroProtocol.frm.Main;
using Microsoft.VisualStudio.Shell;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroProtocol
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        // Program Entry Point
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
        }

        public frmLogin()
        {
#if SOLUTION_SYSTEM
// end sezione mia 

            string pathx = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"../../App.config");

            if (File.Exists(pathx)) 
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("NOT Found");
            }

// sezione mia 
            // Get a reference to the current instance of Visual Studio
            DTE dte = (DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");

            // Get a reference to the solution object
            Solution solution = (Solution)dte.Solution;

            // Get a reference to the project you want to add the folder to
            Project project = solution.Projects.Item(1); // Replace 1 with the index or name of your project

            // Add a new folder to the project
            string folderName = @"MetroProtocol\Comuni\MySQL\Halley\TEST";
            string folderPath = project.FullName.Replace(project.Name + ".csproj", "") + folderName;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                project.ProjectItems.AddFromDirectory(folderPath);
            }

#endif
            InitializeComponent();
            LoadConfig();
        }

        private void SaveLastConfig()
        {
            // Update local DAFULT.ini file. It is used to load the last config used
            var parser = new FileIniDataParser();
            IniData data = new IniData();

            data["DEFAULT"]["Database"] = tb_name_db.Text.Trim();
            data["DEFAULT"]["Server"] = tb_ip_db.Text.Trim();
            data["DEFAULT"]["Port"] = tb_port_db.Text.Trim();
            data["DEFAULT"]["UserID"] = tb_user_db.Text.Trim();
            data["DEFAULT"]["Password"] = tb_pass_db.Text.Trim();
            data["DEFAULT"]["DatabaseType"] = cb_sql_type.Text.Trim();
            data["DEFAULT"]["Gestionale"] = tb_gestionale_db.Text.Trim();

            parser.WriteFile(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), $@"config\DEFAULT.ini"), data);
        }
        public void LoadConfig()
        {
            // Read the last config used or load the default one
            DBManager.LoadSQLConfiguration("DEFAULT", true);

            // Load initial default database connection
            this.tb_name_db.Text = DBManager.database.Trim();
            this.tb_ip_db.Text = DBManager.ip.Trim();
            this.tb_port_db.Text = DBManager.port.Trim();
            this.tb_user_db.Text = DBManager.user.Trim();
            this.tb_pass_db.Text = DBManager.password.Trim();
            this.cb_sql_type.Text = DBManager.databaseType.Trim();
            this.tb_gestionale_db.Text = DBManager.gestionale.Trim();
        }

        public void UpdateDBConfiguration()
        {
            DBManager.database = this.tb_name_db.Text.Trim();
            DBManager.ip = this.tb_ip_db.Text.Trim();
            DBManager.port = this.tb_port_db.Text.Trim();
            DBManager.user = this.tb_user_db.Text.Trim();
            DBManager.password = this.tb_pass_db.Text.Trim();
            DBManager.DataSource = this.tb_datasource_db.Text.Trim();
            DBManager.databaseType = this.cb_sql_type.Text.Trim();
            DBManager.gestionale = this.tb_gestionale_db.Text.Trim();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmProfili frmProfile = new frmProfili();

            if (frmProfile.ShowDialog() == DialogResult.OK)
            {
                tb_name_db.Text = frmProfile.pr_tb_name.Text.Trim();
                tb_ip_db.Text = frmProfile.pr_tb_ip.Text.Trim();
                tb_port_db.Text = frmProfile.pr_tb_port.Text.Trim();
                tb_user_db.Text = frmProfile.pr_tb_user.Text.Trim();
                tb_pass_db.Text = frmProfile.pr_tb_pwd.Text.Trim();
                cb_sql_type.Text = frmProfile.pr_tb_datatype.Text.Trim();
                tb_gestionale_db.Text = frmProfile.pr_tb_gestionale.Text.Trim();
            }
            else
            {
                tb_name_db.Text = DBManager.database.Trim();
                tb_ip_db.Text = DBManager.ip.Trim();
                tb_port_db.Text = DBManager.port.Trim();
                tb_user_db.Text = DBManager.user.Trim();
                tb_pass_db.Text = DBManager.password.Trim();
                cb_sql_type.Text = DBManager.databaseType.Trim();
                tb_gestionale_db.Text = DBManager.gestionale.Trim();
            }
        }

        private async void btn_connect_Click(object sender, EventArgs e)
        {
            // Create a MySQL connection object
            frmMain frmDashboard = new frmMain();
            spinnerLoading.Visible = true;

            if (cb_sql_type.Text == "")
            {
                MetroMessageBox.Show(this, "\nDevi selezionare almeno una tipologia di connessione SQL\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#region CONNECTION_SWITCH 
            if (cb_sql_type.Text.Trim().ToLower() == "mysql")
            {
                // Update the database configuration
                UpdateDBConfiguration();

                // Mysql Connection String
                DBManager.connection = new MySqlConnection($"server={tb_ip_db.Text.Trim()};port={tb_port_db.Text.Trim()};database={tb_name_db.Text.Trim()};uid={tb_user_db.Text.Trim()};password={tb_pass_db.Text.Trim()};Connect Timeout=2147483;SslMode=None;");

                // Check Sql Connection
                try
                {
                    Debug.Write("Loading MYSQL configuration...");
                    await Task.Run(() =>
                    {
                        if (!DBManager.TestSqlConnection())
                        {
                            MetroMessageBox.Show(this, "\nErrore di connessione\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DBManager.connection.Open();
                        DBManager.connection.Close();
                        Debug.WriteLine("Loaded!");
                    });
                    SaveLastConfig();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"\nERRORE: \n\n {ex.Message}\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cb_sql_type.Text.Trim().ToLower() == "postgres")
            {
                // Update the database configuration
                UpdateDBConfiguration();

                // Postgres Connection String
                DBManager.connection = new NpgsqlConnection($"Host={tb_ip_db.Text.Trim()};Port={tb_port_db.Text.Trim()};Database={tb_name_db.Text.Trim()};User Id={tb_user_db.Text.Trim()};Password={tb_pass_db.Text.Trim()};");

                // Check Sql Connection
                try
                {
                    await Task.Run(() =>
                    {
                        if (!DBManager.TestSqlConnection())
                        {
                            MetroMessageBox.Show(this, "\nErrore di connessione\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DBManager.connection.Open();
                        DBManager.connection.Close();
                        Debug.WriteLine("Loaded!");
                    });
                    SaveLastConfig();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"\nERRORE: \n\n {ex.Message}\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cb_sql_type.Text.Trim().ToLower() == "oracle")
            {
                // Update the database configuration details
                UpdateDBConfiguration();

                // Oracle connection string
                DBManager.connection = new OracleConnection($"Data Source={tb_ip_db.Text.Trim()}:{tb_port_db.Text.Trim()}/{tb_datasource_db.Text.Trim()};User Id={tb_user_db.Text.Trim()};Password={tb_pass_db.Text.Trim()};"); // DBA PRIVILEGE=sysdba

                // Check Sql Connection
                try
                {
                    await Task.Run(() =>
                    {
                        if (!DBManager.TestSqlConnection())
                        {
                            MetroMessageBox.Show(this, "\nErrore di connessione\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DBManager.connection.Open();
                        DBManager.connection.Close();
                        Debug.WriteLine("Loaded!");
                    });
                    SaveLastConfig();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"\nERRORE: \n\n {ex.Message}\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                spinnerLoading.Visible = false;
                MetroMessageBox.Show(this, "\nL'attuale tipologia non è ancora supportata\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#endregion
            spinnerLoading.Visible = false;
            Test.ShowBalloonTip(1000);
            this.Hide();
            frmDashboard.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void cb_sql_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sql_type.Text == "Postgres")
            {
                this.tb_datasource_db.Visible = false;
                this.lbl_datasource.Visible = false;

                this.lbl_ip.Visible = true;
                this.tb_ip_db.Visible = true;

                this.lbl_port.Visible = true;
                this.tb_port_db.Visible = true;
            }
            else if (cb_sql_type.Text == "Oracle")
            {
                this.tb_datasource_db.Visible = true;
                this.lbl_datasource.Visible = true;
            }
            else
            {
                this.tb_datasource_db.Visible = false;
                this.lbl_datasource.Visible = false;

                this.lbl_ip.Visible = true;
                this.tb_ip_db.Visible = true;

                this.lbl_port.Visible = true;
                this.tb_port_db.Visible = true;
            }
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
                tb_pass_db.PasswordChar = '\0';
            else
                tb_pass_db.PasswordChar = '•';
        }
    }
}
