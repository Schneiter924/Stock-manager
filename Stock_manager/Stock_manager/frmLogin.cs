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
        public frmLogin()
        {
            InitializeComponent();
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
            else if (txtLogin.Text != "vendeur")
            {
                string message = "Nom d'utilisateur inconnu";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != "Pa$$w0rd")
            {
                string message = "Mot de passe inconnu";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else
            {
                Form frmMenu = new frmMain();
                frmMenu.Show();
                this.Hide();
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }
    }
}
