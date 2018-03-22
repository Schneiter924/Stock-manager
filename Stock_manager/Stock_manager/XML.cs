﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Stock_manager
{
    public class XML
    {
        string chemin;
        string nomFichier;

        public XML(string chemin,string nomFichier)
        {
            this.chemin = chemin;
            this.nomFichier = nomFichier;
        }
        public Config LectureXML()
        {
            Config config = new Config(); ;
            List<Config> lstConfig;
            lstConfig = (from e in XDocument.Load(chemin + "\\" + nomFichier).Root.Elements("Config1")
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

        public void EcritureXML(Config config)
        {
            XDocument doc = new XDocument(new XElement("Config",
                                                new XElement("Config1",
                                                    new XElement("Serveur", config.Serveur),
                                                    new XElement("BaseDonnee", config.BaseDonnee),
                                                    new XElement("Utilisateur", config.Utilisateur),
                                                    new XElement("MotPasse", config.MotPasse))));
            doc.Save(chemin + "\\" + nomFichier);
        }

        public void EcritureXMLDefaut()
        {
            XDocument doc = new XDocument(new XElement("Config",
                                               new XElement("Config1",
                                                   new XElement("Serveur", "localhost"),
                                                   new XElement("BaseDonnee", "Stock_manager"),
                                                   new XElement("Utilisateur", "vendeur"),
                                                   new XElement("MotPasse", "Pa$$w0rd"))));
            doc.Save(chemin + "\\" + nomFichier);
        }

        private void TestDossier()
        {
            if (Directory.Exists(chemin) != true)
            {
                Directory.CreateDirectory(chemin);
            }
        }

        public bool TestFichierXML()
        {
            TestDossier();
            return File.Exists(chemin + "\\" + nomFichier);
        }
    }
}
