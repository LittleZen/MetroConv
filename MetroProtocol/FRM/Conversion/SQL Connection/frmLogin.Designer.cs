namespace MetroProtocol
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tb_name_db = new MetroFramework.Controls.MetroTextBox();
            this.tb_ip_db = new MetroFramework.Controls.MetroTextBox();
            this.tb_port_db = new MetroFramework.Controls.MetroTextBox();
            this.tb_user_db = new MetroFramework.Controls.MetroTextBox();
            this.tb_pass_db = new MetroFramework.Controls.MetroTextBox();
            this.cb_sql_type = new MetroFramework.Controls.MetroComboBox();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_ip = new MetroFramework.Controls.MetroLabel();
            this.lbl_port = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btn_gestoreProfili = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.lbl_datasource = new MetroFramework.Controls.MetroLabel();
            this.tb_datasource_db = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_gestionale_db = new MetroFramework.Controls.MetroTextBox();
            this.lblGestionale = new MetroFramework.Controls.MetroLabel();
            this.cb_showPass = new MetroFramework.Controls.MetroCheckBox();
            this.spinnerLoading = new MetroFramework.Controls.MetroProgressSpinner();
            this.Test = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name_db
            // 
            this.tb_name_db.AccessibleDescription = "";
            this.tb_name_db.AccessibleName = "";
            // 
            // 
            // 
            this.tb_name_db.CustomButton.Image = null;
            this.tb_name_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_name_db.CustomButton.Name = "";
            this.tb_name_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_name_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_name_db.CustomButton.TabIndex = 1;
            this.tb_name_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_name_db.CustomButton.UseSelectable = true;
            this.tb_name_db.CustomButton.Visible = false;
            this.tb_name_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_name_db.Lines = new string[0];
            this.tb_name_db.Location = new System.Drawing.Point(133, 453);
            this.tb_name_db.MaxLength = 32767;
            this.tb_name_db.Name = "tb_name_db";
            this.tb_name_db.PasswordChar = '\0';
            this.tb_name_db.PromptText = "Nome del database remoto";
            this.tb_name_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_name_db.SelectedText = "";
            this.tb_name_db.SelectionLength = 0;
            this.tb_name_db.SelectionStart = 0;
            this.tb_name_db.ShortcutsEnabled = true;
            this.tb_name_db.Size = new System.Drawing.Size(376, 29);
            this.tb_name_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_name_db.TabIndex = 0;
            this.tb_name_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_name_db.UseSelectable = true;
            this.tb_name_db.WaterMark = "Nome del database remoto";
            this.tb_name_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_name_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_ip_db
            // 
            // 
            // 
            // 
            this.tb_ip_db.CustomButton.Image = null;
            this.tb_ip_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_ip_db.CustomButton.Name = "";
            this.tb_ip_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_ip_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ip_db.CustomButton.TabIndex = 1;
            this.tb_ip_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ip_db.CustomButton.UseSelectable = true;
            this.tb_ip_db.CustomButton.Visible = false;
            this.tb_ip_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_ip_db.Lines = new string[0];
            this.tb_ip_db.Location = new System.Drawing.Point(131, 714);
            this.tb_ip_db.MaxLength = 32767;
            this.tb_ip_db.Name = "tb_ip_db";
            this.tb_ip_db.PasswordChar = '\0';
            this.tb_ip_db.PromptText = "Inidirizzo IP del database";
            this.tb_ip_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ip_db.SelectedText = "";
            this.tb_ip_db.SelectionLength = 0;
            this.tb_ip_db.SelectionStart = 0;
            this.tb_ip_db.ShortcutsEnabled = true;
            this.tb_ip_db.Size = new System.Drawing.Size(376, 29);
            this.tb_ip_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_ip_db.TabIndex = 2;
            this.tb_ip_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ip_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_ip_db.UseSelectable = true;
            this.tb_ip_db.WaterMark = "Inidirizzo IP del database";
            this.tb_ip_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ip_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_port_db
            // 
            // 
            // 
            // 
            this.tb_port_db.CustomButton.Image = null;
            this.tb_port_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_port_db.CustomButton.Name = "";
            this.tb_port_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_port_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_port_db.CustomButton.TabIndex = 1;
            this.tb_port_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_port_db.CustomButton.UseSelectable = true;
            this.tb_port_db.CustomButton.Visible = false;
            this.tb_port_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_port_db.Lines = new string[0];
            this.tb_port_db.Location = new System.Drawing.Point(131, 797);
            this.tb_port_db.MaxLength = 32767;
            this.tb_port_db.Name = "tb_port_db";
            this.tb_port_db.PasswordChar = '\0';
            this.tb_port_db.PromptText = "Porta del database";
            this.tb_port_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_port_db.SelectedText = "";
            this.tb_port_db.SelectionLength = 0;
            this.tb_port_db.SelectionStart = 0;
            this.tb_port_db.ShortcutsEnabled = true;
            this.tb_port_db.Size = new System.Drawing.Size(376, 29);
            this.tb_port_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_port_db.TabIndex = 3;
            this.tb_port_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_port_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_port_db.UseSelectable = true;
            this.tb_port_db.WaterMark = "Porta del database";
            this.tb_port_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_port_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_user_db
            // 
            // 
            // 
            // 
            this.tb_user_db.CustomButton.Image = null;
            this.tb_user_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_user_db.CustomButton.Name = "";
            this.tb_user_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_user_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_user_db.CustomButton.TabIndex = 1;
            this.tb_user_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_user_db.CustomButton.UseSelectable = true;
            this.tb_user_db.CustomButton.Visible = false;
            this.tb_user_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_user_db.Lines = new string[0];
            this.tb_user_db.Location = new System.Drawing.Point(133, 542);
            this.tb_user_db.MaxLength = 32767;
            this.tb_user_db.Name = "tb_user_db";
            this.tb_user_db.PasswordChar = '\0';
            this.tb_user_db.PromptText = "Nome utente del database";
            this.tb_user_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_user_db.SelectedText = "";
            this.tb_user_db.SelectionLength = 0;
            this.tb_user_db.SelectionStart = 0;
            this.tb_user_db.ShortcutsEnabled = true;
            this.tb_user_db.Size = new System.Drawing.Size(376, 29);
            this.tb_user_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_user_db.TabIndex = 4;
            this.tb_user_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_user_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_user_db.UseSelectable = true;
            this.tb_user_db.WaterMark = "Nome utente del database";
            this.tb_user_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_user_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_pass_db
            // 
            // 
            // 
            // 
            this.tb_pass_db.CustomButton.Image = null;
            this.tb_pass_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_pass_db.CustomButton.Name = "";
            this.tb_pass_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_pass_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pass_db.CustomButton.TabIndex = 1;
            this.tb_pass_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass_db.CustomButton.UseSelectable = true;
            this.tb_pass_db.CustomButton.Visible = false;
            this.tb_pass_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_pass_db.Lines = new string[0];
            this.tb_pass_db.Location = new System.Drawing.Point(133, 630);
            this.tb_pass_db.MaxLength = 32767;
            this.tb_pass_db.Name = "tb_pass_db";
            this.tb_pass_db.PasswordChar = '•';
            this.tb_pass_db.PromptText = "Password database";
            this.tb_pass_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pass_db.SelectedText = "";
            this.tb_pass_db.SelectionLength = 0;
            this.tb_pass_db.SelectionStart = 0;
            this.tb_pass_db.ShortcutsEnabled = true;
            this.tb_pass_db.Size = new System.Drawing.Size(376, 29);
            this.tb_pass_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_pass_db.TabIndex = 5;
            this.tb_pass_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pass_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_pass_db.UseSelectable = true;
            this.tb_pass_db.WaterMark = "Password database";
            this.tb_pass_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pass_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_sql_type
            // 
            this.cb_sql_type.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_sql_type.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cb_sql_type.FormattingEnabled = true;
            this.cb_sql_type.ItemHeight = 29;
            this.cb_sql_type.Items.AddRange(new object[] {
            "MySQL",
            "Postgres",
            "Oracle"});
            this.cb_sql_type.Location = new System.Drawing.Point(131, 266);
            this.cb_sql_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_sql_type.Name = "cb_sql_type";
            this.cb_sql_type.Size = new System.Drawing.Size(374, 35);
            this.cb_sql_type.Style = MetroFramework.MetroColorStyle.Purple;
            this.cb_sql_type.TabIndex = 6;
            this.cb_sql_type.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_sql_type.UseSelectable = true;
            this.cb_sql_type.SelectedIndexChanged += new System.EventHandler(this.cb_sql_type_SelectedIndexChanged);
            // 
            // btn_connect
            // 
            this.btn_connect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_connect.Location = new System.Drawing.Point(131, 1027);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(376, 48);
            this.btn_connect.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "> CONNECT <";
            this.btn_connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_connect.UseSelectable = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(133, 421);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nome Database:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_ip.Location = new System.Drawing.Point(131, 682);
            this.lbl_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(44, 19);
            this.lbl_ip.Style = MetroFramework.MetroColorStyle.Black;
            this.lbl_ip.TabIndex = 9;
            this.lbl_ip.Text = "Host:";
            this.lbl_ip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_port.Location = new System.Drawing.Point(131, 765);
            this.lbl_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(50, 19);
            this.lbl_port.Style = MetroFramework.MetroColorStyle.Black;
            this.lbl_port.TabIndex = 10;
            this.lbl_port.Text = "Porta:";
            this.lbl_port.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(133, 505);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Utente:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(133, 593);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Password:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(254, 232);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(139, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Tipo Database:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_gestoreProfili
            // 
            this.btn_gestoreProfili.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_gestoreProfili.Location = new System.Drawing.Point(131, 87);
            this.btn_gestoreProfili.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gestoreProfili.Name = "btn_gestoreProfili";
            this.btn_gestoreProfili.Size = new System.Drawing.Size(376, 48);
            this.btn_gestoreProfili.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_gestoreProfili.TabIndex = 14;
            this.btn_gestoreProfili.Text = "GESTORE PROFILI";
            this.btn_gestoreProfili.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_gestoreProfili.UseSelectable = true;
            this.btn_gestoreProfili.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(612, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&X";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // lbl_datasource
            // 
            this.lbl_datasource.AutoSize = true;
            this.lbl_datasource.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_datasource.Location = new System.Drawing.Point(133, 839);
            this.lbl_datasource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datasource.Name = "lbl_datasource";
            this.lbl_datasource.Size = new System.Drawing.Size(94, 19);
            this.lbl_datasource.Style = MetroFramework.MetroColorStyle.Black;
            this.lbl_datasource.TabIndex = 19;
            this.lbl_datasource.Text = "Data Source:";
            this.lbl_datasource.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_datasource.Visible = false;
            // 
            // tb_datasource_db
            // 
            // 
            // 
            // 
            this.tb_datasource_db.CustomButton.Image = null;
            this.tb_datasource_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_datasource_db.CustomButton.Name = "";
            this.tb_datasource_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_datasource_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_datasource_db.CustomButton.TabIndex = 1;
            this.tb_datasource_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_datasource_db.CustomButton.UseSelectable = true;
            this.tb_datasource_db.CustomButton.Visible = false;
            this.tb_datasource_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_datasource_db.Lines = new string[] {
        "orcl"};
            this.tb_datasource_db.Location = new System.Drawing.Point(133, 876);
            this.tb_datasource_db.MaxLength = 32767;
            this.tb_datasource_db.Name = "tb_datasource_db";
            this.tb_datasource_db.PasswordChar = '\0';
            this.tb_datasource_db.PromptText = "[Oracle] DataSource (TNS)";
            this.tb_datasource_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_datasource_db.SelectedText = "";
            this.tb_datasource_db.SelectionLength = 0;
            this.tb_datasource_db.SelectionStart = 0;
            this.tb_datasource_db.ShortcutsEnabled = true;
            this.tb_datasource_db.Size = new System.Drawing.Size(376, 29);
            this.tb_datasource_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_datasource_db.TabIndex = 18;
            this.tb_datasource_db.Text = "orcl";
            this.tb_datasource_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_datasource_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_datasource_db.UseSelectable = true;
            this.tb_datasource_db.Visible = false;
            this.tb_datasource_db.WaterMark = "[Oracle] DataSource (TNS)";
            this.tb_datasource_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_datasource_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(269, 168);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 25);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "---- OR ----";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_gestionale_db);
            this.groupBox1.Controls.Add(this.lblGestionale);
            this.groupBox1.Controls.Add(this.cb_showPass);
            this.groupBox1.Controls.Add(this.spinnerLoading);
            this.groupBox1.Controls.Add(this.btn_gestoreProfili);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.tb_name_db);
            this.groupBox1.Controls.Add(this.lbl_datasource);
            this.groupBox1.Controls.Add(this.tb_ip_db);
            this.groupBox1.Controls.Add(this.tb_datasource_db);
            this.groupBox1.Controls.Add(this.tb_port_db);
            this.groupBox1.Controls.Add(this.tb_user_db);
            this.groupBox1.Controls.Add(this.tb_pass_db);
            this.groupBox1.Controls.Add(this.cb_sql_type);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.lbl_ip);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 1115);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // tb_gestionale_db
            // 
            this.tb_gestionale_db.AccessibleDescription = "";
            this.tb_gestionale_db.AccessibleName = "";
            // 
            // 
            // 
            this.tb_gestionale_db.CustomButton.Image = null;
            this.tb_gestionale_db.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.tb_gestionale_db.CustomButton.Name = "";
            this.tb_gestionale_db.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_gestionale_db.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_gestionale_db.CustomButton.TabIndex = 1;
            this.tb_gestionale_db.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_gestionale_db.CustomButton.UseSelectable = true;
            this.tb_gestionale_db.CustomButton.Visible = false;
            this.tb_gestionale_db.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_gestionale_db.Lines = new string[0];
            this.tb_gestionale_db.Location = new System.Drawing.Point(131, 377);
            this.tb_gestionale_db.MaxLength = 32767;
            this.tb_gestionale_db.Name = "tb_gestionale_db";
            this.tb_gestionale_db.PasswordChar = '\0';
            this.tb_gestionale_db.PromptText = "Nome gestionale (usa generico se non esiste)";
            this.tb_gestionale_db.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_gestionale_db.SelectedText = "";
            this.tb_gestionale_db.SelectionLength = 0;
            this.tb_gestionale_db.SelectionStart = 0;
            this.tb_gestionale_db.ShortcutsEnabled = true;
            this.tb_gestionale_db.Size = new System.Drawing.Size(376, 29);
            this.tb_gestionale_db.Style = MetroFramework.MetroColorStyle.Purple;
            this.tb_gestionale_db.TabIndex = 23;
            this.tb_gestionale_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_gestionale_db.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_gestionale_db.UseSelectable = true;
            this.tb_gestionale_db.WaterMark = "Nome gestionale (usa generico se non esiste)";
            this.tb_gestionale_db.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_gestionale_db.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGestionale
            // 
            this.lblGestionale.AutoSize = true;
            this.lblGestionale.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGestionale.Location = new System.Drawing.Point(131, 345);
            this.lblGestionale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionale.Name = "lblGestionale";
            this.lblGestionale.Size = new System.Drawing.Size(83, 19);
            this.lblGestionale.Style = MetroFramework.MetroColorStyle.Black;
            this.lblGestionale.TabIndex = 24;
            this.lblGestionale.Text = "Gestionale:";
            this.lblGestionale.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_showPass.Location = new System.Drawing.Point(389, 665);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(120, 19);
            this.cb_showPass.Style = MetroFramework.MetroColorStyle.Purple;
            this.cb_showPass.TabIndex = 22;
            this.cb_showPass.Text = "Show Password";
            this.cb_showPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_showPass.UseSelectable = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // spinnerLoading
            // 
            this.spinnerLoading.Location = new System.Drawing.Point(287, 937);
            this.spinnerLoading.Maximum = 100;
            this.spinnerLoading.Name = "spinnerLoading";
            this.spinnerLoading.Size = new System.Drawing.Size(61, 65);
            this.spinnerLoading.Style = MetroFramework.MetroColorStyle.Purple;
            this.spinnerLoading.TabIndex = 21;
            this.spinnerLoading.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spinnerLoading.UseSelectable = true;
            this.spinnerLoading.Value = 33;
            this.spinnerLoading.Visible = false;
            // 
            // Test
            // 
            this.Test.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Test.BalloonTipText = "Connected!";
            this.Test.BalloonTipTitle = "DB Status";
            this.Test.Icon = ((System.Drawing.Icon)(resources.GetObject("Test.Icon")));
            this.Test.Text = "notifyIcon1";
            this.Test.Visible = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 1187);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(22, 92, 22, 25);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Converx - Accesso";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_ip;
        private MetroFramework.Controls.MetroLabel lbl_port;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btn_gestoreProfili;
        private MetroFramework.Controls.MetroButton btnClose;
        public MetroFramework.Controls.MetroTextBox tb_name_db;
        public MetroFramework.Controls.MetroTextBox tb_ip_db;
        public MetroFramework.Controls.MetroTextBox tb_port_db;
        public MetroFramework.Controls.MetroTextBox tb_user_db;
        public MetroFramework.Controls.MetroTextBox tb_pass_db;
        private MetroFramework.Controls.MetroLabel lbl_datasource;
        public MetroFramework.Controls.MetroTextBox tb_datasource_db;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroProgressSpinner spinnerLoading;
        public MetroFramework.Controls.MetroComboBox cb_sql_type;
        private System.Windows.Forms.NotifyIcon Test;
        private MetroFramework.Controls.MetroCheckBox cb_showPass;
        public MetroFramework.Controls.MetroTextBox tb_gestionale_db;
        private MetroFramework.Controls.MetroLabel lblGestionale;
    }
}

