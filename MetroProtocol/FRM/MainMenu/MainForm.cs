using Converx.FRM.Tracciati;
using MetroProtocol;
using System;

namespace Converx.FRM.MainMenu
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            this.ControlBox = false;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            InitializeComponent();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btnSeqana_Click(object sender, EventArgs e)
        {
            TracciatiEsterni tracciati = new TracciatiEsterni();
            this.Hide();
            tracciati.Show();
        }

        private void btnClose_Click(object sender, EventArgs e) { Environment.Exit(Environment.ExitCode); }
    }
}
