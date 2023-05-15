using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class CartPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public CartPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public CartPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // locators
        By itemNameTitle = By.XPath("//div[@class='cart_item_label']/a/div");


        /// <summary>
        /// Metoda koja vraca vrednost iz title elementa
        /// </summary>
        /// <returns>vraca string iz elementa</returns>
        public string GetItemName()
        {
            return driver.FindElement(itemNameTitle).Text;
        }
    }
}
