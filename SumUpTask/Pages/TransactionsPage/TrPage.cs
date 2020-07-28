using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUpTask.Pages.TransactionsPage
{
    public partial class TrPage : BasePage
    {
        public TrPage(IWebDriver driver)
               : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("https://sumup.bg/");
            Driver.Manage().Window.Maximize();
        }

        public void LogInRegisteredUser()
        {
            LogInBtn.Click();
            UserName.Clear();
            UserName.SendKeys("aneliabogeva@gbg.bg");
            Password.Clear();
            Password.SendKeys("aneliabogeva");
            SbmBtn.Click();
        }
    }
}
