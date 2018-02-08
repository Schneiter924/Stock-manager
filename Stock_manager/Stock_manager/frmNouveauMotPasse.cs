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
    public partial class frmNouveauMotPasse : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        Cryptage cry;
        public frmNouveauMotPasse()
        {
            InitializeComponent();
            cry = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "pwd.txt");
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            if (cry.TestFichier() == true)
            {
                Form frmLog = new frmLogin();
                frmLog.Show();
                this.Dispose();
            }
            else
            {
                string message = "aucun mot de passe définit";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtPassword2.Text)
            {
                cry.CrypterPassword(txtPassword.Text);
                Form frmLog = new frmLogin();
                frmLog.Show();
                this.Dispose();
            }
            else
            {
                string message = "aucun mot de passe définit";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
        }

        private void frmNouveauMotPasse_Load(object sender, EventArgs e)
        {
            if (cry.TestFichier()==false)
            {
                string message = "aucun mot de passe définit";
                string caption = "information";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Information);
            }
            
        }

        
    }
}
