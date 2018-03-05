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
    public partial class frmRetourPiece : Form
    {
        public frmRetourPiece()
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
            if (cboPiece.Text != "")
            {
                int idProduit = Convert.ToInt32(cboPiece.Text);

                Location location = smsql.LocationSelectionner(idProduit);

                location.EndDate = DateTime.Today;

                smsql.RetourLocation(location);
                cboPiece.Items.Clear();
                chargerProduit();
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

        private void frmRetourPiece_Load(object sender, EventArgs e)
        {
            chargerProduit();
        }

        private void chargerProduit()
        {
            List<Location> lstlocations = smsql.LocationEnCours();
            foreach (Location location in lstlocations)
            {
                cboPiece.Items.Add(location.Produit.DescriptionID());
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
