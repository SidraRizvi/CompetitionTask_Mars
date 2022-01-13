using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecflowTask2.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;


namespace SpecflowTask2.Steps
{
    [Binding]
    public sealed class Teststeps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;
        private readonly AddSellerDetailPage addSellerDetailPage;
        private readonly JoinPage joinpage;
        private readonly ShareSkill shareskill;

        public Teststeps(IWebDriver driver)
        {
            // Assign 'driver' to private field or use it to initialize a page object
            this.driver = driver;

            // Initialize Selenium page object
            this.loginPage = new LoginPage(driver);

            this.addSellerDetailPage = new AddSellerDetailPage(driver);
            
            this.joinpage = new JoinPage(driver);

            this.shareskill = new ShareSkill(driver);

         }

        [Given(@"I Launched the application")]
        public void GivenILaunchedTheApplication()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I Click Login link")]
        public void GivenIClickLoginLink()
        {
            loginPage.ClickLogIn();
        }

        [When(@"I enter ""(.*)"" in username and ""(.*)"" in password field")]
        public void WhenIEnterInUsernameAndInPasswordField(string p0, string p1)
        {
            loginPage.Login("sidra_riz@yahoo.com", "sid6638659");
        }

        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.ClickLoginButton();
           
        }

        [Then(@"I should be directed to profile page")]
        public void ThenIShouldBeDirectedToProfilePage()
        {
            Thread.Sleep(3000);
            loginPage.verifyHomePageTitle();
        }
               
          //Add Seller details Feature Test Steps
                       
              
        [Given(@"I am on Skill Tab of my Profile")]
        public void GivenIAmOnSkillTabOfMyProfile()
        {
            Thread.Sleep(3000);
            addSellerDetailPage.GotoSkilltab();
        }
        
        [When(@"I enter (.*) in txt box")]
        public void WhenIEnterInTxtBox(string SkillName)
        {
            addSellerDetailPage.EnterSkillName(SkillName);
        }

        [When(@"I enter (.*) in dropdown")]
        public void WhenIEnterInDropdown(string SkillLevel)
        {
            Thread.Sleep(2000);
            addSellerDetailPage.EnterSkillLevel(SkillLevel);
        }


        [When(@"I Click Add Button")]
        public void WhenIClickAddButton()
        {
            addSellerDetailPage.AddSClick();
        }

        [Then(@"Verify the (.*) should be available on screen")]
        public void ThenVerifyTheShouldBeAvailableOnScreen(string Message)
        {
            Thread.Sleep(3000);
            IWebElement popupmessage = driver.FindElement(By.XPath("//a[contains(@href,'#')]"));
           string getText = popupmessage.Text;


            // Check if the newly added record is present or not 
            Assert.That((Message.Contains(getText)), Is.True);
        }

        [When(@"I click Delete Icon of last added Skill")]
        public void WhenIClickDeleteIconOfLastAddedSkill()
        {
            IWebElement DeleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr[last()]/td[3]/span[2]/i"));
            DeleteIcon.Click();
        }

        [Then(@"verify that record has been deleted")]
        public void ThenVerifyThatRecordHasBeenDeleted()
        {
            Thread.Sleep(3000);
            IWebElement popupmessage = driver.FindElement(By.XPath("//div[contains(.,'Digital Marketing has been deleted')]"));
            string actualresult = popupmessage.Text;
            string expectedresult = "Digital Marketing has been deleted";
         
            // Check if the newly added record is present or not 
            Assert.AreEqual(expectedresult,actualresult); 
        }

        // Join User page test steps
        [Given(@"I click on Join Button")]
        public void GivenIClickOnJoinButton()
        {
            joinpage.JoinButton.Click();
        }

        [When(@"I fill the form with (.*) (.*) (.*) (.*) and (.*)")]
        public void WhenIFillTheFormWithAnd(string Firstname, string Lastname, string Emailaddress, string Password, string Confirmpassword)
        {
            Thread.Sleep(3000);
            joinpage.EnterFormDetails(Firstname, Lastname, Emailaddress, Password, Confirmpassword);
        }


        [When(@"Check the Terms and conditions box")]
        public void WhenCheckTheTermsAndConditionsBox()
        {
            Thread.Sleep(3000);
            joinpage.Joincheckbox.Click();
        }

        [When(@"I Click the Join button")]
        public void WhenIClicksTheJoinButton()
        {
            joinpage.JoinpageButton.Click();
        }

        [Then(@"(.*) should be displayed")]
        public void ThenShouldBeDisplayed(string Message)
        {
            Thread.Sleep(3000);
          //  IWebElement popupmessage = driver.FindElement(By.XPath("//a[contains(@href,'#')]"));
          //  string getText = popupmessage.Text;

          //  Check if the newly added record is present or not 
          //  Assert.That((Message.Contains(getText)), Is.True);
        }

        [Then(@"I should be directed to the SignIn page")]
        public void ThenIShouldBeDirectedToTheSignInPage()
        {
           joinpage.verifyJoinPageTitle();
        }

       // Share Skill Page

        [When(@"I click ShareSkill Button")]
        public void WhenIClickShareSkillButton()
        {
            Thread.Sleep(3000);
            shareskill.ShareSkillButton.Click();
        }


        [When(@"I enter ""(.*)"" in Title and ""(.*)"" in Description field")]
        public void WhenIEnterInTitleAndInDescriptionField(string Title, string Description)
        {
            Thread.Sleep(3000);
            shareskill.TitleTxtBox.SendKeys(Title);
            shareskill.DescriptionTxtBox.SendKeys(Description);
        }

        [When(@"I enter ""(.*)"" in Category,""(.*)"" in SubCategory")]
        public void WhenIEnterInCategoryInSubCategory(string Category, string Subcategory)
        {
            Thread.Sleep(3000);
            shareskill.SelectCategory(Category,Subcategory);
        }

        [When(@"""(.*)"" in Tags")]
        public void WhenInTags(string Tags)
        {
            Actions Scrolldown = new Actions(driver);
            Scrolldown.SendKeys(Keys.PageDown).Build().Perform();
            shareskill.TagTxtBox.SendKeys(Tags +"\n");
                       
        }

        [When(@"I select ""(.*)"" in Service Type and ""(.*)"" in Location Type")]
        public void WhenISelectInServiceTypeAndInLocationType(string ServiceType, string LocationType)
        {
            Thread.Sleep(3000);
            shareskill.SelectType("One-off service","Online");
        }

        [When(@"I pick ""(.*)"" in Startdate and ""(.*)"" in Enddate")]
        public void WhenIPickInStartdateAndInEnddate(string p0, string p1)
        {
            Thread.Sleep(3000);
            Actions Scrolldown = new Actions(driver);
            Scrolldown.SendKeys(Keys.PageDown).Build().Perform();
            shareskill.Selectstartdate.SendKeys(p0);
            shareskill.Selectenddate.SendKeys(p1);
            
        }
        [When(@"I pick ""(.*)"" in StartTime and ""(.*)"" in Endtime")]
        public void WhenIPickInStartTimeAndInEndtime(string p0, string p1)
        {
            Thread.Sleep(3000);
            shareskill.Selectstarttime.SendKeys(p0);
            shareskill.Selectendtime.SendKeys(p1);
        }


        [When(@"I select ""(.*)"" in SkillTrade and add ""(.*)"" Tag in Skill-Exchange")]
        public void WhenISelectInSkillTradeAndAddTagInSkill_Exchange(string SkillTrade, string Tag)
        {
            Thread.Sleep(3000);
            Actions Scrolldown = new Actions(driver);
            Scrolldown.SendKeys(Keys.PageDown).Build().Perform();
            Scrolldown.SendKeys(Keys.PageDown).Build().Perform();
            shareskill.SkillTradeRadiobutton.Click();
            shareskill.SkillTradeTag.SendKeys(Tag +"\n");
          
            
        }
               
        [When(@"I select ""(.*)"" in Active field")]
        public void WhenISelectInActiveField(string p0)
        {
            Thread.Sleep(3000);
            shareskill.SelectActiveService.Click();
        }



        [When(@"Click Save button")]
        public void WhenClickSaveButton()
        {
            Thread.Sleep(3000);
            shareskill.SaveButton.Click();
        }

        [Then(@"my listing should be available to view")]
        public void ThenMyListingShouldBeAvailableToView()
        {
            Thread.Sleep(3000);
            IWebElement actualCategoryName = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
            Assert.That(actualCategoryName.Text == "Writing & Translation", "actual name and expected name do not match.");
        }

        // Manage Listing Test steps

        [When(@"I click on Manage Listings Tab")]
        public void WhenIClickOnManageListingsTab()
        {
            Thread.Sleep(4000);
            shareskill.ManageListingsTab.Click();
        }


        [When(@"I click on Edit Icon on last added Listing")]
        public void WhenIClickOnEditIconOnLastAddedListing()
        {
            Thread.Sleep(3000);
            shareskill.EditListingIcon.Click();
           
        }

        [When(@"I updated ""(.*)"" in Title and ""(.*)"" in Description field")]
        public void WhenIUpdatedInTitleAndInDescriptionField(string UTitle, string UDescr)
        {
            Thread.Sleep(3000);
            shareskill.TitleTxtBox.Clear();
            shareskill.TitleTxtBox.SendKeys(UTitle);
            shareskill.DescriptionTxtBox.Clear();
            shareskill.DescriptionTxtBox.SendKeys(UDescr);

        }

        [When(@"I updated ""(.*)"" in Category,""(.*)"" in SubCategory")]
        public void WhenIUpdatedInCategoryInSubCategory(string Ucategory, string Usubcategory)
        {
            Thread.Sleep(3000);                        
            shareskill.SelectCategory(Ucategory,Usubcategory);
                     
            
        }

        [When(@"I Click Save button")]
        public void WhenIClickSaveButton()
        {
            
            var element = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

          //  Actions Scrolldown = new Actions(driver);
          //  Scrolldown.SendKeys(Keys.PageDown).Build().Perform();
           // Thread.Sleep(3000);
            shareskill.SaveButtonUp.Click();

        }



        [Then(@"my updated listing should be avalable to view")]
        public void ThenMyUpdatedListingShouldBeAvalableToView()
        {
            Thread.Sleep(3000);
            IWebElement actualCategoryName = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
            Assert.That(actualCategoryName.Text == "Business", "actual name and expected name do not match.");
        }















    }



}
