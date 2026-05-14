using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase05_RegisterExistingEmail : BaseTest
    {
        [TestMethod]
        public async Task RegisterExistingEmail()
        {
            var home = new HomePage(Page);

            await home.ClickSignupLogin();

            var login = new LoginPage(Page);

            await login.Signup("John", TestData.ValidEmail);

            await Expect(Page.Locator("text=Email Address already exist!")).ToBeVisibleAsync();
        }
    }
}