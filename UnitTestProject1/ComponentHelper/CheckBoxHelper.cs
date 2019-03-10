using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement _element;
        public static void CheckCheckBox(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
            
        }

        public static bool IsCheckBoxChecked(By locator)
        {
            _element = GenericHelper.GetElement(locator);
           var checkbox =  _element.GetAttribute("type");

           if (checkbox ==null)
           {
               return false;
           }

           else
           {
               return checkbox.Equals("checkbox") || checkbox.Equals("true");
           }
        }
    }
}
