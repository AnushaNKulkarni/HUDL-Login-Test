using iTextSharp.text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HudlLoginTestSuite.Pages
{
    public class Login
    {
        public IWebDriver WebDriver { get; }

        public Login(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        
        //Login button on home page
        public By Loginbtn => By.XPath("/html/body/div[1]/header/div/a[2]");

        
        //Login page: Email & Password fields
        public By EmailPresent => By.Id("email");
        public IWebElement Email => WebDriver.FindElement(By.Id("email"));       
        public IWebElement Password => WebDriver.FindElement(By.Id("password"));
        public void Credentials(String email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
        }


        //Loginpage : Login button 
        public By LoginButton => By.Id("logIn");

        //Login page : Back arrow
        public By BackArrow => By.XPath("/html/body/div/section/a");

        //Login page : signup link 
        public By SignUpLink => By.XPath("/html/body/div/section/div[2]/a");

        //Login page : Logo 
        public By Logo => By.XPath("/html/body/div/section/div[2]/div/form/a");

        //Login page : Remeber me checkbox 
        public By RememberMe => By.XPath("/html/body/div/section/div[2]/div/form/div/div[4]/div/label");
        public By RememberMeBox => By.XPath("/html/body/div/section/div[2]/div/form/div/div[4]/div/label/input");

        //Logged in user details
        public By UserDetails => By.XPath("/html/body/div[2]/div/div[1]/nav[1]/div[4]/div[2]/div[1]/div[2]/span");
        
        //Error message after entering invalid details in email and password fields
        public By ErrorMsg => By.XPath("/html/body/div/section/div[2]/div/form/div/div[3]/div/p");
        
              
        // help link : on login page
        public By ResetEmailOnLoginPage => By.XPath("/html/body/div/section/div[2]/div/form/div/div[4]/a");


        //help page : Email field
        public By fieldCheck = By.XPath("/html/body/div/section/div[2]/div/form/div/div[1]/input");

        public IWebElement ResetEmailField => WebDriver.FindElement(By.XPath("/html/body/div/section/div[2]/div/form/div/div[1]/input"));
        
        public void EmailId(String emailId)
        {
            ResetEmailField.SendKeys(emailId);
        }

        //help page: password reset button
        public By PasswdResetButton => By.XPath("/html/body/div/section/div[2]/div/form/div/button");
        
        //Help page: success msg
        public By PasswordResetMsg => By.XPath("/html/body/div/section/div[2]/div/div/div/h3");

        //Help page: reset error msg

        public By PasswordResetErrorMsg => By.XPath("/html/body/div/section/div[2]/div/form/div/div[2]/div/p");

        //login page :org login button
        public By OrgLoginButton = By.XPath("/html/body/div/section/div[2]/div/form/div/a/button");

        //Org login : email field
        public By orgEmailFieldCheck = By.XPath("/html/body/div/section/div/div/form/div[1]/div/div/input");
        public IWebElement OrgEmailField => WebDriver.FindElement(By.XPath("/html/body/div/section/div/div/form/div[1]/div/div/input"));
       // public void ClickOrgEmailField() => OrgEmailField.Click();
        public void OrgEmailId(String emailId)
        {
            OrgEmailField.SendKeys(emailId);
        }

        //Org Login : Login button
        public By LogintoOrgButton = By.XPath("/html/body/div/section/div/div/form/div[1]/button");

        //Org error msg
        public By OrgErrorMsg = By.XPath("/html/body/div/section/div[2]/div/form/div/div[3]/div");

        //Signup page
        public By SinupPageContent = By.Id("register_athletes_join-a-team");
        public By LoginButtonOnSinupPage = By.XPath("/html/body/div[1]/header/div/a");
    }
}

    
