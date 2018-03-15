using System;
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
        public Config LectureXML()
        {
            Config config = new Config(); ;
            List<Config> lstConfig;
            lstConfig = (from e in XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config.xml").Root.Elements("Config1")
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
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }

        public void EcritureXMLDefaut()
        {
            XDocument doc = new XDocument(new XElement("Config",
                                               new XElement("Config1",
                                                   new XElement("Serveur", "localhost"),
                                                   new XElement("BaseDonnee", "Stock_manager"),
                                                   new XElement("Utilisateur", "vendeur"),
                                                   new XElement("MotPasse", "Pa$$w0rd"))));
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }

        public bool TestFichierXML()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory+"config.xml");
        }
    }
}
