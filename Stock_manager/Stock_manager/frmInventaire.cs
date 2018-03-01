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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void frmInventaire_Load(object sender, EventArgs e)
        {
            Connection_mySQL smsql = new Connection_mySQL();

            List<Location> lstLocation = smsql.LocationEnCours();
            lblListeLocationTotal.Text = "Nombre de location en cour " + lstLocation.Count();
            foreach (Location location in lstLocation)
            {
                lstInventaireLoue.Items.Add(location.DescriptionLocation());
            }
            List<Produit> lstProduit = smsql.chargeProduitEnStock();
            int nombreProduitEnStocke = smsql.CompteProduitEnStock();
            lblProduitEnStockEtTotal.Text = "Nombre de produit en stock : " + nombreProduitEnStocke + " \\ nombre de produit total : " + lstProduit.Count();
            foreach (Produit produit in lstProduit)
            {
                lstInventaireStock.Items.Add(produit.DescriptionProduitAvecID());
            }
        }
    }
}
