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
    public partial class frmEntree : Form
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

        public frmEntree()
        {
            InitializeComponent();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjout_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Validated(object sender, EventArgs e)
        {
            Connection_mySQL smsql = new Connection_mySQL();
            try
            {
                int ID = Int32.Parse(txtNumero.Text);
                if (smsql.TestIDProduit(ID) != null)
                {
                    Produit produit = smsql.RetourtProduit(ID);
                    txtNom.Text = produit.NomProduit;
                    txtDescription.Text = produit.Description;
                }
                else
                {
                    txtNom.Text = "";
                    txtDescription.Text = "";
                }
                
            }
            catch (FormatException ex)
            {
                string message = ex.Message;
                string caption = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
            }
            
        }
    }
}
