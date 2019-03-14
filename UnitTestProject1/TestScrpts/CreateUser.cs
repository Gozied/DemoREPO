using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.TestScrpts
{
    [TestClass]
    public class CreateUser
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void NavigatetoRegisterPage()
        {
            Console.WriteLine("the name of this test is:{0}", TestContext.TestName);
        }

        [TestMethod]
        public void RegisterUser()
        {
            Console.WriteLine("The outcome of this test is:{0}", TestContext.CurrentTestOutcome);
        }

    }
}
