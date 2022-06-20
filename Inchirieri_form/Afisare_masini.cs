using LibrarieModele;
using StocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inchirieri_form
{
    public partial class Afisare_masini : Form
    {
        IStocareDataMasini adminMasini;
        public Afisare_masini()
        {
            InitializeComponent();

            this.Size = new Size(900, 450);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            //this.ForeColor = Color.LimeGreen;
            this.Text = "Afisare Masini";
            this.CenterToScreen();
            ActualizareMasinaDGV();
        }
        private void ActualizareMasinaDGV()
        {
            MasinaDGV.AutoGenerateColumns = false;
            MasinaDGV.DataSource = null;
            adminMasini = StocareFactoryMasina.GetAdministratorStocare();
            MasinaDGV.DataSource = adminMasini.GetMasini();
        }

        private void CautareBtn_Click(object sender, EventArgs e)
        {
            //RezultatCautareMasinalb.Items.Clear();     
            Masina masinaCautata = adminMasini.GetMasina(MarcaMasinaTb.Text, ModelMasinaTb.Text);
            if (masinaCautata != null)
            {
                RezultatCautareMasinalb.Items.Add(masinaCautata.ConversieLaSir_PentruFisier());
            }
            else
            {
                MessageBox.Show("Masina nu este disponibila");
            }    
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            MasinaDGV.DataSource = null;
            IStocareDataMasini adminMasini = StocareFactoryMasina.GetAdministratorStocare();
            MasinaDGV.DataSource = adminMasini.GetMasini();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(this.MasinaDGV.SelectedRows.Count>0)
            {
                MasinaDGV.Rows.RemoveAt(MasinaDGV.SelectedRows[0].Index);
            }
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Close();
            new Masini_form().Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Close();
            new Masini_form().Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
