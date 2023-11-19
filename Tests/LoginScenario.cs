using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class PiguLtLoginTest
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void LoginToPiguLtWithValidCredentials()
    {
        driver.Navigate().GoToUrl("https://pigu.lt/lt/");

        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\'headeMenu\']/li[1]/a/i"));
        loginButton.Click();
        IWebElement prisijungtiButton = driver.FindElement(By.XPath("//*[@id=\'headeMenu\']/li[1]/div/div/div[2]/a[1]"));
        prisijungtiButton.Click();
        IWebElement usernameInput = driver.FindElement(By.XPath("//*[@id=\'loginModal\']/div[1]/div[1]/form/div[3]/input"));
        IWebElement passwordInput = driver.FindElement(By.XPath("//*[@id=\'passwordCont\']/input"));

        usernameInput.SendKeys("testastest40@gmail.com");
        passwordInput.SendKeys("testas");

        IWebElement loginSubmitButton = driver.FindElement(By.XPath("//*[@id=\'loginModal\']/div[1]/div[1]/form/div[6]/input"));
        loginSubmitButton.Click();

        System.Threading.Thread.Sleep(5000);
        string expectedLogInSuccessed = "Sveiki, testastest40@gmail.com!";
        IWebElement logInResult = driver.FindElement(By.XPath("//*[@id=\"headeMenu\"]/li[1]/div/div/div/div[2]/p"));
        Assert.That(expectedLogInSuccessed, Is.EqualTo(logInResult.Text));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
