using BilletLib;
using BilletLib.Model;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStringBil()
        {
            var bil = new Bil();
            string køretøj = bil.Køretøj();
            Assert.AreEqual("Bil", køretøj);
        }

        [TestMethod]
        public void TestPrisBil()
        {
            //act
            var bil = new Bil();
            //arrange
            int pris = bil.Pris();
            //assert
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeRestricterBil()
        {
            //act
            var bil = new Bil();
            bil.Nummerplade = "xdfsdgsdgfsdg";
            bil.Restrict();

            //assert
            
        }
        [TestMethod]
        public void TestNummerpladeRestricter2Bil()
        {
            //act
            var bil = new Bil();
            bil.Nummerplade = "ak47";
            bil.Restrict();

            //assert
            Assert.AreEqual("ak47", bil.Nummerplade);
        }

        [TestMethod]
        public void TestPrisMC()
        {
            var mC = new MC();
            int pris = mC.Pris();
            Assert.AreEqual(125, pris);
        }
        [TestMethod]
        public void TestStringMC()
        {
            var mC = new MC();
            string køretøj = mC.Køretøj();
            Assert.AreEqual("Motercykel", køretøj);
        }

    }
}
