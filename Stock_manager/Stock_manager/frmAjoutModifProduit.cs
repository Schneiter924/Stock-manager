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
    public partial class frmAjoutModifProduit : Form
    {
        Produit produit;
        Connection_mySQL smsql = new Connection_mySQL();

        public frmAjoutModifProduit()
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

            if (produit != null)
            {
                produit.IdProduit = produit.IdProduit;
                produit.NomProduit = txtNomProduit.Text;
                produit.Description = txtDescription.Text;
                smsql.ModificationProduit(produit);
                cboIDProduit.Text = "";
                txtNomProduit.Text = "";
                txtDescription.Text = "";
                cboIDProduit.Enabled = true;
                chargerProduit();
                produit = null;
                string message = "Le produit a bien été modiffier";
                string legende = "Information";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(message, legende, bouton, icon);
            }
            else
            {
                if (txtNomProduit.Text != "")
                {
                    produit = new Produit();
                    produit.NomProduit = txtNomProduit.Text;
                    produit.Description = txtDescription.Text;
                    smsql.NouveauProduit(produit);
                    cboIDProduit.Text = "";
                    txtNomProduit.Text = "";
                    txtDescription.Text = "";
                    cboIDProduit.Enabled = true;
                    chargerProduit();
                    produit = null;
                    string message = "Le produit a bien été ajouter";
                    string legende = "Information";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(message, legende, bouton, icon);
                }
                else
                {

                }
            }
        }

        public void chargerProduit()
        {
            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            cboIDProduit.Items.Clear();
            cboIDProduit.Items.Add("Ajouter un produit");
            foreach (Produit produit in lstProduits)
            {
                cboIDProduit.Items.Add(produit.DescriptionID());
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
            if (cboIDProduit.SelectedIndex != 0)
            {
                try
                {
                    if (smsql.TestIDProduit(Convert.ToInt32(cboIDProduit.Text)) != null)
                    {
                        produit = smsql.RetourProduit(Convert.ToInt32(cboIDProduit.Text));
                        txtNomProduit.Text = produit.NomProduit;
                        txtDescription.Text = produit.Description;
                        cmdAjout.Text = "Modification";
                        cmdSupprimer.Visible = true;
                        cmdSupprimer.Enabled = true;
                        cmdRetour.TabIndex = 4;
                        cmdSupprimer.TabIndex = 5;
                        cmdAjout.TabIndex = 6;
                        cmdRetour.Location = new Point(99, 205);
                    }
                }
                catch (FormatException ex)
                {
                    string message = ex.Message;
                    string legende = "Erreur";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, legende, bouton, icon);
                }
            }
            else
            {
                txtNomProduit.Text = "";
                txtDescription.Text = "";
                cmdAjout.Text = "Ajouter";
                cmdSupprimer.Enabled = false;
                cmdSupprimer.Visible = false;
                txtDescription.TabIndex = 3;
                cmdRetour.TabIndex = 4;
                cmdAjout.TabIndex = 5;
                cmdRetour.Location = new Point(180, 205);
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            string nomProduit = txtNomProduit.Text;
            int nombreCaractereMax = 45;
            int nombreCaractereActuelle = nomProduit.Count();

            lblNombreCaractere.Text = "Nombre de caractère actuelle " + nombreCaractereActuelle + " / nombre max de caractère " + nombreCaractereMax;
            if (nombreCaractereActuelle > nombreCaractereMax)
            {
                string message = "Dépassement du nombre de caratère autorise";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
                nomProduit = nomProduit.Substring(0, 45);
                txtNomProduit.Text = nomProduit;
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            string message = "Confirmation de la suppresion du Produit : " + produit.NomProduit;
            string legende = "Information";
            MessageBoxButtons bouton = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult dialogResult = MessageBox.Show(message, legende, bouton, icon);
            if (dialogResult == DialogResult.Yes)
            {
                smsql.SupprimerProduit(produit);
                chargerProduit();
                message = "Le produit a bien été supprimer";
                legende = "Information";
                bouton = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Information;
                MessageBox.Show(message, legende, bouton, icon);
            }
        }

        private void frmEntree_Load(object sender, EventArgs e)
        {
            chargerProduit();
            cmdSupprimer.Enabled = false;
            cmdSupprimer.Visible = false;
            cboIDProduit.TabIndex = 1;
            txtNomProduit.TabIndex = 2;
            txtDescription.TabIndex = 3;
            cmdRetour.TabIndex = 4;
            cmdAjout.TabIndex = 5;
            cmdRetour.Location = new Point(180, 205);
        }
    }
}
