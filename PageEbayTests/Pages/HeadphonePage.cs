using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEbayTests.Pages
{
    internal class HeadphonePage : BasePage
    {
        private string TitleXPath => "//h1/span[@class='b-pageheader__text']";
        private static HeadphonePage headphonePage;
        public static HeadphonePage Instance => headphonePage ?? (headphonePage = new HeadphonePage());
        public bool IsPageTitleDisplayed()
        {
            return IsDisplayed(By.XPath(TitleXPath));
        }
    }
}
