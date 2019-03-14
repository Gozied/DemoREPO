using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.PageObject;

namespace UnitTestProject1.TestScrpts
{
    [TestClass]
    public class CreateUser
    {
        public TestContext TestContext { get; set; }
        private readonly HomePage _homePage = new HomePage();
        private readonly RegisterAccountPage _registerAccountPage = new RegisterAccountPage();
        private readonly AccountConfirmationPage _accountConfirmation = new AccountConfirmationPage();
        private readonly LoggOutHelper _loggOutHelper = new LoggOutHelper();

        [TestMethod, TestCategory("CreateUser--CSV")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @"C:\\Users\abeln\\Documents\\DemoREPO\\UnitTestProject1\\DataFiles\\.csv", "abel#csv", 
            DataAccessMethod.Sequential)]
        public void RegisterNewUaerAccount_CSV()
        {
            _homePage.RegisterAccountPage();
            _registerAccountPage.EnterFirstname(TestContext.DataRow["FirstName"].ToString());
            _registerAccountPage.EnterLastName(TestContext.DataRow["LastName"].ToString());
            _registerAccountPage.EnterEmail(TestContext.DataRow["Email"].ToString());
            _registerAccountPage.EnterPhoneNumeber(TestContext.DataRow["Phone"].ToString());
            _registerAccountPage.EnterPassword(TestContext.DataRow["PassWord"].ToString());
            _registerAccountPage.ConfirmPassword(TestContext.DataRow["ConfirmPassword"].ToString());
            _registerAccountPage.TickNewsLetterYes();
            _registerAccountPage.ClickAgreePolicy();
            _registerAccountPage.ClickContinueButton();
            _accountConfirmation.ConfirmAccountCreation();
            _loggOutHelper.GoToLogOutPage();
        }

        [TestMethod]
        public void RegisterUser()
        {
            Console.WriteLine("The outcome of this test is: {0}", TestContext.CurrentTestOutcome);
        }

    }
}
