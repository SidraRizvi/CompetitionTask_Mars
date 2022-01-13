using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTask2.Pages
{
    [Binding]
    public class JoinPage
    {
        private readonly IWebDriver WebDriver;
        public JoinPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
           
        }

        public IWebElement SkillTab => WebDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        public IWebElement JoinButton => WebDriver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));

        public IWebElement firstnameTxtBox => WebDriver.FindElement(By.Name("firstName"));
        public IWebElement lastnameTxtBox => WebDriver.FindElement(By.Name("lastName"));
        public IWebElement emailTxtBox => WebDriver.FindElement(By.Name("email"));
        public IWebElement passwordTxtBox => WebDriver.FindElement(By.Name("password"));
        public IWebElement confirmpasswordTxtBox => WebDriver.FindElement(By.Name("confirmPassword"));

        public IWebElement Joincheckbox => WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));

        public IWebElement JoinpageButton => WebDriver.FindElement(By.XPath("//*[@id='submit-btn']"));
        
        public void EnterFormDetails(string firstname, string lastname, string emailaddress, string password, string confirmpassword)
        {
            firstnameTxtBox.SendKeys(firstname);
            lastnameTxtBox.SendKeys(lastname);
            emailTxtBox.SendKeys(emailaddress);
            passwordTxtBox.SendKeys(password);
            confirmpasswordTxtBox.SendKeys(confirmpassword);

        }
        public void verifyJoinPageTitle()
        {
            String expectedTitle = "Home";
            String actualTitle = WebDriver.Title;
            Assert.AreEqual(actualTitle, expectedTitle);
        }


    }
}


