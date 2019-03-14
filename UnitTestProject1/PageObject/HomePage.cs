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
        

        public void SelectDesktopHeader()
        {
            ButtonHelper.ClickButton(_desktop);
        }
        public void SelectMacHeader()
        {
            ButtonHelper.ClickButton(_macoption);
        }

        public MacPage GotoMacPage()
        {
            NavigationHelper.NavigatetoUrl(ObjectRepository.Config.GetWebsite());
            SelectDesktopHeader();
            SelectMacHeader();
            return new MacPage();
        }



    }

    
}
