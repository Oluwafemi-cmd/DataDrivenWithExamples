using DataDrivenWithExamples.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExamples.StepDefinitions
{
    [Binding]
    public class DataDrivenWithExamplesStepDefinitions
    {

        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;

        public DataDrivenWithExamplesStepDefinitions()
        {
            dataDrivenWithExamplesPage= new DataDrivenWithExamplesPage();
        }


        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            dataDrivenWithExamplesPage.NavigateToWebsite(url);
        }

        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithExamplesPage.ClickOnSignUp();
        }

        [Given(@"I enter username ""([^""]*)""")]
        public void GivenIEnterUsername(string username)
        {
            dataDrivenWithExamplesPage.EnterUsername(username);
        }

        [Given(@"I enter email ""([^""]*)""")]
        public void GivenIEnterEmail(string email)
        {
            dataDrivenWithExamplesPage.EnterEmail(email);
        }

        [Given(@"I enter password ""([^""]*)""")]
        public void GivenIEnterPassword(string password)
        {
            dataDrivenWithExamplesPage.EnterPassword(password);
        }

        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithExamplesPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(8000);
            Assert.That(dataDrivenWithExamplesPage.IsNewArticleDisplayed);
        }
    }
}
