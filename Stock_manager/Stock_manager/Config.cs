using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    public class Config
    {
        private string serveur;
        private string baseDonnee;
        private string utilisateur;
        private string motPasse;

        public Config (string serveur, string baseDonnee, string utilisateur, string motPasse)
        {
            this.serveur = serveur;
            this.baseDonnee = baseDonnee;
            this.utilisateur = utilisateur;
            this.motPasse = motPasse;
        }

        public Config()
        {

        }
        public string Serveur
        {
            get
            {
                return serveur;
            }

            set
            {
                serveur = value;
            }
        }

        public string BaseDonnee
        {
            get
            {
                return baseDonnee;
            }

            set
            {
                baseDonnee = value;
            }
        }

        public string Utilisateur
        {
            get
            {
                return utilisateur;
            }

            set
            {
                utilisateur = value;
            }
        }

        public string MotPasse
        {
            get
            {
                return motPasse;
            }

            set
            {
                motPasse = value;
            }
        }
    }
}
