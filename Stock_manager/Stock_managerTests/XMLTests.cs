using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.Tests
{
    [TestClass()]
    public class XMLTests
    {
        [TestMethod()]
        public void EcritureXMLTest()
        {
            Config config = new Config();
            config.Serveur = "localhost";
            config.BaseDonnee = "Stock-Manager";
            config.Utilisateur = "vendeur";
            config.MotPasse = "Pa$$w0rd";

            XML xml = new XML();

            xml.EcritureXML(config);
        }
    }
}