using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase01_RegisterUser : BaseTest
    {
        [TestMethod]
        public async Task RegisterUser()
        {
            var home = new HomePage(Page);

            await home.VerifyHomePageVisible();

            await home.ClickSignupLogin();

            var login = new LoginPage(Page);

            await login.Signup(TestData.NewUserName, TestData.NewUserEmail);

            var signup = new SignupPage(Page);

            await signup.FillAccountInformation();

            await signup.CreateAccount();

            await Expect(Page.Locator("text=Account Created!")).ToBeVisibleAsync();
        }
    }
}