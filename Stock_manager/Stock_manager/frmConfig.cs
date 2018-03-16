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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        Config config;
        XML xml = new XML(Environment.GetEnvironmentVariable("APPDATA") + "\\stock_manager\\config.xml");

        private void cmdParDefaut_Click(object sender, EventArgs e)
        {
            config = xml.LectureXML();
            txtServeur.Text = config.Serveur;
            txtBaseDonnee.Text = config.BaseDonnee;
            txtUtilisateur.Text = config.Utilisateur;
            txtMotPasse.Text = config.MotPasse;
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            config.Serveur = txtServeur.Text;
            config.BaseDonnee = txtBaseDonnee.Text;
            config.Utilisateur = txtUtilisateur.Text;
            config.MotPasse = txtMotPasse.Text;
            xml.EcritureXML(config);
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            config = xml.LectureXML();
            txtServeur.Text = config.Serveur;
            txtBaseDonnee.Text = config.BaseDonnee;
            txtUtilisateur.Text = config.Utilisateur;
            txtMotPasse.Text = config.MotPasse;
        }

        private void frmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
