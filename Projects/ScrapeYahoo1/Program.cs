using System;
using System.Net;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace ScrapeYahoo1
{    
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  var options = new ChromeOptions();
            //  options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver();

            var wait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 30));
            chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F/");
            //chromeDriver.FindElementByXPath("//*[@id='login - username']");

             var userName = chromeDriver.FindElementById("login-username");
            userName.SendKeys("stephcshea");
            var loginButton = chromeDriver.FindElementById("login-signin");
            loginButton.Click();

      var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("login-passwd")));       

var userPassword = chromeDriver.FindElementById("login-passwd");
userPassword.SendKeys("Abby7777!");
var loginButton2 = chromeDriver.FindElementById("login-signin");
loginButton2.Click();

 var profileTable = chromeDriver.FindElementByClassName("Mb(20px)");
 //*[@id="data-util-col"]/section[2]

            Console.WriteLine(profileTable);

//*[@id="data-util-col"]/section[2]
//*[@id="data-util-col"]/section[2]/table
     //*[@id="data-util-col"]/section[2]      
        }
    }
}