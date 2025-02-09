using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewToursC_.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        By userName = By.Name("userName");
        By password = By.Name("password");
        By submitButton = By.Name("submit");

        public void setUserName(string username) { 
            driver.FindElement(userName).SendKeys(username);
        }

        public void setPassword(string userPassword) { 
            driver.FindElement(password).SendKeys(userPassword);
        }

        public void clickSubmitButton()
        {
            driver.FindElement(submitButton).Click();
        }
    }
}
