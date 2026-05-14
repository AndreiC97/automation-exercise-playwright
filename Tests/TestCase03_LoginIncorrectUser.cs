using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase03_LoginIncorrectUser : BaseTest
    {
        [TestMethod]
        public async Task LoginIncorrectUser()
        {
            var home = new HomePage(Page);

            await home.ClickSignupLogin();

            var login = new LoginPage(Page);

            await login.Login(TestData.InvalidEmail, TestData.InvalidPassword);

            await Expect(Page.Locator("text=Your email or password is incorrect!")).ToBeVisibleAsync();
        }
    }

}