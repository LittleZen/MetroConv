using Converx.FRM.Wizard;
using Converx.src;
using IniParser;
using IniParser.Model;
using MetroFramework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HalleyImport.JMM
{
    public partial class frmProfili : MetroFramework.Forms.MetroForm
    {
        // Properties
        public string ip = "localhost";
        public string port = "3306";
        public string user = "root";
        public string password = "";
        public string database = "information_schema"; // DEVE COMBACIARE CON IL NOME DEL DATABASE REMOTO

        public string databaseType = ""; // Mysql, Postgres, Oracle

        public string gestionale = "Halley"; // [DA FINIRE] Maggioli, Halley

        // Oracle TSN
        public string DataSource = ""; // [TO_FINISH]

        // Init components, reset form position, load default config 
        public frmProfili()
        {
            this.ControlBox = false;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            InitializeComponent();

            // Datagrid reset color
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;

            // this.StartPosition = FormStartPosition.Manual;
            // this.Location = new Point(1400, 490); //390 240

            // Retreive default config from main form
            pr_tb_name.Text = DBManager.database.Trim();
            pr_tb_ip.Text = DBManager.ip.Trim();
            pr_tb_port.Text = DBManager.port.Trim();
            pr_tb_user.Text = DBManager.user.Trim();
            pr_tb_pwd.Text = DBManager.password.Trim();
            pr_tb_datasource.Text = DBManager.DataSource.Trim();
            pr_tb_datatype.Text = DBManager.databaseType.Trim();
            pr_tb_gestionale.Text = DBManager.gestionale.Trim();

            // Load all Mysql Profiles
            LoadMysqlProfiles();
        }

        // Used to catch the datagridview click 
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // DB Gestionale
            pr_tb_gestionale.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            // DB DataType 
            pr_tb_datatype.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            // DB Name 
            pr_tb_name.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            // DB Ip
            pr_tb_ip.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            // DB Port
            pr_tb_port.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            // DB User
            pr_tb_user.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            // DB Password
            pr_tb_pwd.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            // DB Datasource (Oracle)
            pr_tb_datasource.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
        }

        // Used to load the profiles
        private void InsertInDataGrid(string _gestionale, string _dbType, string _name, string _ip, string _port, string _user, string _pwd, string _dataSource)
        {
            dataGridView1.Rows.Add(_gestionale, _dbType, _name, _ip, _port, _user, _pwd, _dataSource);

            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        // Load Datagridview with all the existing profiles
        public void LoadMysqlProfiles()
        {
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "config"));
            dataGridView1.Rows.Clear();

            // Tmp config here 
            this.ip = DBManager.ip;
            this.port = DBManager.port;
            this.user = DBManager.user;
            this.password = DBManager.password;
            this.database = DBManager.database;
            this.databaseType = DBManager.databaseType;
            this.gestionale = DBManager.gestionale;
            this.DataSource = DBManager.DataSource;

            foreach (FileInfo f in di.GetFiles())
            {
                if (f.Name != "DEFAULT.ini")
                {
                    DBManager.LoadSQLConfiguration(Path.GetFileNameWithoutExtension(f.Name), false);

                    InsertInDataGrid(DBManager.gestionale,
                                     DBManager.databaseType,
                                     DBManager.database,
                                     DBManager.ip,
                                     DBManager.port,
                                     DBManager.user,
                                     DBManager.password,
                                     DBManager.DataSource);
                }
            }
            // Ordina i gestionali per ordine alfabetico
            dataGridView1.Sort(dataGridView1.Columns["dbType"], ListSortDirection.Ascending);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string dbType = dataGridView1.Rows[row.Index].Cells[1].Value.ToString().ToLower().Trim();

                switch (dbType)
                {
                    case "mysql":
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;

                    case "postgres":
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.DodgerBlue; //DodgerBlue
                        break;

                    case "oracle":
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.IndianRed; //DodgerBlue
                        break;
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        // Add or update local mysql profile 
        public void AddOrUpdateLocalProfile(string nameWithExtention)
        {
            var parser = new FileIniDataParser();

            IniData data = new IniData();
            string profile = Path.GetFileNameWithoutExtension(nameWithExtention);

            data[profile]["Database"] = pr_tb_name.Text;
            data[profile]["Server"] = pr_tb_ip.Text;
            data[profile]["Port"] = pr_tb_port.Text;
            data[profile]["UserID"] = pr_tb_user.Text;
            data[profile]["Password"] = pr_tb_pwd.Text;
            data[profile]["DatabaseType"] = pr_tb_datatype.Text;
            data[profile]["Gestionale"] = pr_tb_gestionale.Text;

            try
            {
                parser.WriteFile(Path.Combine(Directory.GetCurrentDirectory(), $@"config\{nameWithExtention}"), data);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Unable to save profile!\n\n{e.Message}");
            }
        }

        private void btn_add_update_Click_1(object sender, EventArgs e)
        {
            // Crea tracciati 
            AddOrUpdateLocalProfile($"{pr_tb_name.Text}.ini");
            LoadMysqlProfiles();
        }
        private void btn_openConfig_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "config");

                if (Directory.Exists(path))
                {
                    Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nLa cartella delle configurazioni non esiste!\n\n{ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                string file = $"{dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()}.ini";
                File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), $"config\\{file}"));
                LoadMysqlProfiles();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nImpossibile eliminare la seguente configurazione, si prega di procedere con un eliminazione manuale!\n\n{ex}\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWizard frmWizard = new frmWizard();

            if (frmWizard.ShowDialog() == DialogResult.OK)
            {
                // DB Gestionale
                pr_tb_gestionale.Text = frmWizard.gestionale;
                // DB DataType 
                pr_tb_datatype.Text = frmWizard.databaseType;
                // DB Name 
                pr_tb_name.Text = frmWizard.database;
                // DB Ip
                pr_tb_ip.Text = frmWizard.ip;
                // DB Port
                pr_tb_port.Text = frmWizard.port;
                // DB User
                pr_tb_user.Text = frmWizard.user;
                // DB Password
                pr_tb_pwd.Text = frmWizard.password;
                // DB Datasource (Oracle)
                pr_tb_datasource.Text = frmWizard.DataSource;
            }
            else
            {
                this.Show();
            }
        }
    }
}