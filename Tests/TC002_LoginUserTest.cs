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
    public class TC002_LoginUserTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/login.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void LoginUser() { 

            LoginPage loginPage = new LoginPage(driver);
            loginPage.setUserName("username");
            loginPage.setPassword("password");
            loginPage.clickSubmitButton();


        
        }

        [TearDown]
        public void TearDown() {

            if (driver != null) { 
            
                driver.Close();
                driver.Dispose();
            }
        
        }
    }
}
