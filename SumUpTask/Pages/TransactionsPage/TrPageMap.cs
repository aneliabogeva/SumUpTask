using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUpTask.Pages.TransactionsPage
{
    public partial class TrPage
    {
        public IWebElement LogInBtn => this.Driver.FindElement(By.CssSelector("#__next > div.css-1mb7ubk.e1pq9xcs0 > header > div > div.css-k2w4eq.e1dtudxb0 > div.css-7o2k4h.e1dtudxb1 > div > a"));

        public IWebElement UserName => this.Driver.FindElement(By.Id("username"));

        public IWebElement Password => this.Driver.FindElement(By.Id("password"));

        public IWebElement SbmBtn => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div/div/div/div/div/div/div/div[2]/div/form/footer/button"));

        public IWebElement AccountName => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[1]/nav/div/div/div[2]/p"));

        public IWebElement EmptySalesTransactions => this.Driver.FindElement(By.CssSelector("//*[@id='root']/div[1]/div[2]/div[2]/div/div/div/div[2]/div/div/div[2]/div[2]/div/h2"));

        public IWebElement PeriodBtn => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[2]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/div/div"));

        public IWebElement TodaySlsTr => this.Driver.FindElement(By.Id("radio-button_56"));

        public IWebElement SbtFltrBtn => this.Driver.FindElement(By.CssSelector("#root > div.css-p3qrld-LayoutContainer-LayoutContainer.ebu07qc0 > div.css-ey7zkq-LayoutContainer-LayoutContainer.ebu07qc0 > div.css-ekclm4-Routes > div > div > div > div.css-15kqazf-spacing-spacing--margin-bottom.e1nf24cx0 > div > div > div:nth-child(2) > div:nth-child(1) > div.css-1rk1u1m-FilterBarWrapper.en4yzri0 > div.css-tjlaw2-FiltersWrapper.es55xyg0 > div.css-1jfja9r-popover.eh1a4d01 > div > div > div.css-pygw98-spacing-spacing--margin-top.e1nf24cx0 > div > button.eedbpl91.css-pv8cta-text-text--mega-text--no-margin-button__link-button__link--primary-ActionButton.e1hfi21m1"));

        public IWebElement SalesMenu => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[1]/nav/ul/li[2]/a/div"));

        public IWebElement LastWeekBtn => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[2]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/div[2]/div/div/div[2]/label"));

        public IWebElement PaymentTransaction => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[1]/nav/ul/li[3]/a"));

        public IWebElement PaymentTransactionPeriodBtn => this.Driver.FindElement(By.XPath("//*[@id='root']/div[1]/div[2]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/div/div"));

        public IWebElement TodayPaymentTrBtn => this.Driver.FindElement(By.Name("radio-button-group_41"));


    }
}
