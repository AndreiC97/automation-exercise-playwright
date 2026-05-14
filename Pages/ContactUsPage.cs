using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class ContactUsPage(IPage page) : BasePage(page)
    {
        public async Task FillContactForm()
        {
            await Page.FillAsync("input[data-qa='name']", "John Doe");
            await Page.FillAsync("input[data-qa='email']", "john@test.com");
            await Page.FillAsync("input[data-qa='subject']", "Automation");
            await Page.FillAsync("textarea[data-qa='message']", "Playwright Test");
        }

        public async Task SubmitForm()
        {
            // Handle browser alert
            Page.Dialog += async (_, dialog) =>
            {
                await dialog.AcceptAsync();
            };

            await Page.ClickAsync("input[data-qa='submit-button']");
        }
    }
}