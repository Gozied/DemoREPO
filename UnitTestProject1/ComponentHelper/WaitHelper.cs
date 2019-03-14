using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class WaitHelper
    {
        private static IWebElement _element;

        public static void WaitForElement(By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15));
            _element = wait.Until(d => d.FindElement(locator));
        }
    }
}
