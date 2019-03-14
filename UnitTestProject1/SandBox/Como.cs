using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.SandBox
{
    [TestClass]
    public class Como
    {
        [TestMethod]
        public void MenuDropDown()
        {
            NavigationHelper.NavigatetoUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("Desktops"));
            LinkHelper.ClickLink(By.LinkText("Mac (1)"));
            DropDownHelper.SelectElementbyIndex(By.Id("input-sort"),3);
            //DropDownHelper.SelectElementbyValue(By.Id("input-limit"), "");
            DropDownHelper.SelectElementbyText(By.Id("input-sort"), "Rating (Highest)");

        }
    }
}
