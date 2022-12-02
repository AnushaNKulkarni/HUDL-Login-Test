using HudlLoginTestSuite.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static HudlLoginTestSuite.Operartions;


namespace HudlLoginTestSuite.Steps
{
    [Binding]
    public class LoginStepDefinitions
    {
        public IWebDriver webDriver = new ChromeDriver();
        Login loginPage = null;
       

        [Given(@"The user launches the application")]
        public void GivenTheUserLaunchesTheApplication()
        {
            
            webDriver.Navigate().GoToUrl("https://www.hudl.com/");
            webDriver.Manage().Window.Maximize();
            loginPage = new Login(webDriver);
         

        }

        [Given(@"the user clicks on the Login button on home page")]
        public void GivenTheUserClicksOnTheLoginButton()
        {
            FindElement(webDriver, loginPage.Loginbtn).Click();
            
        }

        [Given(@"the user is redirected to the login page")]
        public void GivenTheUserIsRedirectedToTheLoginPage()
        {
            var loginPageIsDisplayed = FindElement(webDriver, loginPage.EmailPresent);
            Assert.That(loginPageIsDisplayed.Displayed);
        }


        [When(@"the user enters credentials")]
        public void WhenTheUserEntersInvalidCredentials(Table table)
        {
            FindElement(webDriver, loginPage.EmailPresent);
                     

            var details = table.CreateDynamicSet();
            foreach (var item in details)
            {
                
                loginPage.Credentials((string)item.Email, (string)item.Password);
            }
        }

        [When(@"Clicks login button")]
        public void WhenClicksLoginButton()
        {

          FindElement(webDriver, loginPage.LoginButton).Click();
            
        }

        [Then(@"the user is logged in")]
        public void ThenTheUserIsLoggedIn()
        {
            var element = FindElement(webDriver, loginPage.UserDetails, 30);
           
            Assert.That(element.Displayed);
        }

        

        [Then(@"the user is not logged in")]
        public void ThenTheUserIsNotLoggedIn()
        {
            var errorMsessage = FindElement(webDriver, loginPage.ErrorMsg);
            Assert.That(errorMsessage.Displayed);   


        }

        [Given(@"a user navigates to the reset password page")]
        public void GivenARegisteredUserNavigatesToTheResetPasswordPage()
        {
            FindElement(webDriver, loginPage.ResetEmailOnLoginPage).Click();
            
        }

        [Given(@"the user can see the reset password page")]
        public void GivenTheUserCanSeeTheResetPasswordPage()
        {
            var resetPage = FindElement(webDriver, loginPage.fieldCheck);
            Assert.That(resetPage.Displayed);
            resetPage.Click();
        }


        [When(@"the user enters their EmailId")]
        public void WhenTheUserEntersTheirEmail(Table table)
        {
           

            var email = table.CreateDynamicSet();
            foreach (var item in email)
            {

                loginPage.EmailId((string)item.Email);
                
            }
        }

        [When(@"user clicks Resend Password button")]
        public void WhenUserClicksResendPasswordButton()
        {
             FindElement(webDriver, loginPage.PasswdResetButton).Click();
            
            
          
        }

        [Then(@"the user receives a success message")]
        public void ThenTheUserReceivesASuccessMessage()
        {
            var successMsg = FindElement(webDriver, loginPage.PasswordResetMsg);
            Assert.That(successMsg.Displayed);
        }

        [Then(@"the user receives an error message")]
        public void ThenTheUserReceivesAnErrorMessage()
        {
            var resetErrorMsg = FindElement(webDriver, loginPage.PasswordResetErrorMsg);
            Assert.That(resetErrorMsg.Displayed);
        }

        [Given(@"the user clicks Login with an organisation button")]
        public void GivenTheUserClicksLoginInWithAnOrganisationButton()
        {
            FindElement(webDriver, loginPage.OrgLoginButton).Click();
            
        }
       
        [Given(@"the user can see the org login page")]
        public void GivenTheUserCanSeeTheOrgLoginPage()
        {
            var orgEmailPage = FindElement(webDriver, loginPage.orgEmailFieldCheck);
            Assert.That(orgEmailPage.Displayed);
            orgEmailPage.Click();
        }


        [When(@"the user enters their email id in org email field")]
        public void WhenTheUserEntersTheirOrgEmailId(Table table)
        {

          // FindElement(webDriver, loginPage.orgEmailFieldCheck);
           // loginPage.ClickResetEmailField();
            var orgEmail = table.CreateDynamicSet();
            foreach (var item in orgEmail)
            {

                loginPage.OrgEmailId((string)item.Email);

            }
        }

        [When(@"clicks on Login")]
        public void WhenClicksOnLogin()
        {
            FindElement(webDriver, loginPage.LogintoOrgButton).Click();
        }


        //This step is not implemenetd as valid org email was not provided 
        [Then(@"user is successfully logged in")]
        public void ThenUserIsSuccessfullyLoggedIn()
        {
            throw new PendingStepException();
        }

        [Then(@"the user is redirecetd to the login page")]
        public void ThenTheUserIsRedirecetdToTheLoginPage()
        {
           var emailOnLoginPage =  FindElement(webDriver, loginPage.EmailPresent);
            Assert.That(emailOnLoginPage.Displayed);

        }

        [Then(@"the user can see an org error message")]
        public void ThenTheUserCanSeeAnOrgErrorMessage()
        {
            var orgErrormessageCheck = FindElement(webDriver, loginPage.OrgErrorMsg);
            Assert.That(orgErrormessageCheck.Displayed);
        }


        [Then(@"user can see the back arrow icon which navigates back to home page")]
        public void ThenUserCanSeeTheBackArrowToGoToHomePage()
        {
            var backArrow = FindElement(webDriver, loginPage.BackArrow);
            Assert.That(backArrow.Displayed);
            backArrow.Click();

            var loginbuton = FindElement(webDriver, loginPage.Loginbtn);
            Assert.That(loginbuton.Displayed);
        }

        [Then(@"user can see the SingUp hyperlink which navigates to the Singup page")]
        public void ThenUserCanSeeTheSingUpHyperlinkWhichNavigatesToTheSingupPage()
        {
            FindElement(webDriver, loginPage.Loginbtn).Click();
            var signUp = FindElement(webDriver, loginPage.SignUpLink);
            Assert.That(signUp.Displayed);
            signUp.Click();

            var signupPage = FindElement(webDriver, loginPage.SinupPageContent);
            Assert.That(signupPage.Displayed);
        }

        [Then(@"the user can see the Hudl logo")]
        public void ThenTheUserCanSeeTheHudlLogo()
        {
            FindElement(webDriver, loginPage.LoginButtonOnSinupPage).Click();
            var LogoIcon = FindElement(webDriver, loginPage.Logo);
            Assert.That(LogoIcon.Displayed);
        }

        [Then(@"the user can see the remember me check box for checking and un-checking")]
        public void ThenTheUserCanSeeTheRememberMeCheckBox()
        {
            var RememberMeCheckbox = FindElement(webDriver, loginPage.RememberMe);
            Assert.That(RememberMeCheckbox.Displayed);
            RememberMeCheckbox.Click();

            var RememberMeCheckboxSelected = FindElement(webDriver, loginPage.RememberMeBox);
            Assert.That(RememberMeCheckboxSelected.Displayed);
            Assert.That(RememberMeCheckboxSelected.Selected, Is.True);

            RememberMeCheckbox.Click();
            Assert.That(RememberMeCheckboxSelected.Selected, Is.False);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }
    }

}