using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTask2.Hooks
{
    [Binding]
    public class WEBHooks1
    {
        private readonly IObjectContainer container;

        public WEBHooks1(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            ChromeDriver driver = new ChromeDriver();

            // Make 'driver' available for DI
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void DestroyWebDriver()
        {
            var driver = container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}

