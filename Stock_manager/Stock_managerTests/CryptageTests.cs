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
    public class CryptageTests
    {
        [TestMethod()]
        public void TestPasswordTest()
        {
            Boolean attendu = true;
            Cryptage cry = new Cryptage(AppDomain.CurrentDomain.BaseDirectory + "pwd.txt");

            cry.CrypterPassword("Pa$$w0rd");
            Boolean calcule = cry.TestPassword("Pa$$w0rd");

            Assert.AreEqual(attendu, calcule);
        }
    }
}