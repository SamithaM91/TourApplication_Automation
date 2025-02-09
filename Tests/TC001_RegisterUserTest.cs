using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewToursC_.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NewToursC_.Tests
{
    [TestFixture]
    public class TC001_RegisterUserTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test_RegisterLinkClick()
        {
            HomePage homePage = new HomePage(driver);
            homePage.registerLinkClick();

            Assert.That(driver.Url.Contains("register"), "User did not navigated to the Register Page");

            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.setName("Samitha");
            registerPage.setLastName("Maddekanda");
            registerPage.setPhoneNo("02745634567");
            registerPage.setEmail("samitha@gmail.com");
            registerPage.setAddress("Epsom,Auckland");
            registerPage.setCity("Auckland");
            registerPage.setState("New Zealand");
            registerPage.setPostalCode(1023);
            registerPage.selectCountry();
            registerPage.setUserName("samithaM");
            registerPage.setPassword("123");
            registerPage.setConfirmPassword("123");
            registerPage.submitButtonClick();

            Assert.That(driver.Url.Contains("register_sucess"), "User did not registered Succesfuly");

            RegisterSuccessPage registerSuccessPage = new RegisterSuccessPage(driver);
            registerSuccessPage.SignInLinkText();

            Assert.That(driver.Url.Contains("login"), "User did not navigated to Sign-On page");
        }

        [TearDown]
        public void TearDown() {
            if (driver != null)
            {
                driver.Quit(); 
                driver.Dispose();
            }
        }
    }
}
