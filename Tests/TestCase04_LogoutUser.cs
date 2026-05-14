using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase04_LogoutUser : BaseTest
    {
        [TestMethod]
        public async Task LogoutUser()
        {
            var home = new HomePage(Page);

            await home.ClickSignupLogin();

            var login = new LoginPage(Page);

            await login.Login(TestData.ValidEmail, TestData.ValidPassword);

            await Page.ClickAsync("a[href='/logout']");

            await Expect(Page.Locator("text=Login to your account")).ToBeVisibleAsync();
        }
    }
}