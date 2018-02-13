using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordsmith.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement UserInput { get; set; }
        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement LogIn { get; set; }

        public void LoginToDashboard()

        {
            UserInput.Clear();
            UserInput.SendKeys("matthewwoodard7@gmail.com");
            PasswordInput.Clear();
            PasswordInput.SendKeys("Password1");
            LogIn.Click();
        }



        //To enter password field

       
    }

}
