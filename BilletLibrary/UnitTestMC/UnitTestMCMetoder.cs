using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
namespace UnitTestMC
{
    [TestClass]
    public class UnitTestMCMetoder
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            MC nyMC = new MC();

            //act
            decimal pris = nyMC.Pris();

            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TestMethodKøretøj()
        {
            //arrange
            MC nyMC = new MC();

            //act
            string navn = nyMC.Køretøj();

            //assert
            Assert.AreEqual("MC", navn);
        }

        [TestMethod]
        public void TestMethodPrisRabat()
        {
            //Arrange
            MC nyMC = new MC();

            //Act
            decimal pris = nyMC.BroBizz();

            //Assert
            Assert.AreEqual(119, pris);
        }
    }
}
