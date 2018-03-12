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
        public void LectureXML()
        {
            XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "config.xml");
            doc.Descendants("Config").Select(g => new { Serveur = g.Element("Serveur").Attribute("Serveur").Value });
        }

        public void EcritureXML(Config config)
        {
            XDocument doc = new XDocument(new XElement("Config", new XElement("Serveur", config.Serveur), new XElement("BaseDonnee", config.BaseDonnee), new XElement("Utilisateur", config.Utilisateur), new XElement("MotPasse", config.MotPasse)));
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }

        public void EcritureXMLDefaut()
        {
            XDocument doc = new XDocument(new XElement("Config", new XElement("Serveur", "localhost"), new XElement("BaseDonnee", "Stock_manager"), new XElement("Utilisateur", "vendeur"), new XElement("MotPasse", "Pa$$w0rd")));
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }

        public bool TestFichierXML()
        {
            return File.Exists(AppDomain.CurrentDomain.BaseDirectory+"config.xml");
        }
    }
}
