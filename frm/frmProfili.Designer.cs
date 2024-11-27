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
            this.label1 = new System.Windows.Forms.Label();
            this.pr_tb_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pr_db_pwd = new System.Windows.Forms.Label();
            this.pr_db_user = new System.Windows.Forms.Label();
            this.pr_db_ip = new System.Windows.Forms.Label();
            this.pr_db_port = new System.Windows.Forms.Label();
            this.pr_db_name = new System.Windows.Forms.Label();
            this.pr_tb_pwd = new System.Windows.Forms.TextBox();
            this.pr_tb_user = new System.Windows.Forms.TextBox();
            this.pr_tb_ip = new System.Windows.Forms.TextBox();
            this.pr_tb_port = new System.Windows.Forms.TextBox();
            this.pr_btn_use = new System.Windows.Forms.Button();
            this.pr_btn_close = new System.Windows.Forms.Button();
            this.DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pr_tb_name
            // 
            this.pr_tb_name.Location = new System.Drawing.Point(15, 58);
            this.pr_tb_name.Name = "pr_tb_name";
            this.pr_tb_name.Size = new System.Drawing.Size(127, 20);
            this.pr_tb_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_update);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pr_db_pwd);
            this.groupBox1.Controls.Add(this.pr_db_user);
            this.groupBox1.Controls.Add(this.pr_db_ip);
            this.groupBox1.Controls.Add(this.pr_db_port);
            this.groupBox1.Controls.Add(this.pr_db_name);
            this.groupBox1.Controls.Add(this.pr_tb_pwd);
            this.groupBox1.Controls.Add(this.pr_tb_user);
            this.groupBox1.Controls.Add(this.pr_tb_ip);
            this.groupBox1.Controls.Add(this.pr_tb_port);
            this.groupBox1.Controls.Add(this.pr_tb_name);
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mysql Settings:";
            // 
            // btn_add_update
            // 
            this.btn_add_update.Location = new System.Drawing.Point(15, 271);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(127, 36);
            this.btn_add_update.TabIndex = 15;
            this.btn_add_update.Text = "&Aggiungi o Aggiorna";
            this.btn_add_update.UseVisualStyleBackColor = true;
            this.btn_add_update.Click += new System.EventHandler(this.btn_add_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DB,
            this.IP,
            this.Port,
            this.User,
            this.Pwd});
            this.dataGridView1.Location = new System.Drawing.Point(149, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 300);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // pr_db_pwd
            // 
            this.pr_db_pwd.AutoSize = true;
            this.pr_db_pwd.Location = new System.Drawing.Point(13, 214);
            this.pr_db_pwd.Name = "pr_db_pwd";
            this.pr_db_pwd.Size = new System.Drawing.Size(49, 13);
            this.pr_db_pwd.TabIndex = 13;
            this.pr_db_pwd.Text = "DB Pwd:";
            // 
            // pr_db_user
            // 
            this.pr_db_user.AutoSize = true;
            this.pr_db_user.Location = new System.Drawing.Point(13, 171);
            this.pr_db_user.Name = "pr_db_user";
            this.pr_db_user.Size = new System.Drawing.Size(50, 13);
            this.pr_db_user.TabIndex = 12;
            this.pr_db_user.Text = "DB User:";
            // 
            // pr_db_ip
            // 
            this.pr_db_ip.AutoSize = true;
            this.pr_db_ip.Location = new System.Drawing.Point(14, 85);
            this.pr_db_ip.Name = "pr_db_ip";
            this.pr_db_ip.Size = new System.Drawing.Size(38, 13);
            this.pr_db_ip.TabIndex = 11;
            this.pr_db_ip.Text = "DB IP:";
            // 
            // pr_db_port
            // 
            this.pr_db_port.AutoSize = true;
            this.pr_db_port.Location = new System.Drawing.Point(13, 128);
            this.pr_db_port.Name = "pr_db_port";
            this.pr_db_port.Size = new System.Drawing.Size(47, 13);
            this.pr_db_port.TabIndex = 10;
            this.pr_db_port.Text = "DB Port:";
            // 
            // pr_db_name
            // 
            this.pr_db_name.AutoSize = true;
            this.pr_db_name.Location = new System.Drawing.Point(14, 42);
            this.pr_db_name.Name = "pr_db_name";
            this.pr_db_name.Size = new System.Drawing.Size(56, 13);
            this.pr_db_name.TabIndex = 9;
            this.pr_db_name.Text = "DB Name:";
            // 
            // pr_tb_pwd
            // 
            this.pr_tb_pwd.Location = new System.Drawing.Point(15, 230);
            this.pr_tb_pwd.Name = "pr_tb_pwd";
            this.pr_tb_pwd.Size = new System.Drawing.Size(127, 20);
            this.pr_tb_pwd.TabIndex = 8;
            // 
            // pr_tb_user
            // 
            this.pr_tb_user.Location = new System.Drawing.Point(15, 187);
            this.pr_tb_user.Name = "pr_tb_user";
            this.pr_tb_user.Size = new System.Drawing.Size(127, 20);
            this.pr_tb_user.TabIndex = 7;
            // 
            // pr_tb_ip
            // 
            this.pr_tb_ip.Location = new System.Drawing.Point(15, 101);
            this.pr_tb_ip.Name = "pr_tb_ip";
            this.pr_tb_ip.Size = new System.Drawing.Size(127, 20);
            this.pr_tb_ip.TabIndex = 6;
            // 
            // pr_tb_port
            // 
            this.pr_tb_port.Location = new System.Drawing.Point(15, 144);
            this.pr_tb_port.Name = "pr_tb_port";
            this.pr_tb_port.Size = new System.Drawing.Size(127, 20);
            this.pr_tb_port.TabIndex = 5;
            // 
            // pr_btn_use
            // 
            this.pr_btn_use.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pr_btn_use.Location = new System.Drawing.Point(490, 357);
            this.pr_btn_use.Name = "pr_btn_use";
            this.pr_btn_use.Size = new System.Drawing.Size(188, 30);
            this.pr_btn_use.TabIndex = 3;
            this.pr_btn_use.Text = "&Use";
            this.pr_btn_use.UseVisualStyleBackColor = true;
            this.pr_btn_use.Click += new System.EventHandler(this.pr_btn_use_Click);
            // 
            // pr_btn_close
            // 
            this.pr_btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pr_btn_close.Location = new System.Drawing.Point(54, 358);
            this.pr_btn_close.Name = "pr_btn_close";
            this.pr_btn_close.Size = new System.Drawing.Size(188, 30);
            this.pr_btn_close.TabIndex = 4;
            this.pr_btn_close.Text = "Close";
            this.pr_btn_close.UseVisualStyleBackColor = true;
            // 
            // DB
            // 
            this.DB.HeaderText = "DB:";
            this.DB.Name = "DB";
            this.DB.ReadOnly = true;
            this.DB.Width = 170;
            // 
            // IP
            // 
            this.IP.HeaderText = "DB IP:";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.HeaderText = "DB Port:";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // User
            // 
            this.User.HeaderText = "DB User:";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Pwd
            // 
            this.Pwd.HeaderText = "DB Pwd:";
            this.Pwd.Name = "Pwd";
            this.Pwd.ReadOnly = true;
            // 
            // frmProfili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 400);
            this.Controls.Add(this.pr_btn_close);
            this.Controls.Add(this.pr_btn_use);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmProfili";
            this.Text = "MySQL Connection Profiles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pr_db_name;
        private System.Windows.Forms.Label pr_db_pwd;
        private System.Windows.Forms.Label pr_db_user;
        private System.Windows.Forms.Label pr_db_ip;
        private System.Windows.Forms.Label pr_db_port;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Button pr_btn_close;
        private System.Windows.Forms.Button btn_add_update;
        private System.Windows.Forms.Button pr_btn_use;
        private System.Windows.Forms.Button pr_btn_close;
        public System.Windows.Forms.TextBox pr_tb_name;
        public System.Windows.Forms.TextBox pr_tb_pwd;
        public System.Windows.Forms.TextBox pr_tb_user;
        public System.Windows.Forms.TextBox pr_tb_ip;
        public System.Windows.Forms.TextBox pr_tb_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
    }
}