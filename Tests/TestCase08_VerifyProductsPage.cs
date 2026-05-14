using AutomationExercise.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase08_VerifyProductsPage : BaseTest
    {
        [TestMethod]
        public async Task VerifyProductsPage()
        {
            var home = new HomePage(Page);

            await home.ClickProducts();

            var products = new ProductsPage(Page);

            await products.VerifyProductsPageVisible();

            await Page.ClickAsync("a[href='/product_details/1']");

            await Expect(Page.Locator(".product-information")).ToBeVisibleAsync();
        }
    }
}