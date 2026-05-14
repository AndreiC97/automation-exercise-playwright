using AutomationExercise.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase06_ContactUsForm : BaseTest
    {
        [TestMethod]
        public async Task ContactUsForm()
        {
            var home = new HomePage(Page);

            await home.ClickContactUs();

            var contact = new ContactUsPage(Page);

            await contact.FillContactForm();

            await contact.SubmitForm();

            await Expect(Page.Locator(".status")).ToContainTextAsync("Success");
        }
    }
}