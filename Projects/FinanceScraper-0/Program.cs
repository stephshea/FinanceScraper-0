

using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox; 

namespace FinanceScraper0
{    
    class MainClass
    {
        public static void Main(string[] args)
        {
    //    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Users/Owner/Projects/FinanceScraper-0/bin/Debug/netcoreapp2.1/");

           var driver = new FirefoxDriver();
        //    ("/Users/Owner/Projects/FinanceScraper-0/bin/Debug/netcoreapp2.1/");

            // var FirefoxDriver = new FirefoxDriver();

            // var wait = new WebDriverWait(FirefoxDriver, new TimeSpan(0, 0, 30));

            driver.Url = "https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F";

             var userName = driver.FindElementById("login-username");
            userName.SendKeys("stephcshea");
            var loginButton = driver.FindElementById("login-signin");
            loginButton.Click();

    (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("login-passwd")));       

var userPassword = driver.FindElementById("login-passwd");
userPassword.SendKeys("Abby7777!");
var loginButton2 = driver.FindElementById("login-signin");
loginButton2.Click();

//redirect

// FirefoxDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);

// FirefoxDriver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_1/view/v2");

// var popup = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("__dialog")));  

// var closePopup = FirefoxDriver.FindElementByXPath("//dialog[@id = '__dialog']/section/button");
// closePopup.Click(); 


// var profile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main")));

// var profileTable = FirefoxDriver.FindElement(By.XPath("//*[@id=\"main\"]/section/header/div/div[2]/div/div[3]/section/section[2]/div/div[2]")).Text;

// System.Console.WriteLine("profileTable: ", profileTable);  
        }
    }
}