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

        Produit produit;
        Connection_mySQL smsql = new Connection_mySQL();

        public frmEntree()
        {
            InitializeComponent();
            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            foreach (Produit produit in lstProduits)
            {
                cboIDPiece.Items.Add(produit.DescriptionID());
            }
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjout_Click(object sender, EventArgs e)
        {
            
           
            if (produit != null)
            {
                produit.IdProduit = produit.IdProduit;
                produit.NomProduit = txtNom.Text;
                produit.Description = txtDescription.Text;
                smsql.Modificationproduit(produit);
            }
            else
            {
                produit = new Produit();
                produit.IdProduit = Convert.ToInt32(cboIDPiece.Text);
                produit.NomProduit = txtNom.Text;
                produit.Description = txtDescription.Text;
                smsql.NouveauProduit(produit);
            }

            cboIDPiece.Text = "";
            txtNom.Text = "";
            txtDescription.Text = "";
            cboIDPiece.Enabled = true;

            cboIDPiece.Items.Clear();

            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            foreach (Produit produit in lstProduits)
            {
                cboIDPiece.Items.Add(produit.DescriptionID());
            }
        }
                
        private void cboIDPiece_Validated(object sender, EventArgs e)
        {
            if (cboIDPiece.Text != "")
            {
                try
                {
                    int ID = Int32.Parse(cboIDPiece.Text);
                    if (smsql.TestIDProduit(ID) != null)
                    {
                        produit = smsql.RetourtProduit(ID);
                        cboIDPiece.Enabled = false;
                        txtNom.Text = produit.NomProduit;
                        txtDescription.Text = produit.Description;
                        cmdAjout.Text = "Modification";
                    }
                    else
                    {
                        cboIDPiece.Enabled = false;
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
}
