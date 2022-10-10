using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageEbayTests.Base
{
    internal class DriverManager
    {
        private static IWebDriver driver;
        public static IWebDriver Instance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("C:/Users/Andrey/projects/ebayTests/PageEbayTests/PageEbayTests/Base");
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
