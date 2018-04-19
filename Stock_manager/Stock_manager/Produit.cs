using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    /// <summary>
    /// Classe qui défini un produit
    /// </summary>
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

        public string ProduitAvecIDEtNomProduit()
        {
            return idProduit.ToString() + " - " + nomProduit;
        }

        public string DescriptionProduitAvecID()
        {
            string idPlusNom= idProduit.ToString() + " - " + nomProduit;
            string descript;
            if (description != "")
            {                
                descript = " - " + description;
                if (descript.Count() > 50)
                {
                    descript = descript.Substring(0, 50);
                }
                idPlusNom += descript;
            }

            return idPlusNom;
        }

        public string DescriptionProduit()
        {
            string nom = nomProduit;
            
            if (description != "")
            {
                string descript;
                descript = " - " + description;
                if (descript.Count() > 50)
                {
                    descript = descript.Substring(0, 50);
                }
                nom += descript;
            }

            return nom;
        }
    }
}
