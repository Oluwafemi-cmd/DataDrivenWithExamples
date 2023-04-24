using DataDrivenWithExamples.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithExamples.PageObject
{
    class DataDrivenWithExamplesPage
    {
        public DataDrivenWithExamplesPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[2]/a"));

        public void ClickOnSignUp() 
        { 
          SignUp.Click();
        }

        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);

        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void NavigateToWebsite(string url)
        {
           driver.Navigate().GoToUrl(url);
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed() 
        {
            return NewArticle.Displayed;
        
        }


    }
}
