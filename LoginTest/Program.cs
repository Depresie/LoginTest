using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualBasic;

namespace TestSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); 
            driver.Navigate().GoToUrl("https://politrip.com/account/sign-up");

            Thread.Sleep(5000);
            driver.FindElement(By.Id("cookiescript_reject")).Click();


            //var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(" qa_loader-button")));

            driver.FindElement(By.Id("first-name")).SendKeys("Test");
            driver.FindElement(By.Id("last-name")).SendKeys("Heaven");
            driver.FindElement(By.Id("email")).SendKeys("TestHeaven04042022@yahoo.com");
            driver.FindElement(By.Id("sign-up-password-input")).SendKeys("Testheaven1!");
            driver.FindElement(By.Id("sign-up-confirm-password-input")).SendKeys("Testheaven1!");
                
            IWebElement selectElement = driver.FindElement(By.Id("sign-up-heard-input"));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue("other");
            
            Thread.Sleep(5000);
            driver.FindElement(By.Id(" qa_loader-button")).Click();
            
            Thread.Sleep(6000);
            driver.FindElement(By.Id("qa_signup-participant")).Click();
            
            Thread.Sleep(5000);
            
            driver.Close();

        }
    }
}