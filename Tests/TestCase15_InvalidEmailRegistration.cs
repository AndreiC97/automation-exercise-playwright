using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationExercise.Pages;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase15_InvalidEmailRegistration : BaseTest
    {
        [TestMethod]
        public async Task InvalidEmailRegistration()
        {
            var home = new HomePage(Page);

            await home.ClickSignupLogin();

            await Page.FillAsync("input[data-qa='signup-name']", "John");

            await Page.FillAsync("input[data-qa='signup-email']", "invalidemail");

            await Page.ClickAsync("button[data-qa='signup-button']");

            await Expect(Page.Locator("input[data-qa='signup-email']")).ToBeVisibleAsync();
        }
    }
}