using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Utilities;

namespace TestProject.PageObjects
{
    internal class SignUpPage
    {

        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));

        IWebElement popularTags => driver.FindElement(By.XPath("//p[text()='Popular Tags']"));


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            username.SendKeys("AMGTest" + randomInt);
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000); 
            email.SendKeys("testc#" + randomInt + "@gmail.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("C#testing");
        }

        public void ClickSignUpButtom()
        {
            signUp.Click();
        }

        public bool IsPopularTagsDisplayed()
        {
            return popularTags.Displayed;
        }
    }
}