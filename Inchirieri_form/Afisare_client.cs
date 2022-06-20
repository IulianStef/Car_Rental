using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using StocareDate;

namespace Inchirieri_form
{
    public partial class Afisare_client : Form
    {
        IStocareDataClienti adminClienti;
        public Afisare_client()
        {
            InitializeComponent();

            this.Size = new Size(1100, 650);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            //this.ForeColor = Color.LimeGreen;
            this.Text = "Afisare Clienti";
            this.CenterToScreen();

            ActualizareClientDGV();
        }
        private void ActualizareClientDGV()
        {
            ClientDGV.AutoGenerateColumns = false;

            ClientDGV.DataSource = null;
            adminClienti = StocareFactoryClient.GetAdministratorStocare();
            ClientDGV.DataSource = adminClienti.GetClienti();
        }
        private void CautareBtn_Click(object sender, EventArgs e)
        {
            Client clientCautat = adminClienti.GetClient(NumeClientTb.Text, PrenumeClientTb.Text);
            if (clientCautat != null)
            {
                RezultatCautareClientlb.Items.Add(clientCautat.ConversieLaSir_PentruFisier());
            }
            else
            {
                MessageBox.Show("Clientul cautat nu este inregistrat");
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ClientDGV.DataSource = null;
            adminClienti = StocareFactoryClient.GetAdministratorStocare();
            ClientDGV.DataSource = adminClienti.GetClienti();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Close();
            new Clienti_form().Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Close();
            new Clienti_form().Show();
        }
    }
}
