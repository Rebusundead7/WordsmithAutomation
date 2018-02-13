using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wordsmith.Pages
{
    class TemplatePage
    {
        private IWebDriver driver;
        public TemplatePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised btn-secondary btn-insert-data']")]
        private IWebElement insertButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised btn-secondary btn-synonym']")]
        private IWebElement addSynonym { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised btn-secondary btn-branch']")]
        private IWebElement addBranchButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='ws-nav__link ws-nav__link--dashboard ws-nav__link--active' or @class='ws-nav__link ws-nav__link--dashboard']")]
        private IWebElement previewButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='public-DraftStyleDefault-block public-DraftStyleDefault-ltr']")]
        private IWebElement textBoxVar { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--raised back-button btn-primary']")]
        private IWebElement doneButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='public-DraftStyleDefault-block public-DraftStyleDefault-ltr']")]
        private IWebElement synonymTable { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='synonym_variations']")]
        private IWebElement ulTable { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='public-DraftStyleDefault-block public-DraftStyleDefault-ltr']")]
        private IWebElement text { get; set; }
        [FindsBy(How = How.ClassName, Using = "branch")]
        public IList<IWebElement> Lists { get; set; }
        [FindsBy(How = How.ClassName, Using = "synonym")]
        public IList<IWebElement> synonymLists { get; set; }
        [FindsBy(How = How.ClassName, Using = "datavar")]
        public IList<IWebElement> dataLists { get; set; }

        public void ClickData()
        {
            for (int i = 0; i < dataLists.Count; i++)
            {
                if (i == 0)
                {
                    dataLists[i].Click();
                    Assert.IsTrue(doneButton.Displayed);
                }


            }
        }
        public void ClickSynonym()
        {
            for (int i = 0; i < synonymLists.Count; i++)
            {
                if (i == 0)
                {
                    synonymLists[i].Click();
                    Assert.IsTrue(doneButton.Displayed);
                }


            }
        }
        public void ClickBranch()
        {

            for (int i = 0; i < Lists.Count; i++)
            {
                if (i == 0)
                {
                    Lists[i].Click();
                    Assert.IsTrue(doneButton.Displayed);
                }

                
            }
            
        }
        public void NavigateToInsert()
        {
            insertButton.Click();

        }
        public void NavigateToAddSynonym()
        {
            addSynonym.Click();
            
        }

        public void NavigateToAddBranch()
        {
            addBranchButton.Click();

        }
    }
}
