using OpenQA.Selenium;

namespace ValTechHomePage.Test.Pages
{
    public class HopePage : BasePage
    {
        public HopePage(IWebDriver driver) : base(driver)
        {
        }

        public bool ValidateMessage(string message)
        {
            return Driver.FindElement(By.ClassName("news-widget-item-title")).Text.ToLower().Contains(message.ToLower());
        }
    }
}