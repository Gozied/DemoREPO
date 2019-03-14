using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public class AccountConfirmationPage
    {
        public AccountConfirmationPage()
        {

        }

        private const string PageTitle = "Your Account has been Created";
        private const string AccountCreationTextConfirmation = "Your Account has been Created";

        #region Assertions

        public void ConfirmAccountCreation()
        {
            Assert.IsTrue(ObjectRepository.Driver.PageSource.Contains(AccountCreationTextConfirmation));
            Assert.IsTrue(ObjectRepository.Driver.Title.Contains(PageTitle));
        }


        #endregion
    }

}
