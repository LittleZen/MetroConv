// Import declaration
using Converx.src;
using MetroFramework;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroProtocol.frm.Main
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private void btnClose_Click(object sender, EventArgs e) { Environment.Exit(Environment.ExitCode); }

        public frmMain()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.lblVersion.Text = $"v{Helper.converxVersion} - A";
            Helper.WriteLog(tbProtoLog, "Database connesso, in attesa...");
        }

        private async void btn_tbg05_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Tbg05...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnTbg05.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }

            Helper.WriteLog(tbProtoLog, "Fine generazione Tbg05!");
            pbLoading.Visible = false;
        }

        private async void btnSog01_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Sog01...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnSog01.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }
            Helper.WriteLog(tbProtoLog, "Fine Generazione Sog01!");
            pbLoading.Visible = false;
        }

        private async void btnCorris_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Corris...");
            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnCorris.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }

            Helper.WriteLog(tbProtoLog, "Fine Generazione Corris!");
            pbLoading.Visible = false;
        }

        private async void btnUffiprot_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Uffiprot...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnUffiprot.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }
            Helper.WriteLog(tbProtoLog, "Fine generazione Uffiprot!");
            pbLoading.Visible = false;
        }

        private async void btnDocproto_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Docproto...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnDocproto.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }
            Helper.WriteLog(tbProtoLog, "Fine generazione Docproto!");
            pbLoading.Visible = false;
        }

        private async void btnDocfisi_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Docfisi...");
            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Protocollo.{btnDocfisi.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato. Possibili Cause:\n\n•) Esiste la classe C# corrispondente nel comune selezionato?\n•) Hai dichiarato tutte le classi e i costruttori come public?\n•) Verifica la query su Navicat, potrebbe essere errata\n•) Hai perso la connessione al server.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }
            Helper.WriteLog(tbProtoLog, "Fine generazione Docfisi!");
            pbLoading.Visible = false;
        }

        private async void btnmepubblica_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Mepubblica...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Albo.{btnAlboMepubblica.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }
            Helper.WriteLog(tbProtoLog, "Fine Generazione Mepubblica!");
            pbLoading.Visible = false;
        }

        private async void btnAlboSog01_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione Sog01 [ALBO]...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Albo.{btnAlboSog01.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }

            Helper.WriteLog(tbProtoLog, "Fine Generazione Sog01 [ALBO]!");
            pbLoading.Visible = false;
        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            Helper.WriteLog(tbProtoLog, "Generazione MeAllegati [ALBO]...");

            try
            {
                string objectToInstantiate = $"{DBManager.getNamespace()}.Albo.{btnAlboMeAllegati.Text.Replace("&", "")}, Converx";
                var objectType = Type.GetType(objectToInstantiate);
                dynamic instantiatedObject = Activator.CreateInstance(objectType);

                await Task.Run(() => { instantiatedObject.Generate(checkBoxClear.Checked); });

                instantiatedObject = null; // Forza il garbage collector
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nErrore durante la generazione del tracciato.\nEsiste la classe C# corrispondente nel comune selezionato?\n Hai dichiarato tutte le classi e i costruttori come public?\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.WriteLog(tbProtoLog, $"ERRORE: {ex}");
                return;
            }

            Helper.WriteLog(tbProtoLog, "Fine Generazione MeAllegati [ALBO]!");
            pbLoading.Visible = false;
        }
    }
}
