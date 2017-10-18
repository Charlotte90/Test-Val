using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ValTechHomePage.Test.BrowserFactory;
using ValTechHomePage.Test.Pages;

namespace ValTechHomePage.Test.TestArea
{
    [TestClass]
    public class HomePage
    {
        private TestBrowsers browsers;

        [TestInitialize]
        public void InitializeTest()
        {
             this.browsers = new TestBrowsers();
            browsers.StartTest();
        }


        [TestCleanup]
        public void PostTest()
        {
            browsers.StopTest();

        }

        [TestMethod]
        [TestCategory("Technical Test")]

        public void GoToVelTechHomePage()
        {
            string message = "Launch of VALTECT company website";
            IWebDriver driver = browsers.GetDriver();
            BasePage basePage = new BasePage(driver);
            basePage.GoToHomePage().ValidateMessage(message);



        }


    }





}
