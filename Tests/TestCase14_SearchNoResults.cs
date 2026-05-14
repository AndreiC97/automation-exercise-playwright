using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationExercise.Pages;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase14_SearchNoResults : BaseTest
    {
        [TestMethod]
        public async Task SearchNoResults()
        {
            var home = new HomePage(Page);

            await home.ClickProducts();

            await Page.FillAsync("#search_product", "nonexistingproduct123");

            await Page.ClickAsync("#submit_search");

            await Expect(Page.Locator("text=Searched Products")).ToBeVisibleAsync();

            var products = await Page.Locator(".product-image-wrapper").CountAsync();

            Assert.AreEqual(0, products);
        }
    }
}