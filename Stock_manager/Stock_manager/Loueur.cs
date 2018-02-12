using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    public class Loueur
    {
        private string nom;
        private int idLoueur;

        public Loueur(string nom)
        {
            this.nom = nom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public int IdLoueur
        {
            get
            {
                return idLoueur;
            }

            set
            {
                idLoueur = value;
            }
        }
    }
}
