using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigatetoUrl(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);

        }
    }
}
