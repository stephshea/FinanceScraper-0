using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace FinanceScraper0 {
    class MainClass {
        public static void Main (string[] args) {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService ("/Users/Owner/Projects/FinanceScraper-0/bin/Debug/netcoreapp2.1/");

            var driver = new FirefoxDriver ();
            var wait = new WebDriverWait (driver, TimeSpan.FromSeconds (10));

            driver.Url = "https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Fßfinance.yahoo.com%2F";

            var userName = driver.FindElementById ("login-username");
            userName.SendKeys ("stephcshea");
            var loginButton = driver.FindElementById ("login-signin");
            loginButton.Click ();

            wait.Until (loc => loc.FindElement (By.Id ("login-passwd")));

            var userPassword = driver.FindElementById ("login-passwd");
            userPassword.SendKeys ("Abby7777!");
            var loginButton2 = driver.FindElementById ("login-signin");
            loginButton2.Click ();

            driver.Url = "https://finance.yahoo.com/portfolio/p_1/view/v1";
            wait.Until (loc => loc.FindElement (By.Id ("__dialog")));

            var closePopup = driver.FindElement (By.XPath ("/html/body/dialog/section/button"));
            closePopup.Click ();
        }
    }
}