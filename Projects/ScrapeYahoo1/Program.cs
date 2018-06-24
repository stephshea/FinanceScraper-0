using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F");
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

chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);

chromeDriver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_1/view/v1");

var popup = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("__dialog")));  

var closePopup = chromeDriver.FindElementByXPath("//dialog[@id = '__dialog']/section/button");
closePopup.Click();


// var profileTable = chromeDriver.FindElementByXPath("//[@id='data-util-col']/section[2]/table"); 

// var profileTable = chromeDriver.FindElementByXPath("//*[@id=\'main\']/section/section[2]/div[2]").Text; 

var profileTable = chromeDriver.FindElementByXPath("//[@id=\'main\']/section/section._64nqq/div.gIc8M/table").Text;

System.Console.WriteLine("profileTable: ", profileTable);  
        }
    }
}