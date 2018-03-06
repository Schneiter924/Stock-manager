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
            string descript = idProduit.ToString() + " - " + nomProduit;
            if (description != "")
            {
                descript += " - " + description;
                if (descript.Count() > 50)
                {
                    descript = descript.Substring(0, 50);
                }
            }

            return descript;
        }

        public string DescriptionProduit()
        {
            string descript = nomProduit;
            if (description != null)
            {
                descript += " - " + description;
            }

            return descript;
        }
    }
}
