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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        Connection_mySQL smsql = new Connection_mySQL();

        DateTime Aujourdhui;

        int duree;
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjout_Click(object sender, EventArgs e)
        {
            if ((cboLoueur.Text != "") && (cboProduit.Text != ""))
            {
                string temp = cboProduit.Text;

                int index = temp.IndexOf(" - ");

                temp = temp.Substring(0, index);

                Location location = new Location();
                Loueur loueur = smsql.LoueurSelectionnerNom(cboLoueur.Text);
                Produit produit = smsql.RetourProduit(Convert.ToInt32(temp));
                location.StartDate = Aujourdhui;
                location.Duree = duree;
                location.Loueur = loueur;
                location.Produit = produit;
                smsql.NouvelleLocation(location);
                txtDuree.Text = "";
                txtDateRetour.Text = "";
                chargerProduit();
                chargerLoueur();

                string message = "La location a bien été ajouter";
                string legende = "Information";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(message, legende, bouton, icon);

            }
            else
            {
                if (cboLoueur.Text == "")
                {
                    string message = "Pas de client sélectionne";
                    string legende = "Erreur";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, legende, bouton, icon);
                }
                if (cboProduit.Text == "")
                {
                    string message = "Pas de Produit sélectionne";
                    string legende = "Erreur";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(message, legende, bouton, icon);
                }
            }
        }

        private void frmSortie_Load(object sender, EventArgs e)
        {
            Aujourdhui = DateTime.Today;
            chargerLoueur();
            chargerProduit();
                     
        }

        private void chargerProduit()
        {
            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            cboProduit.Items.Clear();
            foreach (Produit produit in lstProduits)
            {
                cboProduit.Items.Add(produit.ProduitAvecIDEtNomProduit());
            }
        }

        public void chargerLoueur()
        {
            List<Loueur> lstLoueurs = smsql.chargeLoueur();
            cboLoueur.Items.Clear();
            foreach (Loueur loueur in lstLoueurs)
            {
                cboLoueur.Items.Add(loueur.Description());
            }
        }

        private void frmSortie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void txtDuree_Validated(object sender, EventArgs e)
        {
            if (txtDuree.Text!="")
            {
                try
                {
                    duree = int.Parse(txtDuree.Text);
                    
                    DateTime dureeDate = Aujourdhui.AddDays(duree);

                    txtDateRetour.Text = dureeDate.ToString("dd-MM-yyyy");
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
            
        }
    }
}
