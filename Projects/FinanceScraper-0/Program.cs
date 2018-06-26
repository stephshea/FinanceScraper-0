using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
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
       FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Users/Owner/Projects/FinanceScraper-0/bin/Debug/netcoreapp2.1/");

    var driver = new FirefoxDriver();
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

driver.Url = "https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Fßfinance.yahoo.com%2F";

            var userName = driver.FindElementById("login-username");
            userName.SendKeys("stephcshea");
            var loginButton = driver.FindElementById("login-signin");
            loginButton.Click(); 

// driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);   
// driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        wait.Until(loc => loc.FindElement(By.Id("login-passwd")));

        var userPassword = driver.FindElementById("login-passwd");  
        userPassword.SendKeys("Abby7777!");
        var loginButton2 = driver.FindElementById("login-signin");
        loginButton2.Click();

        // driver.Url = "https://finance.yahoo.com/portfolio/p_1/view/v1";
// driver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_0/view/v1");
//         wait.Until(loc => loc.FindElement(By.Id("__dialog")));

// var closePopup =(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("__dialog")));
// var closePopup = driver.FindElement(By.XPath("//dialog[@id = '__dialog']/section/button"));
// closePopup.Click(); 


// driver.Quit();
        }
    }
}