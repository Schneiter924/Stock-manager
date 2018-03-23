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
            smsql = new Connection_mySQL(config);
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
        public void LoueurAjoutTest()
        {
            Loueur loueur = new Loueur();
            loueur.IdLoueur = 1;
            loueur.NomLoueur = "Test";
            smsql.AjoutLoueur(loueur.NomLoueur);
            bool attendu1 = true;
            bool calcul1 = Convert.ToBoolean(smsql.TestNomLoueur(loueur.NomLoueur));

            Assert.AreEqual(attendu1, calcul1);

        }

        [TestMethod()]
        public void ModificationLoueurTest()
        {
            bool attendu = true;
            Loueur loueurA = new Loueur();
            loueurA.IdLoueur = 1;
            loueurA.NomLoueur = "Test";

            Loueur loueurB = new Loueur();
            loueurB.IdLoueur = 1;
            loueurB.NomLoueur = "Test 2";

            smsql.ModificationLoueur(loueurB);

            bool calcul = Convert.ToBoolean(smsql.TestNomLoueur(loueurB.NomLoueur));
            Assert.AreEqual(attendu, calcul);
        }

        [TestMethod()]
        public void SupprimerLoueurTest()
        {
            bool attendu = false;
            Loueur loueurA = new Loueur();
            loueurA.IdLoueur = 1;
            loueurA.NomLoueur = "Test 2";

            smsql.SupprimerLoueur(loueurA);

            bool calcul = Convert.ToBoolean(smsql.TestNomLoueur(loueurA.NomLoueur));
            Assert.AreEqual(attendu, calcul);
        }
    }
}