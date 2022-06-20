using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StocareDate;
using LibrarieModele;
using System.Text.RegularExpressions;
using static LibrarieModele.Client;

namespace Inchirieri_form
{
    public partial class Clienti_form : Form
    {
        //AdministrareClienti_FisierText AdminClienti;
        IStocareDataClienti adminClienti;
        //constante
        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;
        private const int OFFSET_X = 200;
        private const int OFFSET = 370;

        private Label lblNumeClient;
        private Label lblPrenumeClient;
        private Label lblCNPClient;
        private Label lblTelefonClient;

        private Label[] lblsNumeClient;
        private Label[] lblsPrenumeClient;
        private Label[] lblsCNPClient;
        private Label[] lblsTelefonClient;
        public Clienti_form()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            //AdminClienti = new AdministrareClienti_FisierText(caleCompletaFisier);
            adminClienti = StocareFactoryClient.GetAdministratorStocare();
            InitializeComponent();

            //setare proprietati
            this.Size = new Size(360, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
           // this.ForeColor = Color.LimeGreen;
            this.Text = "Adaugare Client";
            this.CenterToScreen();
            // AfiseazaClienti();
        }

        private void Clienti_form_Load(object sender, EventArgs e)
        {
            List<Client> clienti = adminClienti.GetClienti();
            AfiseazaClienti(clienti);
        }
        private void AfiseazaClienti(List<Client> clienti)
        {
            //adaugare control de tip label pentru 'Nume'
            lblNumeClient = new Label();
            lblNumeClient.Width = LATIME_CONTROL;
            lblNumeClient.Text = "Nume";
            lblNumeClient.Left = 2 * OFFSET_X + 0;
            lblNumeClient.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblNumeClient);

            //adaugare control de tip label pentru 'Prenume'
            lblPrenumeClient = new Label();
            lblPrenumeClient.Width = LATIME_CONTROL;
            lblPrenumeClient.Text = "Prenume";
            lblPrenumeClient.Left = 2 * OFFSET_X + DIMENSIUNE_PAS_X;
            lblPrenumeClient.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblPrenumeClient);

