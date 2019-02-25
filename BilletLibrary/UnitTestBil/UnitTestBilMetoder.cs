using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestBil
{
    [TestClass]
    public class UnitTestBilMetoder
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //Arrange
            Bil nybil = new Bil();

            //Act
            decimal pris = nybil.Pris();

            //Assert
            Assert.AreEqual(240,pris);
        }
        [TestMethod]
        public void TestMethodKøretøj()
        {
            //Arrange
            Bil nybil = new Bil();

            //Act
            string navn = nybil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", navn);
        }
        [TestMethod]
        public void TestMethodPrisRabat()
        {
            //Arrange
            Bil nybil = new Bil();

            //Act
            decimal pris = nybil.BroBizz();

            //Assert
            Assert.AreEqual(228, pris);
        }
    }
}
