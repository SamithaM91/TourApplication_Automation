using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewToursC_.Pages
{
    public class RegisterSuccessPage
    {
        private IWebDriver driver;
        public RegisterSuccessPage(IWebDriver driver) {
            this.driver = driver;
        }

        By signInLinkText = By.LinkText("sign-in");

        public void SignInLinkText()
        {
            driver.FindElement(signInLinkText).Click();
        }


    }
}
