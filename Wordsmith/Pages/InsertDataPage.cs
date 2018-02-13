using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordsmith.Pages
{
    class InsertDataPage
    {
        private IWebDriver driver;
        public InsertDataPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "segment__header-info")]
        private IWebElement dataVar { get; set; }

        public void ValidateData()
        {
            string test = dataVar.Text.ToString();
            Assert.IsTrue(test.Contains("videogame_name"));
        }
    }
}
