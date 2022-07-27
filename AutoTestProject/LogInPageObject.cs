using OpenQA.Selenium;

namespace AutoTestTest.PageObjects
{
    public class LogInPageObject : BasePage
    {
        private readonly By _userNameFieldId = By.Id("user-name");
        private readonly By _passwordFieldXpath = By.XPath("//*[@id=\"password\"]");
        private readonly By _logInButtonXpath = By.XPath("//*[@id=\"login-button\"]");
        private readonly By _productsTitleInHeaderXpath = By.XPath("//*[@id=\"header_container\"]/div[2]/span");

        public void LogInToAccount(string login, string password)
        {
            InputDataToField(_userNameFieldId, login);
            InputDataToField(_passwordFieldXpath, password);
            ClickButton(_logInButtonXpath);
        }

        public bool checkIfLoggedIn()
        {
           return isElementFound(_productsTitleInHeaderXpath);
        }
    }
}