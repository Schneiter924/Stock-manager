using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Stock_manager
{
    /// <summary>
    /// Classe qui fait la lecture et l'écriture du fichier xml
    /// </summary>
    public class XML
    {
        string chemin;
        string nomFichier;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="chemin"></param>
        /// <param name="nomFichier"></param>
        public XML(string chemin,string nomFichier)
        {
            this.chemin = chemin;
            this.nomFichier = nomFichier;
        }
        /// <summary>
        /// fonction qui lit le fichier xml
        /// </summary>
        /// <returns></returns>
        public Config LectureXML()
        {
            Config config = new Config(); ;
            List<Config> lstConfig;
            lstConfig = (from e in XDocument.Load(chemin + nomFichier).Root.Elements("Config1")
                         select new Config
                         {
                             Serveur = (string)e.Element("Serveur"),
                             BaseDonnee = (string)e.Element("BaseDonnee"),
                             Utilisateur = (string)e.Element("Utilisateur"),
                             MotPasse = (string)e.Element("MotPasse")
                         }).ToList();
            foreach (Config config1 in lstConfig)
            {
                config = config1;
            }
            return config;
        }

        /// <summary>
        /// fonction qui écrit le fichier xml
        /// </summary>
        /// <param name="config"></param>
        public void EcritureXML(Config config)
        {
            XDocument doc = new XDocument(new XElement("Config",
                                                new XElement("Config1",
                                                    new XElement("Serveur", config.Serveur),
                                                    new XElement("BaseDonnee", config.BaseDonnee),
                                                    new XElement("Utilisateur", config.Utilisateur),
                                                    new XElement("MotPasse", config.MotPasse))));
            doc.Save(chemin + nomFichier);
        }

        /// <summary>
        /// fonction qui écrit le fichier de configuration par défaut
        /// </summary>
        public void EcritureXMLDefaut()
        {
            XDocument doc = new XDocument(new XElement("Config",
                                               new XElement("Config1",
                                                   new XElement("Serveur", "localhost"),
                                                   new XElement("BaseDonnee", "Stock_manager"),
                                                   new XElement("Utilisateur", "vendeur"),
                                                   new XElement("MotPasse", "Pa$$w0rd"))));
            doc.Save(chemin + nomFichier);
        }

        private void TestDossier()
        {
            if (Directory.Exists(chemin) != true)
            {
                Directory.CreateDirectory(chemin);
            }
        }

        /// <summary>
        /// fonction qui test si le fichier existe
        /// </summary>
        /// <returns></returns>
        public bool TestFichierXML()
        {
            TestDossier();
            return File.Exists(chemin + nomFichier);
        }
    }
}
