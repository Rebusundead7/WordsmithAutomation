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
    class DashboardPage
    {
        private IWebDriver driver;
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@class='ws-nav__link ws-nav__link--dashboard ws-nav__link--active' or @class='ws-nav__link ws-nav__link--dashboard']")]
        private IWebElement DashboardButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='flex flex-column flex-center']/span[text()='VideoGames']")]
        private IWebElement ProjectButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "page-heading__title")]
        private IWebElement Header { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='tab flex flex-align-center is-active' and text()='Templates' or @class='tab flex flex-align-center' and text()='Templates']")]
        private IWebElement TemplateButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='flex flex-column flex-center']/span[text()='VideoGames Template']")]
        private IWebElement TempButton { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "[class='mdl-button mdl-js-button mdl-js-ripple-effect dropdown-button table-dropdown-button']")]
        private IWebElement dropdown { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[class='dropdown-menu']>li")]
        public IList<IWebElement> DropdownItems { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised btn-primary btn-block btn-full-width']")]
        private IWebElement unlockSubmit { get; set; }
        public void NavigateToDashboard()   
        {
            DashboardButton.Click();
            ProjectButton.Click();
            string Test = Header.Text.ToString();

            Assert.IsTrue(Test.Contains("VideoGames"));
            TemplateButton.Click();
            
                dropdown.Click();
                    for (int i = 0; i < DropdownItems.Count; i++)
                        {
                
                if (DropdownItems[i].Text.Contains("Force"))
                {
                        string me = DropdownItems[i].Text.ToString();
                    DropdownItems[i].Click();
                    unlockSubmit.Click();
                }
            
        }
        TempButton.Click();

        }

        public void NavigateToPreview()
        {
            DashboardButton.Click();
            ProjectButton.Click();
            string Test = Header.Text.ToString();

            Assert.IsTrue(Test.Contains("VidoeGames"));
            TemplateButton.Click();

            TempButton.Click();

        }
    }
}
