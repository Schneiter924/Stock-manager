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
    public partial class frmReHis : Form
    {
        public frmReHis()
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

        private void frmReHis_Load(object sender, EventArgs e)
        {
            List<Produit> lstProduit = smsql.ToutLesProduit();
            foreach (Produit produit in lstProduit)
            {
                cboProduit.Items.Add(produit.DescriptionID());
            }
        }

        private void cmdChercher_Click(object sender, EventArgs e)
        {
            if (cboProduit.Text != "")
            {
                List<Location> lstLocations = smsql.Historique(Convert.ToInt32(cboProduit.Text));
                foreach (Location location in lstLocations)
                {
                    lstRecherche.Items.Add(location.DescriptionLocation());
                }
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
