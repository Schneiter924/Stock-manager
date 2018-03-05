using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager
{
    public partial class frmNouveauLogin : Form
    {
        Cryptage cryLogin;
        Cryptage cryPassword;
        public frmNouveauLogin()
        {
            InitializeComponent();
            cryPassword = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "pwd.txt");
            cryLogin = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "login.txt");
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                string message = "login vide";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == "")
            {
                string message = "mot de passe vide";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword2.Text == "")
            {
                string message = "mot de passe vide";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPassword2.Text)
            {
                string message = "mot de passe différent";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
            }
            else
            {
                cryLogin.CrypterLogin(txtLogin.Text);
                cryPassword.CrypterPassword(txtPassword.Text);
                this.Dispose();
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            txtPassword2.SelectAll();
        }

        private void frmNouveauLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
