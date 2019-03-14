using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.PageObject;

namespace UnitTestProject1.TestScrpts
{
    [TestClass]
    public class ShopForMac
    {
        [TestMethod]
        public void PurchaseMac()
        {
            var homepage = new HomePage();
            homepage.GotoMacPage().AddItemsToShopingCart();
        }
    }
}
