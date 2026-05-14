using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase02_LoginCorrectUser : BaseTest
    {
        [TestMethod]
        public async Task LoginCorrectUser()
        {
            var home = new HomePage(Page);

            await home.ClickSignupLogin();

            var login = new LoginPage(Page);

            await login.Login(TestData.ValidEmail, TestData.ValidPassword);

            await Expect(Page.Locator("text=Logged in as")).ToBeVisibleAsync();
        }
    }

}