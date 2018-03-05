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
    public partial class frmLoueur : Form
    {
        public frmLoueur()
        {
            InitializeComponent();
        }
        Connection_mySQL smsql = new Connection_mySQL();
        Loueur loueur;
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjoutModification_Click(object sender, EventArgs e)
        {
            if (txtNomLoueur.Text != "")
            {

            }
            else
            {

            }
        }

        private void frmLoueur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void txtNomLoueur_TextChanged(object sender, EventArgs e)
        {
            string nomLoueur = txtNomLoueur.Text;
            int nombreCaractereMax = 45;
            int nombreCaractereActuelle = nomLoueur.Count();

            lblNombreCaractere.Text = "Nombre de caractère actuelle " + nombreCaractereActuelle + " / nombre max de caractère " + nombreCaractereMax;
            if (nombreCaractereActuelle > nombreCaractereMax)
            {
                string message = "Dépassement du nombre de caratère autorise";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
                nomLoueur = nomLoueur.Substring(0, 45);
                txtNomLoueur.Text = nomLoueur;
            }
        }

        private void frmLoueur_Load(object sender, EventArgs e)
        {
            List<Loueur> lstLoueurs = smsql.chargeLoueur();

            foreach (Loueur loueur in lstLoueurs)
            {
                cboIDLoueur.Items.Add(loueur.IdLoueur.ToString());
            }
        }

        private void cboIDLoueur_Validated(object sender, EventArgs e)
        {
            if (cboIDLoueur.Text == "")
            {
                cmdAjoutModification.Text = "Ajouter";
            }
            else
            {
                loueur = smsql.LoueurSelectionnerID(Convert.ToInt32(cboIDLoueur.Text));
                cmdAjoutModification.Text = "Modification";
                txtNomLoueur.Text = loueur.NomLoueur;
            }
        }
    }
}
