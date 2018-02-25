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
    public partial class frmSortie : Form
    {
        public frmSortie()
        {
            InitializeComponent();
        }

        Connection_mySQL smsql = new Connection_mySQL();

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

        private void cmdAjout_Click(object sender, EventArgs e)
        {

        }

        private void frmSortie_Load(object sender, EventArgs e)
        {
            DateTime Aujourdhui = DateTime.Today;
            DateTime trenteJours = Aujourdhui.AddDays(30);
            txtDateRetour.Text = trenteJours.ToString("dd-MM-yyyy");
            List<Loueur> lstLoueurs = smsql.chargeLoueur();
            foreach (Loueur loueur in lstLoueurs)
            {
                cboLoueur.Items.Add(loueur.Description());
            }
            List<Produit> lstProduits = smsql.chargeProduit();
            foreach (Produit produit in lstProduits)
            {
                cboPiece.Items.Add(produit.DescriptionID());
            }
            
        }

        private void cboLoueur_Validated(object sender, EventArgs e)
        {
            if (cboLoueur.Text != "")
            {                
                if (smsql.TestNomLoueur(cboLoueur.Text) == null)
                {
                    string message = "login vide";
                    string caption = "Erreur";
                    MessageBoxButtons boutonYes = MessageBoxButtons.YesNo;
                    MessageBoxIcon boutonIcon = MessageBoxIcon.Information;
                    DialogResult dialogResult = MessageBox.Show(message, caption, boutonYes, boutonIcon);
                    if (dialogResult == DialogResult.Yes)
                    {
                        smsql.AjoutLoueur(cboLoueur.Text);
                        List<Loueur> lstLoueurs = smsql.chargeLoueur();
                        cboLoueur.Items.Clear();
                        foreach (Loueur loueur in lstLoueurs)
                        {
                            cboLoueur.Items.Add(loueur.Description());
                        }
                    }
                }
            }
        }
    }
}
