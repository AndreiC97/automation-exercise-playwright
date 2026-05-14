using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationExercise.Pages;

namespace AutomationExercise.Tests
{
    [TestClass]
    public class TestCase13_SearchSpecialCharacters : BaseTest
    {
        [TestMethod]
        public async Task SearchSpecialCharacters()
        {
            var home = new HomePage(Page);

            await home.ClickProducts();

            await Page.FillAsync("#search_product", "%&#<>");

            await Page.ClickAsync("#submit_search");

            await Expect(Page).ToHaveURLAsync(new Regex("products"));
        }
    }
}