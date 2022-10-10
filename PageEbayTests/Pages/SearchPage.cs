using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEbayTests.Pages
{
    public class SearchPage : BasePage
    {
        private string SearchXPath => "//input[@class='gh-tb ui-autocomplete-input']";
        private static SearchPage searchPage;
        public static SearchPage Instance => searchPage ?? (searchPage = new SearchPage());
        public bool IsSearchPageDisplayed()
        {
            return IsDisplayed(By.XPath(SearchXPath));
        }   
    }
}
