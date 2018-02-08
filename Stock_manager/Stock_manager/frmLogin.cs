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
        Cryptage cry;
        public frmLogin()
        {
            InitializeComponent();
            cry = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "pwd.txt");
            
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
            else if (txtLogin.Text != "vendeur")
            {
                string message = "Nom d'utilisateur inconnu";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            else if (cry.TestPassword(txtPassword.Text) ==  true)
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

        private void cmdMdPPerdu_Click(object sender, EventArgs e)
        {
            Form frmMp = new frmNouveauMotPasse();
            frmMp.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (cry.TestFichier()==false)
            {
                Form frmMp = new frmNouveauMotPasse();
                frmMp.ShowDialog();
                this.Hide();
            }
        }
    }
}
