using System;
using TechTalk.SpecFlow;
using TestProject.PageObjects;

namespace TestProject.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebsite();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }

        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            signUpPage.EnterEmail();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
        }

        [When(@"I click on Sign Up")]
        public void WhenIClickOnSignUp()
        {
            signUpPage.ClickSignUpButtom();
        }

        [Then(@"I should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            Thread.Sleep(5000);
            Assert.That(signUpPage.IsPopularTagsDisplayed());
        }
    }
}
