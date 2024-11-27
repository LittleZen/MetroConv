namespace HalleyImport.JMM
{
    partial class frmProfili
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfili));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_new = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pr_tb_gestionale = new MetroFramework.Controls.MetroTextBox();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.pr_tb_datatype = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pr_tb_datasource = new MetroFramework.Controls.MetroTextBox();
            this.btn_openConfig = new MetroFramework.Controls.MetroButton();
            this.btn_remove = new MetroFramework.Controls.MetroButton();
            this.btn_add_update = new MetroFramework.Controls.MetroButton();
            this.pr_db_name_ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pr_tb_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbGestionale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPsw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDataDource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_tb_ip = new MetroFramework.Controls.MetroTextBox();
            this.pr_tb_pwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pr_tb_user = new MetroFramework.Controls.MetroTextBox();
            this.pr_tb_port = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pr_btn_use = new MetroFramework.Controls.MetroButton();
            this.DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.bt_new);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.pr_tb_gestionale);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.pr_tb_datatype);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.pr_tb_datasource);
            this.groupBox1.Controls.Add(this.btn_openConfig);
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.btn_add_update);
            this.groupBox1.Controls.Add(this.pr_db_name_);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.pr_tb_name);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pr_tb_ip);
            this.groupBox1.Controls.Add(this.pr_tb_pwd);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.pr_tb_user);
            this.groupBox1.Controls.Add(this.pr_tb_port);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1578, 977);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // bt_new
            // 
            this.bt_new.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt_new.Location = new System.Drawing.Point(24, 54);
            this.bt_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(190, 55);
            this.bt_new.Style = MetroFramework.MetroColorStyle.Purple;
            this.bt_new.TabIndex = 36;
            this.bt_new.Text = "+ &Nuovo";
            this.bt_new.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bt_new.UseSelectable = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(24, 142);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Nome Gestionale:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_tb_gestionale
            // 
            // 
            // 
            // 
            this.pr_tb_gestionale.CustomButton.Image = null;
            this.pr_tb_gestionale.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_gestionale.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_gestionale.CustomButton.Name = "";
            this.pr_tb_gestionale.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_gestionale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_gestionale.CustomButton.TabIndex = 1;
            this.pr_tb_gestionale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_gestionale.CustomButton.UseSelectable = true;
            this.pr_tb_gestionale.CustomButton.Visible = false;
            this.pr_tb_gestionale.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_gestionale.Lines = new string[0];
            this.pr_tb_gestionale.Location = new System.Drawing.Point(24, 176);
            this.pr_tb_gestionale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_gestionale.MaxLength = 32767;
            this.pr_tb_gestionale.Name = "pr_tb_gestionale";
            this.pr_tb_gestionale.PasswordChar = '\0';
            this.pr_tb_gestionale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_gestionale.SelectedText = "";
            this.pr_tb_gestionale.SelectionLength = 0;
            this.pr_tb_gestionale.SelectionStart = 0;
            this.pr_tb_gestionale.ShortcutsEnabled = true;
            this.pr_tb_gestionale.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_gestionale.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_gestionale.TabIndex = 34;
            this.pr_tb_gestionale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_gestionale.UseSelectable = true;
            this.pr_tb_gestionale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_gestionale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl.Location = new System.Drawing.Point(24, 685);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 19);
            this.lbl.Style = MetroFramework.MetroColorStyle.Purple;
            this.lbl.TabIndex = 33;
            this.lbl.Text = "Tipo Database:";
            this.lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_tb_datatype
            // 
            // 
            // 
            // 
            this.pr_tb_datatype.CustomButton.Image = null;
            this.pr_tb_datatype.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_datatype.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_datatype.CustomButton.Name = "";
            this.pr_tb_datatype.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_datatype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_datatype.CustomButton.TabIndex = 1;
            this.pr_tb_datatype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_datatype.CustomButton.UseSelectable = true;
            this.pr_tb_datatype.CustomButton.Visible = false;
            this.pr_tb_datatype.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_datatype.Lines = new string[0];
            this.pr_tb_datatype.Location = new System.Drawing.Point(24, 709);
            this.pr_tb_datatype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_datatype.MaxLength = 32767;
            this.pr_tb_datatype.Name = "pr_tb_datatype";
            this.pr_tb_datatype.PasswordChar = '\0';
            this.pr_tb_datatype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_datatype.SelectedText = "";
            this.pr_tb_datatype.SelectionLength = 0;
            this.pr_tb_datatype.SelectionStart = 0;
            this.pr_tb_datatype.ShortcutsEnabled = true;
            this.pr_tb_datatype.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_datatype.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_datatype.TabIndex = 32;
            this.pr_tb_datatype.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_datatype.UseSelectable = true;
            this.pr_tb_datatype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_datatype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 611);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "DataSource (Oracle):";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_tb_datasource
            // 
            // 
            // 
            // 
            this.pr_tb_datasource.CustomButton.Image = null;
            this.pr_tb_datasource.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_datasource.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_datasource.CustomButton.Name = "";
            this.pr_tb_datasource.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_datasource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_datasource.CustomButton.TabIndex = 1;
            this.pr_tb_datasource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_datasource.CustomButton.UseSelectable = true;
            this.pr_tb_datasource.CustomButton.Visible = false;
            this.pr_tb_datasource.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_datasource.Lines = new string[0];
            this.pr_tb_datasource.Location = new System.Drawing.Point(24, 635);
            this.pr_tb_datasource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_datasource.MaxLength = 32767;
            this.pr_tb_datasource.Name = "pr_tb_datasource";
            this.pr_tb_datasource.PasswordChar = '\0';
            this.pr_tb_datasource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_datasource.SelectedText = "";
            this.pr_tb_datasource.SelectionLength = 0;
            this.pr_tb_datasource.SelectionStart = 0;
            this.pr_tb_datasource.ShortcutsEnabled = true;
            this.pr_tb_datasource.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_datasource.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_datasource.TabIndex = 30;
            this.pr_tb_datasource.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_datasource.UseSelectable = true;
            this.pr_tb_datasource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_datasource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_openConfig
            // 
            this.btn_openConfig.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_openConfig.Location = new System.Drawing.Point(24, 900);
            this.btn_openConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_openConfig.Name = "btn_openConfig";
            this.btn_openConfig.Size = new System.Drawing.Size(190, 55);
            this.btn_openConfig.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_openConfig.TabIndex = 28;
            this.btn_openConfig.Text = "&Apri Cartella Configurazioni";
            this.btn_openConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_openConfig.UseSelectable = true;
            this.btn_openConfig.Click += new System.EventHandler(this.btn_openConfig_Click_1);
            // 
            // btn_remove
            // 
            this.btn_remove.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_remove.Location = new System.Drawing.Point(24, 835);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(190, 55);
            this.btn_remove.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_remove.TabIndex = 27;
            this.btn_remove.Text = "&Elimina";
            this.btn_remove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_remove.UseSelectable = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add_update
            // 
            this.btn_add_update.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_add_update.Location = new System.Drawing.Point(24, 770);
            this.btn_add_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(190, 55);
            this.btn_add_update.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_add_update.TabIndex = 26;
            this.btn_add_update.Text = "&Salva";
            this.btn_add_update.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_add_update.UseSelectable = true;
            this.btn_add_update.Click += new System.EventHandler(this.btn_add_update_Click_1);
            // 
            // pr_db_name_
            // 
            this.pr_db_name_.AutoSize = true;
            this.pr_db_name_.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pr_db_name_.Location = new System.Drawing.Point(24, 220);
            this.pr_db_name_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr_db_name_.Name = "pr_db_name_";
            this.pr_db_name_.Size = new System.Drawing.Size(120, 19);
            this.pr_db_name_.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_db_name_.TabIndex = 21;
            this.pr_db_name_.Text = "Nome Database:";
            this.pr_db_name_.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(24, 537);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(143, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Password Database:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_tb_name
            // 
            // 
            // 
            // 
            this.pr_tb_name.CustomButton.Image = null;
            this.pr_tb_name.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_name.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_name.CustomButton.Name = "";
            this.pr_tb_name.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_name.CustomButton.TabIndex = 1;
            this.pr_tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_name.CustomButton.UseSelectable = true;
            this.pr_tb_name.CustomButton.Visible = false;
            this.pr_tb_name.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_name.Lines = new string[0];
            this.pr_tb_name.Location = new System.Drawing.Point(24, 254);
            this.pr_tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_name.MaxLength = 32767;
            this.pr_tb_name.Name = "pr_tb_name";
            this.pr_tb_name.PasswordChar = '\0';
            this.pr_tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_name.SelectedText = "";
            this.pr_tb_name.SelectionLength = 0;
            this.pr_tb_name.SelectionStart = 0;
            this.pr_tb_name.ShortcutsEnabled = true;
            this.pr_tb_name.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_name.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_name.TabIndex = 16;
            this.pr_tb_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_name.UseSelectable = true;
            this.pr_tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(24, 458);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(123, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Utente Database:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbGestionale,
            this.dbType,
            this.dbName,
            this.dbIp,
            this.dbPort,
            this.dbUser,
            this.dbPsw,
            this.dbDataDource});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(237, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1333, 901);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // dbGestionale
            // 
            this.dbGestionale.HeaderText = "Gestionale:";
            this.dbGestionale.MinimumWidth = 8;
            this.dbGestionale.Name = "dbGestionale";
            this.dbGestionale.ReadOnly = true;
            this.dbGestionale.Width = 150;
            // 
            // dbType
            // 
            this.dbType.HeaderText = "Tipologia SQL:";
            this.dbType.MinimumWidth = 8;
            this.dbType.Name = "dbType";
            this.dbType.ReadOnly = true;
            this.dbType.Width = 150;
            // 
            // dbName
            // 
            this.dbName.HeaderText = "DB Name:";
            this.dbName.MinimumWidth = 8;
            this.dbName.Name = "dbName";
            this.dbName.ReadOnly = true;
            this.dbName.Width = 200;
            // 
            // dbIp
            // 
            this.dbIp.HeaderText = "DB IP:";
            this.dbIp.MinimumWidth = 8;
            this.dbIp.Name = "dbIp";
            this.dbIp.ReadOnly = true;
            this.dbIp.Width = 150;
            // 
            // dbPort
            // 
            this.dbPort.HeaderText = "DB Port:";
            this.dbPort.MinimumWidth = 8;
            this.dbPort.Name = "dbPort";
            this.dbPort.ReadOnly = true;
            this.dbPort.Width = 150;
            // 
            // dbUser
            // 
            this.dbUser.HeaderText = "DB User:";
            this.dbUser.MinimumWidth = 8;
            this.dbUser.Name = "dbUser";
            this.dbUser.ReadOnly = true;
            this.dbUser.Width = 150;
            // 
            // dbPsw
            // 
            this.dbPsw.HeaderText = "DB Password:";
            this.dbPsw.MinimumWidth = 8;
            this.dbPsw.Name = "dbPsw";
            this.dbPsw.ReadOnly = true;
            this.dbPsw.Width = 150;
            // 
            // dbDataDource
            // 
            this.dbDataDource.HeaderText = "DB DataSource (Oracle):";
            this.dbDataDource.MinimumWidth = 8;
            this.dbDataDource.Name = "dbDataDource";
            this.dbDataDource.ReadOnly = true;
            this.dbDataDource.Width = 230;
            // 
            // pr_tb_ip
            // 
            // 
            // 
            // 
            this.pr_tb_ip.CustomButton.Image = null;
            this.pr_tb_ip.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_ip.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_ip.CustomButton.Name = "";
            this.pr_tb_ip.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_ip.CustomButton.TabIndex = 1;
            this.pr_tb_ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_ip.CustomButton.UseSelectable = true;
            this.pr_tb_ip.CustomButton.Visible = false;
            this.pr_tb_ip.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_ip.Lines = new string[0];
            this.pr_tb_ip.Location = new System.Drawing.Point(24, 335);
            this.pr_tb_ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_ip.MaxLength = 32767;
            this.pr_tb_ip.Name = "pr_tb_ip";
            this.pr_tb_ip.PasswordChar = '\0';
            this.pr_tb_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_ip.SelectedText = "";
            this.pr_tb_ip.SelectionLength = 0;
            this.pr_tb_ip.SelectionStart = 0;
            this.pr_tb_ip.ShortcutsEnabled = true;
            this.pr_tb_ip.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_ip.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_ip.TabIndex = 17;
            this.pr_tb_ip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_ip.UseSelectable = true;
            this.pr_tb_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pr_tb_pwd
            // 
            // 
            // 
            // 
            this.pr_tb_pwd.CustomButton.Image = null;
            this.pr_tb_pwd.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_pwd.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_pwd.CustomButton.Name = "";
            this.pr_tb_pwd.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_pwd.CustomButton.TabIndex = 1;
            this.pr_tb_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_pwd.CustomButton.UseSelectable = true;
            this.pr_tb_pwd.CustomButton.Visible = false;
            this.pr_tb_pwd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_pwd.Lines = new string[0];
            this.pr_tb_pwd.Location = new System.Drawing.Point(24, 561);
            this.pr_tb_pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_pwd.MaxLength = 32767;
            this.pr_tb_pwd.Name = "pr_tb_pwd";
            this.pr_tb_pwd.PasswordChar = '\0';
            this.pr_tb_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_pwd.SelectedText = "";
            this.pr_tb_pwd.SelectionLength = 0;
            this.pr_tb_pwd.SelectionStart = 0;
            this.pr_tb_pwd.ShortcutsEnabled = true;
            this.pr_tb_pwd.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_pwd.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_pwd.TabIndex = 20;
            this.pr_tb_pwd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_pwd.UseSelectable = true;
            this.pr_tb_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(27, 380);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Porta Database:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_tb_user
            // 
            // 
            // 
            // 
            this.pr_tb_user.CustomButton.Image = null;
            this.pr_tb_user.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_user.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_user.CustomButton.Name = "";
            this.pr_tb_user.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_user.CustomButton.TabIndex = 1;
            this.pr_tb_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_user.CustomButton.UseSelectable = true;
            this.pr_tb_user.CustomButton.Visible = false;
            this.pr_tb_user.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_user.Lines = new string[0];
            this.pr_tb_user.Location = new System.Drawing.Point(26, 492);
            this.pr_tb_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_user.MaxLength = 32767;
            this.pr_tb_user.Name = "pr_tb_user";
            this.pr_tb_user.PasswordChar = '\0';
            this.pr_tb_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_user.SelectedText = "";
            this.pr_tb_user.SelectionLength = 0;
            this.pr_tb_user.SelectionStart = 0;
            this.pr_tb_user.ShortcutsEnabled = true;
            this.pr_tb_user.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_user.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_user.TabIndex = 19;
            this.pr_tb_user.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_user.UseSelectable = true;
            this.pr_tb_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pr_tb_port
            // 
            // 
            // 
            // 
            this.pr_tb_port.CustomButton.Image = null;
            this.pr_tb_port.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.pr_tb_port.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_port.CustomButton.Name = "";
            this.pr_tb_port.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pr_tb_port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pr_tb_port.CustomButton.TabIndex = 1;
            this.pr_tb_port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pr_tb_port.CustomButton.UseSelectable = true;
            this.pr_tb_port.CustomButton.Visible = false;
            this.pr_tb_port.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pr_tb_port.Lines = new string[0];
            this.pr_tb_port.Location = new System.Drawing.Point(26, 404);
            this.pr_tb_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_tb_port.MaxLength = 32767;
            this.pr_tb_port.Name = "pr_tb_port";
            this.pr_tb_port.PasswordChar = '\0';
            this.pr_tb_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pr_tb_port.SelectedText = "";
            this.pr_tb_port.SelectionLength = 0;
            this.pr_tb_port.SelectionStart = 0;
            this.pr_tb_port.ShortcutsEnabled = true;
            this.pr_tb_port.Size = new System.Drawing.Size(190, 35);
            this.pr_tb_port.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_tb_port.TabIndex = 18;
            this.pr_tb_port.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_tb_port.UseSelectable = true;
            this.pr_tb_port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pr_tb_port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 302);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Host Database:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pr_btn_use
            // 
            this.pr_btn_use.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pr_btn_use.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.pr_btn_use.Location = new System.Drawing.Point(660, 1076);
            this.pr_btn_use.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pr_btn_use.Name = "pr_btn_use";
            this.pr_btn_use.Size = new System.Drawing.Size(283, 55);
            this.pr_btn_use.Style = MetroFramework.MetroColorStyle.Purple;
            this.pr_btn_use.TabIndex = 6;
            this.pr_btn_use.Text = "&Conferma";
            this.pr_btn_use.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pr_btn_use.UseSelectable = true;
            // 
            // DB
            // 
            this.DB.HeaderText = "DB:";
            this.DB.MinimumWidth = 8;
            this.DB.Name = "DB";
            this.DB.Width = 170;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1566, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "&X";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProfili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 1152);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pr_btn_use);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProfili";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Converx - Gestore Profili";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton pr_btn_use;
        private MetroFramework.Controls.MetroLabel pr_db_name_;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox pr_tb_name;
        public MetroFramework.Controls.MetroTextBox pr_tb_ip;
        public MetroFramework.Controls.MetroTextBox pr_tb_pwd;
        public MetroFramework.Controls.MetroTextBox pr_tb_user;
        public MetroFramework.Controls.MetroTextBox pr_tb_port;
        private MetroFramework.Controls.MetroButton btn_add_update;
        private MetroFramework.Controls.MetroButton btn_remove;
        private MetroFramework.Controls.MetroButton btn_openConfig;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox pr_tb_datasource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB;
        private MetroFramework.Controls.MetroLabel lbl;
        public MetroFramework.Controls.MetroTextBox pr_tb_datatype;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroTextBox pr_tb_gestionale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbGestionale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbPsw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDataDource;
        private MetroFramework.Controls.MetroButton bt_new;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}