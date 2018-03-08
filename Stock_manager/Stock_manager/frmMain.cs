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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdInventaire_Click(object sender, EventArgs e)
        {
            Form frmInv = new frmInventaire();
            frmInv.Show();
            this.Dispose();
        }

       

        private void cmdLocation_Click(object sender, EventArgs e)
        {
            Form frmSor = new frmLocation();
            frmSor.Show();
            this.Dispose();
        }

        private void cmdMenuRecherche_Click(object sender, EventArgs e)
        {
            Form frmRec = new frmReMenu();
            frmRec.Show();
            this.Dispose();
        }

        private void cmdAMProduit_Click(object sender, EventArgs e)
        {
            Form frmNP = new frmAjoutModifProduit();
            frmNP.Show();
            this.Hide();
        }

        private void cmdRetourPrduit_Click(object sender, EventArgs e)
        {
            Form frmRP = new frmRetourLocation();
            frmRP.Show();
            this.Hide();
        }

        private void cmdLoueur_Click(object sender, EventArgs e)
        {
            Form frmL = new frmLoueur();
            frmL.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
