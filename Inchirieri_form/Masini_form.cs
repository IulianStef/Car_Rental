using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using StocareDate;
using static LibrarieModele.Masina;

namespace Inchirieri_form
{
    public partial class Masini_form : Form
    {
        public Masini_form()
        {
            InitializeComponent();
            this.CenterToScreen();
            //setare proprietati
            this.Size = new Size(420, 520);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
           //   this.ForeColor = Color.LimeGreen;
            this.Text = "Adaugare Masina";
            this.CenterToScreen();
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            new Menu().Show();
        }
        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            new Menu().Show();
        }
        private Culori GetCuloareSelectata()
        {
            if (rdbAlb.Checked)
                return Culori.alb;
            if (rdbNegru.Checked)
                return Culori.negru;
            if (rdbArgintiu.Checked)
                return Culori.argintiu;
            if (rdbAuriu.Checked)
                return Culori.auriu;
            if (rdbAlbastru.Checked)
                return Culori.albastru;
            if (rdbGri.Checked)
                return Culori.gri;
            if (rdbPortocaliu.Checked)
                return Culori.portocaliu;
            if (rdbVerde.Checked)
                return Culori.verde;
            if (rdbTurcoaz.Checked)
                return Culori.turcoaz;
            return Culori.alb;
        }
        private Motorizari GetMotorizare()
        {
            if (rdbBenzina.Checked)
                return Motorizari.Benzina;
            if (rdbDiesel.Checked)
                return Motorizari.Diesel;
            if (rdbHibrid.Checked)
                return Motorizari.Hibrid;
            if (rdbElectric.Checked)
                return Motorizari.Electric;
            return Motorizari.Benzina;
        }
        private Transmisii GetTransmisie()
        {
            if (rdbCutieAutomata.Checked)
                return Transmisii.CutieAutomata;
            if (rdbCutieManuala.Checked)
                return Transmisii.CutieManuala;
            return Transmisii.CutieManuala;
        }
        private Optiuni GetOptiuni()
        {
            Optiuni o=0;
            if (ckbAC.Checked)
                o |= Optiuni.AerConditionat;
            if (ckbGeamuriElectrice.Checked)
                o |= Optiuni.GeamuriElectrice;
            if (ckbNavigatie.Checked)
                o |= Optiuni.Navigatie;  
            if (ckbFaruriCeata.Checked)
                o |= Optiuni.FaruriCeata;
            if (ckbScauneIncalzite.Checked)
                o |= Optiuni.ScauneIncalzite;
            if (ckbOglinziIncalzite.Checked)
                o |= Optiuni.OglinziIncalzite;          
            return o;
        }
        private bool DateValide()
        {
            if (LabelEroareFirma.Text.Length == 0 && LabelEroareModel.Text.Length == 0 && LabelEroareAn.Text.Length == 0)
                return true;
            return false;
        }
        private void ResetareControale()
        {
            FirmaMasinaTb.Text = ModelMasinaTb.Text = AnFabricatieTb.Text = string.Empty;

            rdbAlb.Checked = false;
            rdbNegru.Checked = false;
            rdbArgintiu.Checked = false;
            rdbAuriu.Checked = false;
            rdbAlbastru.Checked = false;
            rdbGri.Checked = false;
            rdbPortocaliu.Checked = false;
            rdbVerde.Checked = false;
            rdbTurcoaz.Checked = false;

        }
        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            if (!DateValide())
            {
                MessageBox.Show("Datele introduse sunt incorecte!\n" +
                    "Incercati din nou!");
                return;
            }
            else
            {
                Masina m = new Masina(0, FirmaMasinaTb.Text, ModelMasinaTb.Text, AnFabricatieTb.Text);
                //setare Culoare Masina
                //verificare radioButton selectat
                Culori culoareSelectata = GetCuloareSelectata();
                m.CuloriDisponibile = culoareSelectata;

                //setare Motorizare Masina
                //verificare radioButton selectat
                m.MotorizariDisponibile = GetMotorizare();

                //setare optiuni Masina
                m.OptiuniDisponibile = GetOptiuni();

                //setare transmisie Masina
                m.TransmisieDisponibila = GetTransmisie();

                m.disponibilitate = true;
                IStocareDataMasini adminMasini = StocareFactoryMasina.GetAdministratorStocare();
                adminMasini.AddMasina(m);

                //resetarea controalelor pentru a introduce datele unei masini noi
                ResetareControale();
            }
        }
        void eventFirmaTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirmaMasinaTb.Text))
            {
                LabelEroareFirma.Text = string.Empty;
            }
            else if (FirmaMasinaTb.Text.Length > 15 || !FirmaMasinaTb.Text.All(char.IsLetter))
            {
                LabelEroareFirma.Text = "Firma incorecta";
            }
            else LabelEroareFirma.Text = string.Empty;
        }
        void eventModelTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModelMasinaTb.Text))
            {
                LabelEroareModel.Text = string.Empty;
            }
            else if (ModelMasinaTb.Text.Length > 10 || !Regex.IsMatch(ModelMasinaTb.Text, @"^[a-zA-Z0-9]"))
            {
                LabelEroareModel.Text = "Model incorect";
            }
            else LabelEroareModel.Text = string.Empty;
        }
        void eventAnFabricatieTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AnFabricatieTb.Text))
            {
                LabelEroareAn.Text = string.Empty;
            }
            else if (AnFabricatieTb.Text.Length > 5 || !AnFabricatieTb.Text.All(char.IsDigit))
            {
                LabelEroareAn.Text = "An incorect";
            }
            else if(AnFabricatieTb.Text[0]=='0')
                LabelEroareAn.Text = "An incorect";
            else LabelEroareAn.Text = string.Empty;
        }

        private void AfisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Afisare_masini().Show();
        }

    }
}
