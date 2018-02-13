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
    class SynonymPage
    {
        private IWebDriver driver;
        public SynonymPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[class='public-DraftStyleDefault-block public-DraftStyleDefault-ltr']")]
        public IList<IWebElement> Rules { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[class='public-DraftStyleDefault-block public-DraftStyleDefault-ltr']")]
        private IWebElement fullText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised back-button btn-primary']")]
        private IWebElement doneButton { get; set; }

        public void SearchPage()
        {


            for (int i = 0; i < Rules.Count; i++)
            {
                if (i == 1)
                {
                    Rules[i].Clear();

                    Rules[i].Click();
                    Rules[i].Text.ToString();
                    Rules[i].SendKeys("Test");
                    doneButton.Click();
                }
            
            Assert.IsTrue(fullText.Text.Contains("Test"));
        }
        }
        public void BlankPage()
        {


            for (int i = 0; i < Rules.Count; i++)
            {
                if (i == 1)
                {
                    Rules[i].Clear();

                    Rules[i].Click();
                    Rules[i].Text.ToString();
                    Assert.IsTrue(Rules[i].Text.Contains("")); 
                }

                
            }
        }
    }
}
