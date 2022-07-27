using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestTest.PageObjects
{
    public class BasePage
    {
        private const string _pathToChromeDriver = "/Users/kate/RiderProjects/AutoTestProject/AutoTestProject/Drivers/";
        private static IWebDriver _driver = new ChromeDriver(_pathToChromeDriver);

        public static IWebDriver Driver
        {
            get => _driver;
        }

        public static void OpenWebPage(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }

        protected internal void ClickButton(By by)
        {
            Driver.FindElement(by).Click();
        }

        protected internal void InputDataToField(By by, string textToType)
        {
            Driver.FindElement(by).SendKeys(textToType);
        }

        protected internal bool isElementFound(By by)
        {
           return Driver.FindElement(by).Displayed;
        }
    }
}