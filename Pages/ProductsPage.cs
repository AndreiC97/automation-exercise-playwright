using Microsoft.Playwright;

namespace AutomationExercise.Pages
{
    public class ProductsPage(IPage page) : BasePage(page)
    {
        public async Task VerifyProductsPageVisible()
        {
            await Page.WaitForSelectorAsync(".features_items");
        }

        public async Task SearchProduct(string product)
        {
            await Page.FillAsync("#search_product", product);
            await Page.ClickAsync("#submit_search");
        }
    }
}