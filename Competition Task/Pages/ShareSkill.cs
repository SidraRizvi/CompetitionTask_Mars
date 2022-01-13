using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTask2.Pages
{
    [Binding]
    public class ShareSkill
    {
        private readonly IWebDriver WebDriver;
        public ShareSkill(IWebDriver webDriver)
        {
            WebDriver = webDriver;

        }

        // Click on ShareSkill button
        public IWebElement ShareSkillButton => WebDriver.FindElement(By.LinkText("Share Skill"));

        public IWebElement TitleTxtBox => WebDriver.FindElement(By.Name("title"));
        public IWebElement DescriptionTxtBox => WebDriver.FindElement(By.Name("description"));
        public IWebElement TagTxtBox => WebDriver.FindElement(By.XPath("//div[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

        public IWebElement SelectServiceType => WebDriver.FindElement(By.Name("serviceType"));

        public IWebElement SelectLocationType => WebDriver.FindElement(By.Name("locationType"));

        public IWebElement Selectstartdate => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

        public IWebElement Selectenddate => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));

        public IWebElement SkillTradeRadiobutton => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));

        public IWebElement SkillTradeTag => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));

        public IWebElement SkillTradeTagarea => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div"));
        public IWebElement SaveButton => WebDriver.FindElement(By.XPath("//input[@value='Save']"));
        public IWebElement SaveButtonUp => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));

        public IWebElement Selectstarttime => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        public IWebElement Selectendtime => WebDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));

        public IWebElement SelectActiveService => WebDriver.FindElement(By.Name("isActive"));

        public IWebElement ManageListingsTab => WebDriver.FindElement(By.LinkText("Manage Listings"));

        public IWebElement EditListingIcon => WebDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));

        // select category and subcategory
        public void SelectCategory(string category, string subcategory)
        {
            IWebElement Selectcategory = WebDriver.FindElement(By.Name("categoryId"));
            SelectElement element = new SelectElement(Selectcategory);
            element.SelectByText(category);

            IWebElement Selectsubcategory = WebDriver.FindElement(By.Name("subcategoryId"));
            SelectElement subelement = new SelectElement(Selectsubcategory);
            subelement.SelectByText(subcategory);

        }

        public void SelectType(string ServiceType, string LocationType)
        {
            SelectServiceType.Click();
            SelectLocationType.Click();
         }

        public void SelectDates(string startdate,string enddate)
        {
            Selectstartdate.Click();
           // IWebElement selectstartvalue = WebDriver.FindElement(By.(""));

            Selectenddate.Click();
        }

       

    }
}
