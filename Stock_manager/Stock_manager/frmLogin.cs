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
        XML xml = new XML();

        public frmLogin()
        {
            InitializeComponent();
            cryPassword = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "pwd.txt");
            cryLogin = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "login.txt");
            
        }

        private void cmdConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                string message = "Nom d'utilisateur vide";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
            }
            else if (cryLogin.TestLogin(txtLogin.Text) == false)
            {
                string message = "Nom d'utilisateur inconnu";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
            }
            else if (txtPassword.Text == "")
            {
                string message = "Mot de passe vide";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
            }
            else if (cryPassword.TestPassword(txtPassword.Text) == false)
            {
                string message = "Mot de passe inconnu";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
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
            if (xml.TestFichierXML() == false)
            {
                xml.EcritureXMLDefaut();
            }
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

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmCo = new frmConfig();
            frmCo.ShowDialog();
        }
    }
}
