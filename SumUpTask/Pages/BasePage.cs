using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SumUpTask.Pages
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver Driver { get; private set; }

        public WebDriverWait Wait => new WebDriverWait(this.Driver, TimeSpan.FromSeconds(4));
    }
}
