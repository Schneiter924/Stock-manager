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
    public partial class frmInventaire : Form
    {
        public frmInventaire()
        {
            InitializeComponent();
        }
        Connection_mySQL smsql = new Connection_mySQL();
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void chargerLstInventaireLoue()
        {
            lstInventaireLoue.Items.Clear();
            List<Location> lstLocation = smsql.LocationEnCours();
            lblListeLocationTotal.Text = "Nombre de location en cours " + lstLocation.Count();
            foreach (Location location in lstLocation)
            {
                lstInventaireLoue.Items.Add(location.DescriptionLocation());
            }
        }
        private void chargerLstProduit()
        {
            lstInventaireStock.Items.Clear();
            List<Produit> lstProduit = smsql.chargeProduitEnStock();
            int nombreProduitEnStocke = smsql.CompteProduitEnStock();
            int nombreTotalProduit = smsql.CompteProduitTotal();
            lblProduitEnStockEtTotal.Text = "Nombre de produit en stock : " + nombreProduitEnStocke + " \\ nombre de produit total : " + nombreTotalProduit;
            foreach (Produit produit in lstProduit)
            {
                lstInventaireStock.Items.Add(produit.DescriptionProduitAvecID());
            }
        }

        private void frmInventaire_Load(object sender, EventArgs e)
        {

            chargerLstInventaireLoue();
            chargerLstProduit();            
        }

        private void frmInventaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdChercher_Click(object sender, EventArgs e)
        {
            if (txtChercher.Text != "")
            {
                lstInventaireLoue.Items.Clear();
                lstInventaireStock.Items.Clear();

                List<Location> lstLocations = smsql.RechercherMotCleLocation(txtChercher.Text);
                List<Produit> lstProduits = smsql.RechercherMotCleStock(txtChercher.Text);

                foreach (Produit produit in lstProduits)
                {
                    lstInventaireStock.Items.Add(produit.DescriptionProduitAvecID());
                }

                foreach (Location location in lstLocations)
                {
                    lstInventaireLoue.Items.Add(location.DescriptionLocation());
                }
            }
        }

        private void cmdToutVoir_Click(object sender, EventArgs e)
        {
            chargerLstInventaireLoue();
            chargerLstProduit();
        }
    }
}
