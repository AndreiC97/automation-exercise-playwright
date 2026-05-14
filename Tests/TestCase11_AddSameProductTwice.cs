using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationExercise.Pages;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase11_AddSameProductTwice : BaseTest
    {
        [TestMethod]
        public async Task AddSameProductTwice()
        {
            var home = new HomePage(Page);

            await home.ClickProducts();

            await Page.ClickAsync("a[href='/product_details/1']");

            await Page.ClickAsync("button.cart");

            await Page.ClickAsync("button[data-dismiss='modal']");

            await Page.ClickAsync("button.cart");

            await Page.ClickAsync("a[href='/view_cart']");

            var quantity = await Page.Locator(".cart_quantity button").InnerTextAsync();

            Assert.AreEqual("2", quantity);
        }
    }
}