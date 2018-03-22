using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.Tests
{
    [TestClass()]
    public class Connection_mySQLTests
    {
        Connection_mySQL smsql;
        [TestInitialize]
        public void InitialisationDesTests()
        {
            Config config = new Config("localhost", "testStockManager", "root", "");
            smsql  = new Connection_mySQL(config);
        }

        [TestMethod()]
        public void TestConnexionFail()
        {
            ServiceController sc = new ServiceController("wampmysqld64");
            if (sc.Status.Equals(ServiceControllerStatus.Running))
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
            }
            
            
            bool attendu = false;

            bool calcul = smsql.TestConnexion();

            Assert.AreEqual(attendu, calcul);

        }

        [TestMethod()]
        public void TestConnexionReussi()
        {
            ServiceController sc = new ServiceController("wampmysqld64");
            if (sc.Status.Equals(ServiceControllerStatus.Stopped))
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
            }
            bool attendu = true;

            bool calcul = smsql.TestConnexion();

            Assert.AreEqual(attendu, calcul);

        }

        [TestMethod()]
        public void TestIDProduitTestRéussi()
        {
            bool attendu = true;

            bool Calcul = Convert.ToBoolean(smsql.TestIDProduit(1));

            Assert.AreEqual(attendu, Calcul);
        }
        [TestMethod]
        public void TestIDProduitTestFail()
        {

            bool attendu = false;

            bool Calcul = Convert.ToBoolean(smsql.TestIDProduit(0));

            Assert.AreEqual(attendu, Calcul);
        }
                
        [TestMethod()]
        public void NouveauProduitTest()
        {

            Produit produitA = new Produit();
            produitA.IdProduit = 1;
            produitA.NomProduit = "fourchette";
            produitA.Description = "";

            smsql.NouveauProduit(produitA);

            Produit produitC = smsql.RetourProduit(1);

            Assert.AreEqual(produitA.NomProduit, produitC.NomProduit);
        }

        [TestMethod()]
        public void ModificationProduitTest()
        {

            Produit produitA = smsql.RetourProduit(1);
            produitA.Description = "bla bla bla";

            smsql.ModificationProduit(produitA);

            Produit produitC = smsql.RetourProduit(1);

            Assert.AreEqual(produitA.Description, produitC.Description);
        }

        [TestMethod()]
        public void SupprimerProduitTest()
        {
            bool Attendu = false;

            Produit produit = new Produit();
            produit.IdProduit = 1;

            smsql.SupprimerProduit(produit);

            bool calcul = Convert.ToBoolean(smsql.TestIDProduit(1));

            Assert.AreEqual(Attendu, calcul);
        }

        [TestMethod()]
        public void LocationEnCoursTest()
        {
            Location location = new Location();
            Produit produit = new Produit();
            Loueur loueur = new Loueur();
            produit.IdProduit = 2;
            produit.NomProduit = "L300";
            produit.Description = "";
            loueur.IdLoueur = 1;
            loueur.NomLoueur = "Diem";
            location.StartDate = new DateTime(2018, 1, 1);
            location.Duree = 10;
            location.Produit = produit;
            location.Loueur = loueur;
            smsql.NouveauProduit(produit);

            smsql.AjoutLoueur(loueur.NomLoueur);

            smsql.NouvelleLocation(location);

            List<Location> lstLocationA = new List<Location>();
            lstLocationA.Add(location);

            List<Location> lstLocationC = smsql.LocationEnCours();

            CollectionAssert.AreEqual(lstLocationA,lstLocationC);
        }
    }
}