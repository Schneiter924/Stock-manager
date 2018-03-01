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
    public partial class frmLogin : Form
    {
        Cryptage cryPassword;
        Cryptage cryLogin;
        public frmLogin()
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

        private void cmdConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                string message = "Nom d'utilisateur vide";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                string message = "Mot de passe vide";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (cryLogin.TestLogin(txtLogin.Text)== false)
            {
                string message = "Nom d'utilisateur inconnu";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (cryPassword.TestPassword(txtPassword.Text) == false)
            {
                string message = "Mot de passe inconnu";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (cryPassword.TestPassword(txtPassword.Text))
            {
                Form frmMenu = new frmMain();
                frmMenu.Show();
                this.Hide();
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if ((cryLogin.TestFichier()==false) || (cryPassword.TestFichier()==false))
            {
                Form frmLo = new frmNouveauLogin();
                frmLo.ShowDialog();                
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
    }
}
