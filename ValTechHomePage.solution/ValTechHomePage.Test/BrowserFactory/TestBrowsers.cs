using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ValTechHomePage.Test.TestConfiguration;

namespace ValTechHomePage.Test.BrowserFactory
{
   public class TestBrowsers
   {
       private IWebDriver _driver;
        public void StartTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--incognito");
            _driver = new ChromeDriver(chromeOptions);
            _driver.Url = TestConfig.Default.BaseUrl;
            _driver.Manage().Window.Maximize();

        }

        public IWebDriver GetDriver()
        {
            return _driver;

        }

       public void StopTest()
       {
           _driver.Quit();


       }


    }
}
