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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
           new Clienti_form().Show();
            this.Hide();
        }

        private void MasiniBtn_Click(object sender, EventArgs e)
        {
            new Masini_form().Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
