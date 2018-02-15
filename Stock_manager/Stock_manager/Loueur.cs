using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager
{
    public class Loueur
    {
        private string nomLoueur;
        private int idLoueur;

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

        public string NomLoueur
        {
            get
            {
                return nomLoueur;
            }

            set
            {
                nomLoueur = value;
            }
        }

        public string Description()
        {
            return nomLoueur;
        }
    }
}
