using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    public class Location
    {
        private DateTime startDate;
        private DateTime endDate;
        private Loueur loueur;
        private Produit produit;
        private int duree;
        private int idLocation;

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public Loueur Loueur
        {
            get
            {
                return loueur;
            }

            set
            {
                loueur = value;
            }
        }

        public Produit Produit
        {
            get
            {
                return produit;
            }

            set
            {
                produit = value;
            }
        }

        public int IdLocation
        {
            get
            {
                return idLocation;
            }

            set
            {
                idLocation = value;
            }
        }

        public int Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public string DescriptionLocation()
        {
            return Produit.DescriptionProduit() + " - " + loueur.Description() + " - la date de début d'empret est le " + startDate.ToString("dd-MM-yyyy");
        }
    }
}
