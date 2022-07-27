using AutoTestTest.PageObjects;

namespace AutoTestProject;

public class Tests
{
    private string url = "https://www.saucedemo.com/";

    // TODO check where to keep secret info as login, password
    private readonly string _userNameStandart = "standard_user";
    private readonly string _password = "secret_sauce";

    private LogInPageObject _logInPageObject;

    // preconditions
    [SetUp]
    public void SetUp()
    {
        BasePage.OpenWebPage(url);
    }

    [Test]
    public void Test1()
    {
        _logInPageObject = new LogInPageObject();
        _logInPageObject.LogInToAccount(_userNameStandart, _password);
        Assert.True(_logInPageObject.checkIfLoggedIn(), "Not logged in");
    }

    // Postcondition
    [TearDown]
    public void TearDown()
    {
        BasePage.Driver.Close();
        BasePage.Driver.Quit();
    }
}