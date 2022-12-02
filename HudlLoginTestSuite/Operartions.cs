using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudlLoginTestSuite
{
    public static class Operartions
    {
       
        public static IWebElement FindElement(IWebDriver driver, By element, int timeoutInSeconds = 20)
        {

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));


            IWebElement webElement;

            try
            {
                webElement = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (Exception x)
            {
                throw new Exception($"Error at element :{element} \n Message:  {x.Message}  \n InnerException: {x.InnerException}   \n Stacktrace: {x.StackTrace}");
            }
            return webElement;



        }
    }

}
