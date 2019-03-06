using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Configuration;

namespace UnitTestProject1.Interfaces
{
   public interface IConfig
   {
       string GetUserName();
       string GetPassword();
       BrowserType GetBrowser();
       string GetWebsite();

   }
}