            //adaugare control de tip label pentru 'CNP'
            lblCNPClient = new Label();
            lblCNPClient.Width = LATIME_CONTROL;
            lblCNPClient.Text = "CNP";
            lblCNPClient.Left = 2 * OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblCNPClient.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblCNPClient);

            //adaugare control de tip label pentru 'Telefon'
            lblTelefonClient = new Label();
            lblTelefonClient.Width = LATIME_CONTROL;
            lblTelefonClient.Text = "Nr Telefon";
            lblTelefonClient.Left = 2 * OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblTelefonClient.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblTelefonClient);

            int NrClienti = clienti.Count;
            lblsNumeClient = new Label[NrClienti];
            lblsPrenumeClient = new Label[NrClienti];
            lblsCNPClient = new Label[NrClienti];
            lblsTelefonClient = new Label[NrClienti];

            int i = 0;
            foreach (Client client in clienti)
            {
                //adaugare control de tip label pentru numele clientilor
                lblsNumeClient[i] = new Label();
                lblsNumeClient[i].Width = LATIME_CONTROL;
                lblsNumeClient[i].Text = client.nume;
                lblsNumeClient[i].Left = 2 * OFFSET_X + 0;
                lblsNumeClient[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNumeClient[i]);

                //adaugare control de tip label pentru prenumele clientilor
                lblsPrenumeClient[i] = new Label();
                lblsPrenumeClient[i].Width = LATIME_CONTROL;
                lblsPrenumeClient[i].Text = client.prenume;
                lblsPrenumeClient[i].Left = 2 * OFFSET_X + DIMENSIUNE_PAS_X;
                lblsPrenumeClient[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenumeClient[i]);

                //adaugare control de tip label pentru CNP-ul clientilor
                lblsCNPClient[i] = new Label();
                lblsCNPClient[i].Width = LATIME_CONTROL;
                lblsCNPClient[i].Text = client.cnp;
                lblsCNPClient[i].Left = 2 * OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsCNPClient[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCNPClient[i]);

                //adaugare control de tip label pentru numarul de telefon al clientilor
                lblsTelefonClient[i] = new Label();
                lblsTelefonClient[i].Width = LATIME_CONTROL;
                lblsTelefonClient[i].Text = client.telefon;
                lblsTelefonClient[i].Left = 2 * OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsTelefonClient[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCNPClient[i]);

                i++;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(DateValide())
            {
                Client c = new Client(0, NumeClientTb.Text, PrenumeClientTb.Text, CnpClientTb.Text, TelefonClientTb.Text);
                //setare Gen Client
                c.GenClient = GetGen();
                adminClienti.AddClient(c);
                ResetareControale();
            }
            else
            {
                MessageBox.Show("Datele introduse sunt incorecte!\n" +
                    "Incercati din nou!");
                return;
            }
        }

        private void AfisBtn_Click(object sender, EventArgs e)
        {
            /*this.Size = new Size(3 * Width, Height);
            this.CenterToScreen();
            List<Client> clienti = adminClienti.GetClienti();
            AfiseazaClienti(clienti);
            */
            new Afisare_client().Show();           
        }
        private Gen GetGen()
        {
            if (rdbMasculin.Checked)
                return Gen.masculin;
            if (rdbFeminin.Checked)
                return Gen.feminin;
            return Gen.neutru;
        }
        //
        //validari
        //validare caseta text Nume
        void eventNumeClientTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumeClientTb.Text))
            {
                LabelEroareNume.Text = string.Empty;
            }
            else if (NumeClientTb.Text.Length > 15 || !Regex.IsMatch(NumeClientTb.Text, @"^[a-zA-Z]+$"))
            {
                LabelEroareNume.Text = "Nume incorect";
            }
            else LabelEroareNume.Text = string.Empty;
        }

        //validare caseta text Prenume
        void eventPrenumeClientTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrenumeClientTb.Text))
            {
                LabelEroarePrenume1.Text = string.Empty;
            }
            else if (PrenumeClientTb.Text.Length > 15 || !PrenumeClientTb.Text.All(char.IsLetter))
            {
                LabelEroarePrenume1.Text = "Prenume incorect";
            }
            else LabelEroarePrenume1.Text = string.Empty;
        }

        //validare caseta text CNP

        void eventCnpClientTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CnpClientTb.Text))
            {
                LabelEroareCnp.Text = string.Empty;
            }
            else if (CnpClientTb.Text.Length != 13 || !CnpClientTb.Text.All(char.IsDigit))
            {
                LabelEroareCnp.Text = "Cnp invalid(sunt necesare 13 caractere)";
            }
            else LabelEroareCnp.Text = string.Empty;
        }

        //validare caseta text numar de telefon

        void eventTelefonClientTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TelefonClientTb.Text))
            {
                LabelEroareTelefon.Text = string.Empty;
            }
            else if (/*TelefonClientTb.Text.Length != 10||*/ !TelefonClientTb.Text.All(char.IsDigit))
            {
                LabelEroareTelefon.Text = "Numar de telefon invalid";
            }
            else LabelEroareTelefon.Text = string.Empty;
        }

        //focus NumeClientTb
        private void NumeClientTb_GotFocus(Object sender, EventArgs e)
        {
            this.NumeClientTb.BackColor = Color.FromArgb(180, 229, 250);
        }

        private void NumeClientTb_LostFocus(Object sender, EventArgs e)
        {
            this.NumeClientTb.BackColor = Color.FromArgb(237, 245, 245);
        }

        //focus PrenumeClientTb

        private void PrenumeClientTb_GotFocus(Object sender, EventArgs e)
        {
            this.PrenumeClientTb.BackColor = Color.FromArgb(180, 229, 250);
        }

        private void PrenumeClientTb_LostFocus(Object sender, EventArgs e)
        {
            this.PrenumeClientTb.BackColor = Color.FromArgb(237, 245, 245);
        }

        //focus CnpClientTb

        private void CnpClientTb_GotFocus(Object sender, EventArgs e)
        {
            this.CnpClientTb.BackColor = Color.FromArgb(180, 229, 250);
        }

        private void CnpClientTb_LostFocus(Object sender, EventArgs e)
        {
            this.CnpClientTb.BackColor = Color.FromArgb(237, 245, 245);
        }

        //focus TelefonClientTb

        private void TelefonClientTb_GotFocus(Object sender, EventArgs e)
        {
            this.TelefonClientTb.BackColor = Color.FromArgb(180, 229, 250);
        }

        private void TelefonClientTb_LostFocus(Object sender, EventArgs e)
        {
            this.TelefonClientTb.BackColor = Color.FromArgb(237, 245, 245);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }
        //functii testare date valide
        private bool DateValide()
        {
            if(LabelEroareNume.Text.Length==0 && LabelEroarePrenume1.Text.Length==0 && 
                LabelEroareCnp.Text.Length==0 && LabelEroareTelefon.Text.Length==0)
            {
                return true;
            }
            else
            { return false; }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetareControale()
        {
            NumeClientTb.Text = PrenumeClientTb.Text = CnpClientTb.Text = TelefonClientTb.Text = string.Empty;
        }
    }
}
