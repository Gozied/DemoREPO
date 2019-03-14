using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class LogoutPage
    {
        public const string LogoutPageText = "You have logged off your account. It is now safe to leave the Computer";

        public LogoutPage()
        {

        }

        #region Assertions

        public void VerifylogoutPageIsDisplayed()
        {
          Assert.IsTrue(ObjectRepository.Driver.PageSource.Contains(LogoutPageText));
        }

        #endregion
    }
}