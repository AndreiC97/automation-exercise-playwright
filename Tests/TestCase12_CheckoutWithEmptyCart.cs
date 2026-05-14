using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase12_CheckoutWithEmptyCart : BaseTest
    {
        [TestMethod]
        public async Task CheckoutWithEmptyCart()
        {
            await Page.GotoAsync("https://automationexercise.com/view_cart");

            await Expect(Page.Locator("text=Cart is empty")).ToBeVisibleAsync();
        }
    }
}