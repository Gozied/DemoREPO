using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.ComponentHelper
{
    public class DropDownHelper
    {
        private static SelectElement _select;

        public static void SelectElementbyIndex(By locator, int indexvalue)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByIndex(indexvalue);
        }

        public static void SelectElementbyValue(By locator, string visibleText)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByValue(visibleText);
        }

        public static void SelectElementbyText(By locator, string visibleText)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByText(visibleText);
        }

        public static IList<string> AllDropdownmenuItem(By locator)
        {
            return _select.Options.Select(x => x.Text).ToList();
        }
    }

}
