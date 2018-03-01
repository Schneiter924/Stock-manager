using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    public class Produit
    {
        private string nomProduit;
        private string description;
        private int idProduit;

        public string NomProduit
        {
            get
            {
                return nomProduit;
            }

            set
            {
                nomProduit = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int IdProduit
        {
            get
            {
                return idProduit;
            }

            set
            {
                idProduit = value;
            }
        }

        public string DescriptionID()
        {
            return idProduit.ToString();
        }

        public string DescriptionProduitAvecID()
        {
            return idProduit.ToString() + " - " + nomProduit + " - " + description;
        }

        public string DescriptionProduit()
        {
            return nomProduit + " - " + description;
        }
    }
}
