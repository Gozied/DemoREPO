using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace UnitTestProject1.Stepdef
{
    [Binding]
    public sealed class CreateANewUser
    {
        [Given(@"i am on the account creation page")]
        public void GivenIAmOnTheAccountCreationPage()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            ScenarioContext.Current.Pending();
        }

       

        [Given(@"i also enter my last name")]
        public void GivenIAlsoEnterMyLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"then i enter an email address")]
        public void GivenThenIEnterAnEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i enter a telephone number")]
        public void GivenIEnterATelephoneNumber()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i enter a valid passWord")]
        public void GivenIEnterAValidPassWord()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i then confirm the password")]
        public void GivenIThenConfirmThePassword()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i opt to subscribe fot the newsletter")]
        public void GivenIOptToSubscribeFotTheNewsletter()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i agree to privacy")]
        public void GivenIAgreeToPrivacy()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i select the continue button")]
        public void WhenISelectTheContinueButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"i can log out")]
        public void ThenICanLogOut()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"i can confirm am on the logout page")]
        public void ThenICanConfirmAmOnTheLogoutPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i then fail to confirm the password")]
        public void GivenIThenFailToConfirmThePassword()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
