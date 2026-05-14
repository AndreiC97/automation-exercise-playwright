using AutomationExercise.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase09_SearchProduct : BaseTest
    {
        [TestMethod]
        public async Task SearchProduct()
        {
            var home = new HomePage(Page);

            await home.ClickProducts();

            var products = new ProductsPage(Page);

            await products.SearchProduct("Blue Top");

            await Expect(Page.Locator("text=Searched Products")).ToBeVisibleAsync();
        }
    }
}