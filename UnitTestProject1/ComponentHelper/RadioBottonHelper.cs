using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ComponentHelper
{
    public class RadioBottonHelper
    {
        private static IWebElement _element;

        public static bool IsClickRadioButton(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            var radioButtonStatus = _element.GetAttribute("ticked");

            if (radioButtonStatus != null)
            {
                return radioButtonStatus.Equals("true") || radioButtonStatus.Equals("radioSelect");
            }
            else
            {
                return false;
            }
        }
        public static void ClicRadiokButton(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }
    }
}
