using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationExercise.Pages;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase10_VerifySubscriptionHomePage : BaseTest
    {
        [TestMethod]
        public async Task VerifySubscriptionHomePage()
        {
            var home = new HomePage(Page);

            await home.ScrollToFooter();

            await home.VerifySubscriptionVisible();

            await Page.FillAsync("#susbscribe_email", "test@test.com");

            await Page.ClickAsync("#subscribe");

            await Expect(Page.Locator("text=You have been successfully subscribed!")).ToBeVisibleAsync();
        }
    }
}