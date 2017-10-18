using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ValTechHomePage.Test.Pages
{
    public class BasePage
    {

        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public HopePage GoToHomePage()
        {
            return new HopePage(Driver);
        }
    }
}
