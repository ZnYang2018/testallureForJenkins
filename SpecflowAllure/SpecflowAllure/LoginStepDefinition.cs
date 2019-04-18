using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowAllure
{
    [Binding]
    public sealed class LoginStepDefinition
    {
        [Given(@"I have opened the app")]
        public void GivenIHaveOpenedTheApp()
        {
        }

        [Given(@"I login in with username and password")]
        public void GivenILoginInWithUsernameAndPassword()
        {
        }

        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
        }

        [Then(@"I should see home page")]
        public void ThenIShouldSeeHomePage()
        {
            Random random = new Random();
            int number = random.Next(10);
            Assert.IsTrue(number % 2 == 0);
        }
    }
}
