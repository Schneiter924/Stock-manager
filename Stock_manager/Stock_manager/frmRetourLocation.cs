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
                string temp = cboProduit.Text;

                int index = temp.IndexOf(" - ");

                temp = temp.Substring(0, index);

                int idProduit = Convert.ToInt32(temp);

                Location location = smsql.LocationSelectionner(idProduit);

                location.EndDate = DateTime.Today;

                smsql.RetourLocation(location);

                chargerProduit();

                string message = "La location a bien été retourner";
                string legende = "Information";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show(message, legende, bouton, icon);
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
                cboProduit.Items.Add(location.Produit.ProduitAvecIDEtNomProduit());
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
