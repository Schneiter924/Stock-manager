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
                if (cboNomLoueur.SelectedIndex == 0)
                {
                    smsql.AjoutLoueur(txtNomLoueur.Text);
                    
                }
                else
                {
                    loueur.NomLoueur = txtNomLoueur.Text;
                    smsql.ModificationLoueur(loueur);
                }
                chargerLoueur();
                loueur = null;
            }
            else
            {
                string message = "Pas de nom pour le loueur";
                string legende = "Erreur";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, legende, bouton, MessageBoxIcon.Error);
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
            chargerLoueur();
        }

        private void cboNomLoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNomLoueur.SelectedIndex != 0)
            {
                loueur = smsql.LoueurSelectionnerNom(cboNomLoueur.Text);
                txtNomLoueur.Text = loueur.NomLoueur;
                cmdAjoutModification.Text = "Modifier";
            }
            else
            {
                txtNomLoueur.Text = "";
                cmdAjoutModification.Text = "Ajouter";
            }
        }

        private void chargerLoueur()
        {
            List<Loueur> lstLoueurs = smsql.chargeLoueur();
            cboNomLoueur.Items.Clear();
            cboNomLoueur.Items.Add("Ajouter un Loueur");
            foreach (Loueur loueur in lstLoueurs)
            {
                cboNomLoueur.Items.Add(loueur.NomLoueur);
            }
        }
    }
}
