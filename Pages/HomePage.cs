using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class HomePage(IPage page) : BasePage(page)
    {
        public async Task VerifyHomePageVisible()
        {
            await Page.WaitForSelectorAsync("img[alt='Website for automation practice']");
        }

        public async Task ClickSignupLogin()
        {
            await Page.ClickAsync("a[href='/login']");
        }

        public async Task ClickContactUs()
        {
            await Page.ClickAsync("a[href='/contact_us']");
        }

        public async Task ClickProducts()
        {
            await Page.ClickAsync("a[href='/products']");
        }

        public async Task ClickTestCases()
        {
            await Page.ClickAsync("a[href='/test_cases']");
        }

        public async Task ScrollToFooter()
        {
            await Page.Locator("footer").ScrollIntoViewIfNeededAsync();
        }

        public async Task VerifySubscriptionVisible()
        {
            await Page.WaitForSelectorAsync("text=Subscription");
        }
    }
}