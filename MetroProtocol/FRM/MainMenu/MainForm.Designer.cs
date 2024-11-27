namespace Converx.FRM.MainMenu
{
    partial class MainForm
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
            this.btnConversion = new MetroFramework.Controls.MetroButton();
            this.btnTracciatiExt = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnConversion
            // 
            this.btnConversion.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConversion.Location = new System.Drawing.Point(43, 141);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(214, 101);
            this.btnConversion.TabIndex = 0;
            this.btnConversion.Text = "&Conversioni";
            this.btnConversion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnConversion.UseSelectable = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // btnTracciatiExt
            // 
            this.btnTracciatiExt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTracciatiExt.Location = new System.Drawing.Point(323, 141);
            this.btnTracciatiExt.Name = "btnTracciatiExt";
            this.btnTracciatiExt.Size = new System.Drawing.Size(214, 101);
            this.btnTracciatiExt.TabIndex = 1;
            this.btnTracciatiExt.Text = "&Tracciati Esterni";
            this.btnTracciatiExt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTracciatiExt.UseSelectable = true;
            this.btnTracciatiExt.Click += new System.EventHandler(this.btnSeqana_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(543, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "&X";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTracciatiExt);
            this.Controls.Add(this.btnConversion);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Converx - Menù";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnConversion;
        private MetroFramework.Controls.MetroButton btnTracciatiExt;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}