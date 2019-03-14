using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.ComponentHelper
{
    public class LoggOutHelper
    {
        #region Webelement

        private readonly By _myaccountButton = By.XPath("");

        private readonly By _logoutButton = By.XPath("");

        #endregion


        #region Actions

        public void SelectMyAccountButton()
        {
            LinkHelper.ClickLink(_myaccountButton);
        }

        public void SelectLogOutButton()
        {
            LinkHelper.ClickLink(_logoutButton);
        }
        #endregion

        #region Navigation

        public LogoutPage GoToLogOutPage()
        {
            SelectMyAccountButton();
            SelectLogOutButton();
            return new LogoutPage();
        }
        
        

        #endregion
    }
}
