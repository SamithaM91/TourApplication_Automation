using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewToursC_.Pages
{
    public class RegisterPage
    {
       private IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By name = By.Name("firstName");
        By lastName = By.Name("lastName");
        By phoneNo = By.Name("phone");
        By email = By.XPath("//input[@id='userName']");
        By address = By.XPath("//input[@name='address1']");
        By city = By.Name("city");
        By state = By.Name("state");
        By postalCode = By.Name("postalCode");
        By country = By.XPath("//select[@name='country']");
        By userName = By.XPath("//input[@id='email']");
        By password = By.Name("password");
        By confirmPassword = By.Name("confirmPassword");
        By submitButton = By.XPath("//input[@name='submit']");

        public void setName(String username)
        {
            driver.FindElement(name).SendKeys(username);
        }

        public void setLastName(String lastname)
        {
            driver.FindElement(lastName).SendKeys(lastname);
        }

        public void setPhoneNo(String userPhoneNo)
        {
            driver.FindElement(phoneNo).SendKeys(userPhoneNo);
        }
        public void setEmail(String userEmail)
        {
            driver.FindElement(email).SendKeys(userEmail);
        }

        public void setAddress(String userAddress)
        {
            driver.FindElement(address).SendKeys(userAddress);
        }

        public void setCity(String userCity)
        {
            driver.FindElement(city).SendKeys(userCity);
        }

        public void setState(String userState)
        {
            driver.FindElement(state).SendKeys(userState);
        }

        public void setPostalCode(int userPostalCode)
        {
            driver.FindElement(postalCode).SendKeys(userPostalCode.ToString());
        }

        public void selectCountry()
        {
            IWebElement countryDropdown = driver.FindElement(country);
            SelectElement countryDropDownSelection = new SelectElement(countryDropdown);
            countryDropDownSelection.SelectByIndex(3);
        }

        public void setUserName(String username)
        {
            driver.FindElement(userName).SendKeys(username);
        }

        public void setPassword(String userPassword)
        {
            driver.FindElement(password).SendKeys(userPassword);
        }

        public void setConfirmPassword(String userConfirmPassword)
        {
            driver.FindElement(confirmPassword).SendKeys(userConfirmPassword);
        }

        public void submitButtonClick()
        {
            driver.FindElement(submitButton).Click();
        }

    }
}
