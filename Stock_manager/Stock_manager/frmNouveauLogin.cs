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
        Cryptage cry;
        public frmNouveauLogin()
        {
            InitializeComponent();
            cry = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "login.txt");
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
            txtLogin2.Text = "";
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == txtLogin2.Text)
            {
                cry.CrypterLogin(txtLogin.Text);
                this.Dispose();
            }
            else
            {
                string message = "login different";
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
        }
    }
}
