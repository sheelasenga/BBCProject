using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CSharpSpecFlowSelenium
{
    [Binding]
    public class BBCSignoutSteps
    {
        private IWebDriver driver;
        private BBCSignIn bbcsignin;


       [Scope(Scenario = "successful sign out")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            bbcsignin = new BBCSignIn(driver);
        }

        [Given(@"i am on the account page")]
        public void GivenIAmOnTheAccountPage()
        {
            bbcsignin.GoToAccountPage();
            bbcsignin.FillUsername("sheelasenga3@gmail.com");
            bbcsignin.FillPassword("Sheelabest27");
            bbcsignin.Signin();
        }

        [When(@"i press the sign out button")]
        public void WhenIPressTheSignOutButton()
        {
            bbcsignin.Signout();

        }

        [Then(@"i should see the sign out page")]
        public void ThenIShouldSeeTheSignOutPage()
        {
            Assert.AreEqual("BBC – account - you have been signed out", driver.Title);
        }
        [Scope(Scenario = "successful sign out")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

    }
}

