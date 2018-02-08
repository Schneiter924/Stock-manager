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
        MD5 md5Hash;
        /// <summary>
        /// constructeur passe en paramètre le chemin du fichier + le fichier
        /// </summary>
        /// <param name="chemin"></param>
        public Cryptage(string chemin)
        {
            this.chemin = chemin;
            md5Hash = MD5.Create();
        }

        /// <summary>
        /// fonction qui crypte le mot de passe
        /// </summary>
        /// <param name="pwd"></param>
        public void CrypterPassword(string pwd)
        {
           
            string hash = GetMd5Hash(pwd);

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
            string hashOfInput = GetMd5Hash(pwd);
            string hashLect = LectureFichier();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hashLect))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        private string GetMd5Hash( string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
