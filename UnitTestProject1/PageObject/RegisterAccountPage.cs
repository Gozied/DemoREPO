using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnitTestProject1.ComponentHelper;

namespace UnitTestProject1.PageObject
{
    public class RegisterAccountPage
    {
        #region Webelement

        private readonly By _firstName = By.Id("input-firstname");
        private readonly By _lastName = By.Id("input-lastname");
        private readonly By _email = By.Id("input-email");
        private readonly By _phone = By.Id("input-telephone");
        private readonly By _password = By.Id("input-password");
        private readonly By _confirmPassword = By.Id("input-confirm");
        private readonly By _newsLetterYes = By.CssSelector("#content > form > fieldset:nth-child(3) > div > div > label:nth-child(1) > input[type='radio']");
        private readonly By _newsLetterNo = By.CssSelector("#content > form > fieldset:nth-child(3) > div > div > label:nth-child(2) > input[type='radio']");
        private readonly By _agreePolicy = By.CssSelector("#content > form > div > div > a > b");
        private readonly By _continueButton = By.CssSelector("input.btn-primary");
       #endregion


        #region Actions

        public void EnterFirstname(string text)
        {
          TextBoxHelper.SendText(_firstName, text);
        }

        public void EnterLastName(string text)
        {
            TextBoxHelper.SendText(_lastName, text);
        }

        public void EnterEmail(string text)
        {
            TextBoxHelper.SendText(_email, text);
        }

        public void EnterPhoneNumeber(string text)
        {
            TextBoxHelper.SendText(_phone, text);
        }

        public void EnterPassword(string text)
        {
            TextBoxHelper.SendText(_password, text);
        }

        public void ConfirmPassword(string text)
        {
            TextBoxHelper.SendText(_confirmPassword, text);
        }

        public void TickNewsLetterYes()
        {
         RadioBottonHelper.ClicRadiokButton(_newsLetterYes);
        }

        public void TickNewsLetterNo()
        {
         RadioBottonHelper.ClicRadiokButton(_newsLetterNo);
        }

        public void ClickAgreePolicy()
        {
          LinkHelper.ClickLink(_agreePolicy);
        }

        public void ClickContinueButton()
        {
          LinkHelper.ClickLink(_continueButton);
        }

        #endregion


        #region Navigattion

        //[DataSource()]
        //public AccountConfirmationPage AccountConfirmationPage()
        //{
        // EnterFirstname();
        // EnterLastName();
        // EnterEmail();
        // EnterPhoneNumeber();
        // EnterPassword();
        // ConfirmPassword();
        // TickNewsLetterYes();
        // TickNewsLetterNo();
        // ClickAgreePolicy();
        // ClickContinueButton();
        // return new AccountConfirmationPage();
        //}

        #endregion
    }
}