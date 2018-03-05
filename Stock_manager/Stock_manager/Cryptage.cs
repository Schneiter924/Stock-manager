using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Stock_manager
{
    /// <summary>
    /// classe qui fait le cryptage
    /// </summary>
    public class Cryptage
    {
        private string chemin;
         /// <summary>
        /// constructeur passe en paramètre le chemin du fichier + le fichier
        /// </summary>
        /// <param name="chemin"></param>
        public Cryptage(string chemin)
        {
            this.chemin = chemin;
        }

        /// <summary>
        /// fonction qui crypte le mot de passe en BCrypt et ajout le hash au fichier
        /// </summary>
        /// <param name="pwd"></param>
        public void CrypterPassword(string pwd)
        {
           string hash = BCrypt.Net.BCrypt.HashPassword(pwd);

            File.WriteAllText(chemin, hash);
            File.SetAttributes(chemin, FileAttributes.Hidden);
            
        }

        /// <summary>
        /// fonction qui crypte le login en BCrypt et ajout le hash au fichier
        /// </summary>
        /// <param name="login"></param>
        public void CrypterLogin(string login)
        {
            string hash = BCrypt.Net.BCrypt.HashString(login);

            File.WriteAllText(chemin, hash);
            File.SetAttributes(chemin, FileAttributes.Hidden);


        }

        /// <summary>
        /// fonction qui test le mot de passe avec le hash du fichier
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns>même mot de passe = true</returns>
        public Boolean TestPassword(string pwd)
        {
            string hashLect = LectureFichier();
            return BCrypt.Net.BCrypt.Verify(pwd, hashLect);
        }

        /// <summary>
        /// fonction qui test le login avec le hash du fichier
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Boolean TestLogin(string login)
        {
            
            string hashLect = LectureFichier();
            return BCrypt.Net.BCrypt.Verify(login, hashLect);
            
        }

        /// <summary>
        /// fonction qui va lire le fichier
        /// </summary>
        /// <returns></returns>
        private string LectureFichier()
        {
            return File.ReadAllText(chemin);
        }

        /// <summary>
        /// fonction qui test si le fichier existe
        /// </summary>
        /// <returns>le fichier exsite = true</returns>
        public Boolean TestFichier()
        {
            return File.Exists(chemin);
        }
    }
}
