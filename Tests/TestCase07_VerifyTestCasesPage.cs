using AutomationExercise.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase07_VerifyTestCasesPage : BaseTest
    {
        [TestMethod]
        public async Task VerifyTestCasesPage()
        {
            var home = new HomePage(Page);

            await home.ClickTestCases();

            await Expect(Page).ToHaveURLAsync("https://automationexercise.com/test_cases");
        }
    }
}