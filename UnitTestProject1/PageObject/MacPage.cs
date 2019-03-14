using System.Threading;
using OpenQA.Selenium;
using UnitTestProject1.ComponentHelper;

namespace UnitTestProject1.PageObject
{
    public  class MacPage
    {
        public MacPage()
        {
        }

        #region Weblement
        private readonly By _sortByOptions = By.Id("input-sort");
        private readonly By _sortByRange = By.Id("input-limit");
        private readonly By _addToCart= By.CssSelector(".button-group > button:nth-child(1)");
        private readonly By _shopingCartButton = By.CssSelector("#cart-total");



        #endregion




        #region Actions
        public void SelectMacByOptions()
        {
           DropDownHelper.SelectElementbyIndex(_sortByOptions,3);
        }

        public void DisplayMacByOptions()
        {
            DropDownHelper.SelectElementbyIndex(_sortByRange, 2);
        }

        public void AddToCart()
        {
            ButtonHelper.ClickButton(_addToCart);
        }

        public void ShowShopingCart()
        {
            Thread.Sleep(10000);
            ButtonHelper.ClickButton(_shopingCartButton);
        }


        public void AddItemsToShopingCart()
        {
            SelectMacByOptions();
            DisplayMacByOptions();
            AddToCart();
            ShowShopingCart();
        }


        #endregion



        #region Navigation



        #endregion



    }
}