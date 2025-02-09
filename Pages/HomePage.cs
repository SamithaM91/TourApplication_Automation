using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewToursC_.Pages
{
    public class HomePage
    {
       private IWebDriver driver; 
        public HomePage(IWebDriver driver) { 
            this.driver = driver;
        }

        By registerLink = By.LinkText("REGISTER");

        public void registerLinkClick()
        {
            driver.FindElement(registerLink).Click();
        }

    }
}
