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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTb.Text;
            string pass = PasswordTb.Text;
            if (username.Equals("admin") && pass.Equals("admin"))
            {
                MessageBox.Show("Succes!");
                Menu m = new Menu();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Username sau parola incorecte! Incercati din nou!");
                UserNameTb.Clear();
                PasswordTb.Clear();
                UserNameTb.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
