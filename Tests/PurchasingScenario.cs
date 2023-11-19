using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

public class PiguLtLoginTest
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test, Order (1)]
    public void LoginToPiguLtWithValidCredentials()
    {
        driver.Navigate().GoToUrl("https://pigu.lt/lt/");
        IWebElement closeCookies = driver.FindElement(By.XPath("//*[@id=\'cookie_block\']/div/div/div[2]/div[2]/button[3]"));
        closeCookies.Click();
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
        IWebElement logInResult = driver.FindElement(By.XPath("//*[@id=\'headeMenu\']/li[1]/div/div/div/div[2]/p"));
        Assert.That(expectedLogInSuccessed, Is.EqualTo(logInResult.Text));
    }

    [Test, Order (2)]
    public void HamburgerMenuTesting()
    {
        IWebElement hamburgerMenuIcon = driver.FindElement(By.XPath("//*[@id=\'menuBurger\']"));
        hamburgerMenuIcon.Click();

        IWebElement kvepalaiKosmetikaCategory = driver.FindElement(By.XPath("//*[@id=\'department-82\']/a/span"));
        kvepalaiKosmetikaCategory.Click();

        IWebElement kvepalaiMoterimsSubcategory = driver.FindElement(By.XPath("//*[@id=\'department-82\']/div/div/div[1]/ul[1]/li[1]/a"));
        kvepalaiMoterimsSubcategory.Click();

        System.Threading.Thread.Sleep(5000);
        string expectedSearchResult = "Originalūs kvepalai moterims";
        IWebElement searchResult = driver.FindElement(By.XPath("//*[@id=\'catalogSeoText\']/div/div[1]/div/p/strong[1]"));
        Assert.That(expectedSearchResult, Is.EqualTo(searchResult.Text));
    }

    [Test, Order (3)]
    public void AddKvepalaiMoterimsToCartPerSearch()
    {
       
        IWebElement searchInput = driver.FindElement(By.Id("searchInput"));
        searchInput.SendKeys("kvepalai moterims");
        searchInput.SendKeys(Keys.Enter);

        IWebElement firstResult = driver.FindElement(By.XPath("//*[@id=\'_0productBlock1039724\']/div/div/div[3]/a/img"));
        firstResult.Click();

        IWebElement addToCartButton = driver.FindElement(By.XPath("//*[@id=\'product-sidebar\']/div[2]/div[6]/div/div[1]"));
        addToCartButton.Click();

        System.Threading.Thread.Sleep(5000);
        string expectedAddedToCart = "Prekė įtraukta į krepšelį";
        IWebElement addedToCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-modal-header\"]/div"));
        Assert.That(expectedAddedToCart, Is.EqualTo(addedToCart.Text));
    }

    [Test, Order (4)]
    public void ShoppingCartPurchaseWithEmptyBuyerInformation()
    {

        driver.FindElement(By.XPath("//*[@id=\'buy\']")).Click(); //press buy button for past test performint

        
        driver.FindElement(By.XPath("//*[@id=\'form154416133\']/div[2]/div[4]/div[2]/div[2]/div[2]/div/div/button")).Click();

        driver.FindElement(By.XPath("//*[@id=\'create_customer\']/div[3]/div[3]/div/div/button")).Click();
        System.Threading.Thread.Sleep(150);
        IWebElement inputName = driver.FindElement(By.XPath("//*[@id=\'name\']"));
        string expectedBorderColor = "rgb(255, 0, 0)";
        string actualBorderColor = inputName.GetCssValue("border-color");    
        Assert.That(actualBorderColor, Is.EqualTo(expectedBorderColor));
    }

    [Test, Order (5)]
    public void DeleteItemsFromShoppingCart()
    {
        IWebElement returnToShoppingCart = driver.FindElement(By.XPath("//*[@id=\'cartInHeader\']/li/a/i"));
        //System.Threading.Thread.Sleep(2000);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\'cartWidget\']/a")));
        IWebElement deleteItemFromShoppingCart = driver.FindElement(By.XPath("//*[@id=\'productSliceBlock435675408\']/td[6]/div/div[2]"));
        string expectedItemDeleted = "Jūsų prekių krepšelis tuščias";
        IWebElement deletedItem = driver.FindElement(By.XPath("//*[@id=\'mainBlock\']/div/div[1]/div/div"));
        Assert.That(expectedItemDeleted, Is.EqualTo(deletedItem.Text));
    }


    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
