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
    public partial class frmSortie : Form
    {
        public frmSortie()
        {
            InitializeComponent();
        }

        Connection_mySQL smsql = new Connection_mySQL();

        DateTime Aujourdhui;
        
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
                Location location = new Location();
                Loueur loueur = smsql.LoueurSelectionnerNom(cboLoueur.Text);
                Produit produit = smsql.RetourtProduit(Convert.ToInt32(cboProduit.Text));
                location.StartDate = Aujourdhui;
                location.Loueur = loueur;
                location.Produit = produit;
                smsql.NouvelleLocation(location);
                chargerProduit();
                chargerLoueur();
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
            txtDuree.Text = "30 jours";
            DateTime trenteJours = Aujourdhui.AddDays(30);
            txtDateRetour.Text = trenteJours.ToString("dd-MM-yyyy");
            chargerLoueur();
            chargerProduit();            
        }

        private void cboLoueur_Validated(object sender, EventArgs e)
        {
            if (cboLoueur.Text != "")
            {                
                if (smsql.TestNomLoueur(cboLoueur.Text) == null)
                {
                    string message = "Loueur non trouvé dans la base de donnée";
                    string legende = "Information";
                    MessageBoxButtons boutonYes = MessageBoxButtons.YesNo;
                    MessageBoxIcon boutonIcon = MessageBoxIcon.Information;
                    MessageBox.Show(message, legende, boutonYes, boutonIcon);
                }
            }
        }

        private void chargerProduit()
        {
            List<Produit> lstProduits = smsql.chargeProduitEnStock();
            cboProduit.Items.Clear();
            foreach (Produit produit in lstProduits)
            {
                cboProduit.Items.Add(produit.DescriptionID());
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
    }
}
