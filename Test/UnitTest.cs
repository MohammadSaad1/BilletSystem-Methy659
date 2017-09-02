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

        [TestMethod]
        public void BroBizzBilTest()
        {
            var bil = new Bil();
            bil.BroBizz = true;   
            int pris = bil.Pris();
            Assert.AreEqual(228, pris);
        }

        [TestMethod]
        public void BroBizzBilTest2()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            int pris = bil.Pris();
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        public void BroBizzPlusWeekendBilTestSaturday()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            bil.Dato = new DateTime(2017,09,02);
            int pris = bil.Pris();
            Assert.AreEqual(190, pris);
        }
        [TestMethod]
        public void BroBizzPlusWeekendBilTestSunday()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            bil.Dato = new DateTime(2017, 09, 03);
            int pris = bil.Pris();
            Assert.AreEqual(190, pris);
        }
        [TestMethod]
        public void WeekendBilTestSunday()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            bil.Dato = new DateTime(2017, 09, 03);
            int pris = bil.Pris();
            Assert.AreEqual(200, pris);
        }

        [TestMethod]
        public void BroBizzPlusWeekendBilTestMandag()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            bil.Dato = new DateTime(2017, 09, 04);
            int pris = bil.Pris();
            Assert.AreEqual(228, pris);
        }

        public void BroBizzPlusWeekendBilTest2()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            bil.Dato = new DateTime(02/09/2017);
            int pris = bil.Pris();
            Assert.AreEqual(200, pris);
        }




        [TestMethod]
        public void BroBizzMCTest()
        {
            var mC = new MC();
            mC.BroBizz = true;
            int pris = mC.Pris();
            Assert.AreEqual(119, pris);
        }
        [TestMethod]
        public void BroBizzMCTest2()
        {
            var mC = new MC();
            mC.BroBizz = false;
            int pris = mC.Pris();
            Assert.AreEqual(125, pris);
        }
    }
}
