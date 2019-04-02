using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();            
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
        }

        [TearDown]
        public void TearDown()
        {
           // driver.Quit();
        }

        [Test]
        public void Test1()
        {
            IWebElement firstElement = driver.FindElement(By.XPath("//ul[@class='menu-categories menu-categories_type_main']/li[1]/a"));
            IWebElement secondElement = driver.FindElement(By.XPath("///a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']"));

            Actions actions = new Actions(driver);
            actions.Release(firstElement).MoveToElement(secondElement).Click().Perform();
            //Assert.Pass();
        }
    }
}