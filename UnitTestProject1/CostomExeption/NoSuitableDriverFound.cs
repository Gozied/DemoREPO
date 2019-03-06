using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Configuration;

namespace UnitTestProject1.CostomExeption
{
    class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string message, BrowserType getBrowser) : base(message)
        {
           Console.WriteLine(message);
        }
    }
}
