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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
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
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == "")
            {
                string message = "mot de passe vide";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword2.Text == "")
            {
                string message = "mot de passe vide";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPassword2.Text)
            {
                string message = "mot de passe différent";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else
            {
                cryLogin.CrypterLogin(txtLogin.Text);
                cryPassword.CrypterPassword(txtPassword.Text);
                this.Dispose();
            }
        }
    }
}
