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
                    string message = "Le loueur a bien été ajouter";
                    string legende = "Information";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(message, legende, bouton, icon);
                }
                else
                {
                    loueur.NomLoueur = txtNomLoueur.Text;
                    smsql.ModificationLoueur(loueur);
                    string message = "Le loueur a bien été modifier";
                    string legende = "Information";
                    MessageBoxButtons bouton = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox.Show(message, legende, bouton, icon);
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
            cboNomLoueur.TabIndex = 1;
            txtNomLoueur.TabIndex = 2;
            cmdRetour.TabIndex = 3;
            cmdRetour.Location = new Point(169, 110);
            cmdAjoutModification.TabIndex = 4;
            cmdSupprimer.Visible = false;
            cmdSupprimer.Enabled = false;

        }

        private void cboNomLoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNomLoueur.SelectedIndex != 0)
            {
                loueur = smsql.LoueurSelectionnerNom(cboNomLoueur.Text);
                txtNomLoueur.Text = loueur.NomLoueur;
                cmdAjoutModification.Text = "Modifier";
                cmdRetour.TabIndex = 3;
                cmdRetour.Location = new Point(88, 110);
                cmdSupprimer.Visible = true;
                cmdSupprimer.Enabled = true;
                cmdSupprimer.TabIndex = 4;
                cmdAjoutModification.TabIndex = 5;                
            }
            else
            {
                txtNomLoueur.Text = "";
                cmdAjoutModification.Text = "Ajouter";
                cmdRetour.TabIndex = 3;
                cmdRetour.Location = new Point(169, 110);
                cmdAjoutModification.TabIndex = 4;
                cmdSupprimer.Visible = false;
                cmdSupprimer.Enabled = false;
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

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            string message = "Confirmation de la suppresion du loueur : " + loueur.NomLoueur;
            string legende = "Information";
            MessageBoxButtons bouton = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult dialogResult = MessageBox.Show(message,legende,bouton,icon);
            if (dialogResult == DialogResult.Yes)
            {
                smsql.SupprimerLoueur(loueur);
                message = "Le loueur a bien été supprimer";
                legende = "Information";
                bouton = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Information;
                MessageBox.Show(message, legende, bouton, icon);
            }
        }
    }
}
