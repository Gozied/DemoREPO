using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.SandBox
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void Elements()
        {
            NavigationHelper.NavigatetoUrl(ObjectRepository.Config.GetWebsite());

            Console.WriteLine("the page title is: {0}", PageTitleHelper.GetPageTitle());
            //LinkHelper.ClickLink(By.LinkText("Learn more about sponsorship"));
            //LinkHelper.ClickLink(By.PartialLinkText(" more about sponsorship"));
            //TextBoxHelper.ClearText(By.Id("q"));
            //TextBoxHelper.SendText(By.Id("q"), "Abel");
            LinkHelper.ClickLink(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/a/span[1]"));
            Thread.Sleep(4000);
            LinkHelper.ClickLink(By.LinkText("Register"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Name("agree")));
            CheckBoxHelper.CheckCheckBox(By.Name("agree"));
        }
    }
}





