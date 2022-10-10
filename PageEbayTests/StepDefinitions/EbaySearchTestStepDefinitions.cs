using NUnit.Framework;
using PageEbayTests.Base;
using PageEbayTests.Pages;
using System;
using TechTalk.SpecFlow;

namespace PageEbayTests.StepDefinitions
{
    [Binding]
    public class EbaySearchTestStepDefinitions
    {
        [Given(@"I open official Ebay site")]
        public void IOpenOfficialEbaySite()
        {
            HomePage.Instance.OpenEbayHomePage();  
        }

        [When(@"I click click on the search field")]
        public void IClickOnTheSearchField(string searchField)
        {
            HomePage.Instance.ClickSearchField(searchField);
        }

        [When(@"I click button Search")]
        public void IClickButtonSearch(string menuButton)
        {
            HomePage.Instance.ClickSearchButton(menuButton);
        }

        [Then(@"Page with product should be opened")]
        public void PageWithProductShouldBeOpened(string title)
        {
            Assert.IsTrue(SearchPage.Instance.IsSearchPageDisplayed(), "Page title for the page is not displayed");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
