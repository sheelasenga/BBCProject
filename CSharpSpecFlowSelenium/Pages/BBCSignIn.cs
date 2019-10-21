using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CSharpSpecFlowSelenium
{
    class BBCSignIn
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        private IWebElement UserNameField;

        [FindsBy(How = How.Id, Using = "password-input")]
        private IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "submit-button")]
        private IWebElement SignIn;

        [FindsBy(How = How.Id, Using = "form-message-password")]
        private IWebElement PasswordResponse;

        [FindsBy(How = How.LinkText, Using = "Sign out")]
        private IWebElement signoutBtn;

        public BBCSignIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://www.bbc.co.uk/signin");
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void FillUsername(string UserName)
        {
            UserNameField.SendKeys(UserName);
        }
        public void FillPassword(string Password)
        {
            PasswordField.SendKeys(Password);
        }
          public string GetResponse()
        {
            return  PasswordResponse.Text;
        }
        public void Signin()
        {
            SignIn.Click();
        }

        public void Signout()
        {
            signoutBtn.Click();

        }
        public void GoToAccountPage()
        {
            driver.Navigate().GoToUrl("https://account.bbc.com/account?ptrt=https%3A%2F%2Fwww.bbc.co.uk%2F&context=HOMEPAGE&userOrigin=HOMEPAGE_");
        }
    }
}

  
