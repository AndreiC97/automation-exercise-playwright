using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class SignupPage(IPage page) : BasePage(page)
    {
        public async Task FillAccountInformation()
        {
            await Page.CheckAsync("#id_gender1");

            await Page.FillAsync("#password", "Password123");

            await Page.SelectOptionAsync("#days", "10");
            await Page.SelectOptionAsync("#months", "5");
            await Page.SelectOptionAsync("#years", "1995");

            await Page.CheckAsync("#newsletter");
            await Page.CheckAsync("#optin");

            await Page.FillAsync("#first_name", "John");
            await Page.FillAsync("#last_name", "Doe");
            await Page.FillAsync("#company", "TestCompany");
            await Page.FillAsync("#address1", "Street 1");
            await Page.SelectOptionAsync("#country", "Canada");
            await Page.FillAsync("#state", "Ontario");
            await Page.FillAsync("#city", "Toronto");
            await Page.FillAsync("#zipcode", "12345");
            await Page.FillAsync("#mobile_number", "1234567890");
        }

        public async Task CreateAccount()
        {
            await Page.ClickAsync("button[data-qa='create-account']");
        }
    }
}