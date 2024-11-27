using IniParser;
using IniParser.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HalleyImport.JMM
{
    public partial class frmProfili : Form
    {
        // Init components, reset form position, load default config 
        public frmProfili(MysqlObject mysqlObject)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(390, 240);

            // Retreive default config from main form
            pr_tb_name.Text = mysqlObject.Database;
            pr_tb_ip.Text = mysqlObject.Server;
            pr_tb_port.Text = mysqlObject.Port;
            pr_tb_user.Text = mysqlObject.UserID;
            pr_tb_pwd.Text = mysqlObject.Password;

            // Load all Mysql Profiles
            LoadMysqlProfiles();
        }

        // Use the current profile selected
        private void pr_btn_use_Click(object sender, EventArgs e)
        {
            // DB Name 
            pr_tb_name.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            // DB Ip
            pr_tb_ip.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            // DB Port
            pr_tb_port.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            // DB User
            pr_tb_user.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            // DB Password
            pr_tb_pwd.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

            // Update local DAFULT.ini file. It is used to load the last config used
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            string profile = Path.GetFileNameWithoutExtension("DEFAULT.ini");

            data[profile]["Database"] = pr_tb_name.Text;
            data[profile]["Server"] = pr_tb_ip.Text;
            data[profile]["Port"] = pr_tb_port.Text;
            data[profile]["UserID"] = pr_tb_user.Text;
            data[profile]["Password"] = pr_tb_pwd.Text;
            parser.WriteFile(Path.Combine(Directory.GetCurrentDirectory(), $@"DEFAULT.ini"), data);
            this.Hide();
        }

        // Used to catch the datagridview click 
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // DB Name 
            pr_tb_name.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            // DB Ip
            pr_tb_ip.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            // DB Port
            pr_tb_port.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            // DB User
            pr_tb_user.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            // DB Password
            pr_tb_pwd.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
        }

        // Used to load the profiles
        private void InsertInDataGrid(string _name, string _ip, string _port, string _user, string _pwd)
        {
            dataGridView1.Rows.Add(_name, _ip, _port, _user, _pwd);
        }

        // Load Datagridview with all the existing profiles
        public void LoadMysqlProfiles()
        {
            MysqlObject mysqlObject = new MysqlObject();
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "config"));
            dataGridView1.Rows.Clear();
            foreach (FileInfo f in di.GetFiles())
            {
                mysqlObject = MysqlObject.LoadMysqlConfiguration(f.Name, true);
                InsertInDataGrid(mysqlObject.Database, mysqlObject.Server, mysqlObject.Port, mysqlObject.UserID, mysqlObject.Password);
            }
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
            try
            {
                parser.WriteFile(Path.Combine(Directory.GetCurrentDirectory(), $@"config\{nameWithExtention}"), data);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Unable to save profile!\n\n{e.Message}");
            }
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            // Se vero, un duplicato è stato trovato, quindi bisogna aggiornarlo
            AddOrUpdateLocalProfile($"{pr_tb_name.Text}.ini");
            LoadMysqlProfiles();
        }
    }
}
