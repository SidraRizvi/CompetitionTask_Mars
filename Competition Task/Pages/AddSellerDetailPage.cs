using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTask2.Pages
{
    public class AddSellerDetailPage
    {
            private readonly IWebDriver WebDriver;
            public AddSellerDetailPage(IWebDriver webDriver)
            {
                WebDriver = webDriver;
              
            }

            public IWebElement SkillTab => WebDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

            public IWebElement SkillAddNewButton => WebDriver.FindElement(By.XPath("//div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));


            public IWebElement AddSkill => WebDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

            public IWebElement SkillNameTxtBox => WebDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
      


        public void verifyProfilePageTitle()
            {
                String expectedTitle = "Profile";
                String actualTitle = WebDriver.Title;
                Assert.AreEqual(actualTitle, expectedTitle);
            }

            public void GotoSkilltab()
            {
                SkillTab.Click();
                Thread.Sleep(3000);
                SkillAddNewButton.Click();
                Thread.Sleep(3000);


            }
            

        public void EnterSkillName(string skillName)
        {

            SkillNameTxtBox.SendKeys(skillName);      
           

        }

        public void EnterSkillLevel(string skillLevel)

        {
            Thread.Sleep(3000);
            IWebElement Skillleveldropdown = WebDriver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement element = new SelectElement(Skillleveldropdown);
            element.SelectByText(skillLevel);
        }
        public void AddSClick()
        {
            AddSkill.Click();
        }

    }
    }

