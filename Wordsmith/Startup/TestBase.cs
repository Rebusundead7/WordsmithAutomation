using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace Wordsmith.Startup
   
{
    [TestClass]
    public class TestBase
    {
        public static IWebDriver firefox;
        

        [TestInitialize]
        public static void Setup()
        {
            firefox = new FirefoxDriver();
            firefox.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            firefox.Manage().Window.Maximize();
            firefox.Navigate().GoToUrl("https://wordsmith.automatedinsights.com/");
            
        }
       
        
        [TestCleanup()]
        public void MyTestCleanup()
        {
            firefox.Quit();
        }
    }
}
