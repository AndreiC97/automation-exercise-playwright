using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class BasePage(IPage page)
    {
        protected readonly IPage Page = page;
    }
}