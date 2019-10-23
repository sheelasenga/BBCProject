using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace CSharpSpecFlowSelenium
{
    [Binding]
    public class BBCLogin1Steps
    {
        private IWebDriver driver;
        private BBCSignIn bbcsignin;
        
        [Scope(Scenario = "Valid password")]
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            bbcsignin = new BBCSignIn(driver);
        }

        [Given(@"I am on the bbc login page")]
        public void GivenIAmOnTheBbcLoginPage()
        {
            bbcsignin.GoToPage();
        }

        [Given(@"I have entered a valid username")]
        public void GivenIHaveEnteredAValidUsername()
        {
            bbcsignin.FillUsername("sheelasenga3@gmail.com");
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            bbcsignin.FillPassword("Sheelabest27");
        }

        [When(@"I press login btn")]
        public void WhenIPressLoginBtn()
        {
            bbcsignin.Signin();
        }

        [Then(@"I should see the user account homepage")]
        public void ThenIShouldSeeTheUserAccountHomepage()
        {
            Assert.AreEqual("BBC - Home", bbcsignin.GetDriver().Title);
        }

        [Scope(Scenario = "Valid password")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
    }
