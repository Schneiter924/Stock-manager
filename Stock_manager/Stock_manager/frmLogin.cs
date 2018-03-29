using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stock_manager
{
    public partial class frmLogin : Form
    {
        Cryptage cryPassword;
        Cryptage cryLogin;
        XML xml = new XML(Environment.GetEnvironmentVariable("APPDATA") + "\\stock_manager\\", "config.xml");

        public frmLogin()
        {
            InitializeComponent();
            cryPassword = new Cryptage(Environment.GetEnvironmentVariable("APPDATA") + "\\stock_manager", "pwd.txt");
            cryLogin = new Cryptage(Environment.GetEnvironmentVariable("APPDATA") + "\\stock_manager", "login.txt");
            
        }

        private void cmdConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text == "")
                {
                    throw new Exception("Nom d'utilisateur vide");
                }
                else if (cryLogin.TestLogin(txtLogin.Text) == false)
                {
                    throw new Exception("Nom d'utilisateur inconnu");
                }
                else if (txtPassword.Text == "")
                {
                    throw new Exception("Mot de passe vide");
                }
                else if (cryPassword.TestPassword(txtPassword.Text) == false)
                {
                    throw new Exception("Mot de passe inconnu");
                }
                else if (cryPassword.TestPassword(txtPassword.Text))
                {
                    Connection_mySQL smsql = new Connection_mySQL();
                    if (smsql.TestConnexion() == true)
                    {
                        Form frmMenu = new frmMenu();
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Erreur dans la configuration des paramètres de connexion au serveur");
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
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
                Form frmLo = new frmPremierLogin();
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

        private void cmdOption_Click(object sender, EventArgs e)
        {
            Form frmCo = new frmConfig();
            frmCo.ShowDialog();
        }
    }
}
