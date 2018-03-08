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
    public partial class frmRetourLocation : Form
    {
        public frmRetourLocation()
        {
            InitializeComponent();
        }
        Connection_mySQL smsql = new Connection_mySQL();

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmM = new frmMain();
            frmM.Show();
            this.Dispose();
        }

        private void cmdRetourPiece_Click(object sender, EventArgs e)
        {
            if (cboProduit.Text != "")
            {
                int idProduit = Convert.ToInt32(cboProduit.Text);

                Location location = smsql.LocationSelectionner(idProduit);

                location.EndDate = DateTime.Today;

                smsql.RetourLocation(location);
                chargerProduit();
            }
            else
            {
                string message = "Pas de produit sélectionne";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, legende, bouton, icon);
            }            
        }

        private void frmRetourPiece_Load(object sender, EventArgs e)
        {
            chargerProduit();
        }

        private void chargerProduit()
        {
            List<Location> lstlocations = smsql.LocationEnCours();
            cboProduit.Items.Clear();
            foreach (Location location in lstlocations)
            {
                cboProduit.Items.Add(location.Produit.DescriptionID());
            }
        }

        private void frmRetourPiece_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmM = new frmMain();
            frmM.Show();
            this.Dispose();
        }
    }
}
