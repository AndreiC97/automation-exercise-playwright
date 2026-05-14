using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class LoginPage(IPage page) : BasePage(page)
    {
        public async Task Login(string email, string password)
        {
            await Page.FillAsync("input[data-qa='login-email']", email);
            await Page.FillAsync("input[data-qa='login-password']", password);
            await Page.ClickAsync("button[data-qa='login-button']");
        }

        public async Task Signup(string name, string email)
        {
            await Page.FillAsync("input[data-qa='signup-name']", name);
            await Page.FillAsync("input[data-qa='signup-email']", email);
            await Page.ClickAsync("button[data-qa='signup-button']");
        }
    }
}