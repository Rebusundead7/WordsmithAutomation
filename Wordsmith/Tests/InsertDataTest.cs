using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordsmith.Startup;
using Wordsmith.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace Wordsmith.Tests
{
    [TestClass]
    public class InsertDataTest : TestBase
    {
        [TestInitialize]
        public void TestSetup()
        {
            Setup();
        }
        [TestMethod]
        public void TestValidateData()
        {

            LoginNavigateToTest();

            var templatePage = new TemplatePage(TestBase.firefox);

            templatePage.ClickData();

            var insertDataPage = new InsertDataPage(TestBase.firefox);
            insertDataPage.ValidateData();
        }
        [TestMethod]
        public void TestAddSynonym()
        {

            LoginNavigateToTest();

            var templatePage = new TemplatePage(TestBase.firefox);

            PageFactory.InitElements(TestBase.firefox, templatePage);

            templatePage.ClickSynonym();

            var synonymPage = new SynonymPage(TestBase.firefox);
            synonymPage.SearchPage();
        }
        [TestMethod]
        public void TestBlankSynonym()
        {

            LoginNavigateToTest();

            var templatePage = new TemplatePage(TestBase.firefox);

            PageFactory.InitElements(TestBase.firefox, templatePage);

            templatePage.ClickSynonym();

            var synonymPage = new SynonymPage(TestBase.firefox);
            synonymPage.BlankPage();
        }
        [TestMethod]
        public void TestAddBranch()
        {

            LoginNavigateToTest();

            var templatePage = new TemplatePage(TestBase.firefox);

            templatePage.ClickBranch();

            var branchPage = new BranchPage();
            PageFactory.InitElements(TestBase.firefox, branchPage);
            branchPage.SearchPage();
        }
        [TestMethod]
        public void TestBlankBranch()
        {

            LoginNavigateToTest();

            var templatePage = new TemplatePage(TestBase.firefox);

            templatePage.ClickBranch();

            var branchPage = new BranchPage();
            PageFactory.InitElements(TestBase.firefox, branchPage);
            branchPage.BlankPage();
        }
        public void LoginNavigateToTest()
        {
            var loginPage = new LoginPage(TestBase.firefox);

            loginPage.LoginToDashboard();


            var dashboardPage = new DashboardPage(TestBase.firefox);

            dashboardPage.NavigateToDashboard();
        }
    }
}
