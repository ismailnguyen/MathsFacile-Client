using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsFacileClient.Web.Controllers;

namespace MathsFacileClient.Tests
{
    [TestClass]
    public class CalculTests
    {
        [TestMethod]
        public void Should_equals_ten()
        {
            var homeController = new HomeController();

            var calcul = "5+5";

            var result = homeController.Calcul(calcul);

            Assert.AreEqual(result, "10");
        }

        [TestMethod]
        public void Should_equals_zero()
        {
            var homeController = new HomeController();

            var calcul = "5*0";

            var result = homeController.Calcul(calcul);

            Assert.AreEqual(result, "0");
        }

        [TestMethod]
        public void Should_equals_one()
        {
            var homeController = new HomeController();

            var calcul = "5/5";

            var result = homeController.Calcul(calcul);

            Assert.AreEqual(result, "1.0");
        }

        [TestMethod]
        public void Should_not_equals_one()
        {
            var homeController = new HomeController();

            var calcul = "5-2";

            var result = homeController.Calcul(calcul);

            Assert.AreNotEqual(result, "1");
        }

        [TestMethod]
        public void Should_not_fail()
        {
            var homeController = new HomeController();

            var calcul = "5+5";

            var result = homeController.Calcul(calcul);

            Assert.AreEqual(result, "10");
        }
    }
}
