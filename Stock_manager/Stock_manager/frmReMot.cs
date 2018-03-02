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
    public partial class frmReMot : Form
    {
        public frmReMot()
        {
            InitializeComponent();
        }
        Connection_mySQL smsql = new Connection_mySQL();
        
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmReMenu();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdChercher_Click(object sender, EventArgs e)
        {
            lstRecherche.Items.Clear();
            if (txtRecherche.Text != "")
            {
                List<Produit> lstProduits = smsql.RechercherMotCle(txtRecherche.Text);
                foreach (Produit produit in lstProduits)
                {
                    lstRecherche.Items.Add(produit.DescriptionProduitAvecID());
                }
                lstProduits.Clear();
            }
            else
            {
                string message = "Pas de Produit sélectionne";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
            }
        }
    }
}
