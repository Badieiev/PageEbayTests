using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageEbayTests.Base;

namespace PageEbayTests.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://www.ebay.com";
        private string MainMenuElectronics => "//div[contains(@class, 'hl-cat-nav')]/ul/li";
        private string SubMenuHeadphones => "//li/a[text()='Headphones']";

        private string SearchField => "//input[@class='gh-tb ui-autocomplete-input']";
        private const string _search = "apple";
        private string SearchButton => "//input[@class='btn btn-prim gh-spr']";

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());
        public void OpenEbayHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }
        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(MainMenuElectronics)).First(x=>x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }   
        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuHeadphones)).First(x => x.Text.Equals(item));
            subMenuItem.Click();

        }
        public void ClickSearchField(string item)
        {
            var searchField = FindElements(By.XPath(SearchField)).First(x => x.Text.Equals(item));
            searchField.Click();
            searchField.SendKeys(_search);
        }
        public void ClickSearchButton(string item)
        {
            var searchButton = FindElements(By.XPath(SearchButton)).First(x => x.Text.Equals(item));
            searchButton.Click();
        }
    }
}
