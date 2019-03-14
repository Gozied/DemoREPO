using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public class HomePage
    {
        private readonly By _desktop = By.LinkText("Desktops");
        private readonly By _macoption = By.LinkText("Mac (1)");
        private readonly By _myAccountButton = By.XPath("//*[@id='top - links']/ul/li[2]/a/i");
        private readonly By _register = By.LinkText("Register");


        public void SelectDesktopHeader()
        {
            ButtonHelper.ClickButton(_desktop);
        }
        public void SelectMacHeader()
        {
            ButtonHelper.ClickButton(_macoption);
        }

        public void SelectMyAccountButton()
        {
            ButtonHelper.ClickButton(_myAccountButton);
        }

        public void SelectRegister()
        {
            ButtonHelper.ClickButton(_register);
        }


        public MacPage GotoMacPage()
        {
            NavigationHelper.NavigatetoUrl(ObjectRepository.Config.GetWebsite());
            SelectDesktopHeader();
            SelectMacHeader();
            return new MacPage();
        }

        public RegisterAccountPage RegisterAccountPage()
        {
            NavigationHelper.NavigatetoUrl(ObjectRepository.Config.GetWebsite());
            SelectMyAccountButton();
            SelectRegister();
            return new RegisterAccountPage();
        }

    }

    
}
