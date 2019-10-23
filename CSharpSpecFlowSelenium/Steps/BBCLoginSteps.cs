using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CSharpSpecFlowSelenium
{
    [Binding]
    public class BBCLoginSteps

    {
        private IWebDriver driver;
        private BBCSignIn bbcsignin;

        [Scope(Scenario = "Invalid password")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            bbcsignin = new BBCSignIn(driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            bbcsignin.GoToPage();
        }

        [Given(@"I have enter a valid username")]
        public void GivenIHaveEnterAValidUsername()
        {
            bbcsignin.FillUsername("sheelasenga3@gmail.com");
        }

        [Given(@"I have entered a invalid password")]
        public void GivenIHaveEnteredAInvalidPassword()
        {
            bbcsignin.FillPassword("12345678");
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            bbcsignin.Signin();
        }

        [Then(@"I should see the appropriate error")]
        public void ThenIShouldSeeTheAppropriateError()
        {
            Assert.AreEqual("Sorry, that password isn't valid. Please include a letter.", bbcsignin.GetResponse());
        }

        [Scope(Scenario = "Invalid password")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
        
    }

}
