using NUnit.Framework;
using PageEbayTests.Base;
using PageEbayTests.Pages;

namespace PageEbayTests.StepDefinitions
{
    [Binding]
    public class EbayMenuTestStepDefinitions
    {
        [Given(@"I open official Ebay wibe site")]
        public void IOpenOfficialEbayWibeSite()
        {
            HomePage.Instance.OpenEbayHomePage();
        }

        [When(@"I hover the ""([^""]*)"" menu item from the main menu")]
        public void IHoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"I click ""([^""]*)""oprion from the main\.menu")]
        public void IClickOprionFromTheMain_Menu(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"Page with ""([^""]*)"" title should be opened")]
        public void PageWithTitleShouldBeOpened(string title)
        {
            Assert.IsTrue(HeadphonePage.Instance.IsPageTitleDisplayed(), "Page title for the page is not displayed");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
