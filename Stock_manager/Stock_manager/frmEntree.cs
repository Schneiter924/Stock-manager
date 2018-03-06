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
        Produit produit;
        Connection_mySQL smsql = new Connection_mySQL();

        public frmEntree()
        {
            InitializeComponent();
            chargerProduit();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjout_Click(object sender, EventArgs e)
        {

            if (cboIDPiece.Text != "")
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
                    produit.NomProduit = txtNom.Text;
                    produit.Description = txtDescription.Text;
                    smsql.NouveauProduit(produit);
                }
            }
            cboIDPiece.Text = "";
            txtNom.Text = "";
            txtDescription.Text = "";
            cboIDPiece.Enabled = true;
            chargerProduit();
            produit = null;
        }

        public void chargerProduit()
        {
            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            cboIDPiece.Items.Clear();
            cboIDPiece.Items.Add("Ajouter un produit");
            foreach (Produit produit in lstProduits)
            {
                cboIDPiece.Items.Add(produit.DescriptionID());
            }
        }
          
        private void frmEntree_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cboIDPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIDPiece.SelectedIndex != 0)
            {
                try
                {
                    if (smsql.TestIDProduit(Convert.ToInt32(cboIDPiece.Text)) != null)
                    {
                        produit = smsql.RetourtProduit(Convert.ToInt32(cboIDPiece.Text));
                        txtNom.Text = produit.NomProduit;
                        txtDescription.Text = produit.Description;
                        cmdAjout.Text = "Modification";
                    }
                }
                catch (FormatException ex)
                {
                    string message = ex.Message;
                    string legende = "Erreur";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtNom.Text = "";
                txtDescription.Text = "";
                cmdAjout.Text = "Ajouter";
            }
        }
    }
}
