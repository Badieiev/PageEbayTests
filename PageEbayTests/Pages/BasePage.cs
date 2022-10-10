using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageEbayTests.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEbayTests.Pages
{
    public class BasePage
    {
        public BasePage()
        {

        }
        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }
        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }
        public bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d=>DriverManager.Instance().FindElement(locator).Displayed);
        }
    }
}
