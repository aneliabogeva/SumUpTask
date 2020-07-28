namespace SumUpTask
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using SumUpTask.Pages.TransactionsPage;

    [TestFixture]
    public class TransactionsTest
    {
        private IWebDriver _driver;
        private TrPage _trPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _trPage = new TrPage(_driver);
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LoginWithRegisteredUser()
        {
            //Act
            _trPage.NavigateTo();
            _trPage.LogInRegisteredUser();

            //Assert
            StringAssert.Contains("Anelia Angelova", _trPage.AccountName.Text);
        }

        [Test]
        public void SalesTransactionsCheckForToday()
        {
            //Act
            _trPage.NavigateTo();
            _trPage.LogInRegisteredUser();
            _trPage.SalesMenu.Click();
            _trPage.PeriodBtn.Click();
            _trPage.TodaySlsTr.Click();
            _trPage.SbtFltrBtn.Click();

            //Assert
            StringAssert.Contains("Не открихме нищо, което да отговаря на търсенето ви", _trPage.EmptySalesTransactions.Text);
        }
        

        //the same tests should be performed for the different type of period
        //by clicking different options from the period menu
        //and by choosing different options from Type payemnt
        [Test]
        public void SalesTransactionsCheckForWeek()
        {
            //Act
            _trPage.NavigateTo();
            _trPage.LogInRegisteredUser();
            _trPage.SalesMenu.Click();
            _trPage.PeriodBtn.Click();
            _trPage.LastWeekBtn.Click();
            _trPage.SbtFltrBtn.Click();

            //Assert
            StringAssert.Contains("Не открихме нищо, което да отговаря на търсенето ви", _trPage.EmptySalesTransactions.Text);
        }

        //Validation the transaction from Payments
        //As the tests above, all steps should be tested with differet periods and Type of payment
        //to verify the different combinations
        [Test]
        public void PaymentTransactionsCheckForToday()
        {
            _trPage.NavigateTo();
            _trPage.LogInRegisteredUser();
            _trPage.PaymentTransaction.Click();
            _trPage.PaymentTransactionPeriodBtn.Click();
            _trPage.TodayPaymentTrBtn.Click();
            _trPage.SbtFltrBtn.Click();
        }

    }
}
