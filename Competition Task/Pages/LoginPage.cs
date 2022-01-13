using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTask2.Pages
{
   [Binding]
    public class LoginPage
    {
        private readonly IWebDriver WebDriver;
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
           
        }


        public IWebElement lnkLogin => WebDriver.FindElement(By.ClassName("item"));
        public IWebElement TxtUserName => WebDriver.FindElement(By.Name("email"));

        public IWebElement TxtPassword => WebDriver.FindElement(By.Name("password"));

        public IWebElement BtnLogin => WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void ClickLogIn() => lnkLogin.Click();

        public void verifyHomePageTitle()
        {
            String expectedTitle = "Profile";
            String actualTitle = WebDriver.Title;
            Assert.AreEqual(actualTitle, expectedTitle);
        }

            

        public void Login(string useremail, string password)
        {

            TxtUserName.SendKeys(useremail);

            TxtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => BtnLogin.Submit();

       

    }



}

