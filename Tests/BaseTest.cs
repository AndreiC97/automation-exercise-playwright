using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExercise.Tests
{
    public class BaseTest : PageTest
    {
        [TestInitialize]
        public async Task Setup()
        {
            await Page.SetViewportSizeAsync(1400, 1200);

            await Page.GotoAsync("https://automationexercise.com");

            var consentButtons = new[]
            {
                "button:has-text('Consent')",
                "button:has-text('Accept')",
                "button:has-text('Agree')",
                "button.fc-button"
            };

            foreach (var selector in consentButtons)
            {
                var button = Page.Locator(selector);

                if (await button.IsVisibleAsync())
                {
                    await button.ClickAsync();
                    break;
                }
            }
        }
    }
}