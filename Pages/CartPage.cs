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
        By removeButton = By.Id("remove-sauce-labs-backpack");


        /// <summary>
        /// Metoda koja vraca vrednost iz title elementa
        /// </summary>
        /// <returns>vraca string iz elementa</returns>
        public string GetItemName()
        {
            return driver.FindElement(itemNameTitle).Text;
        }

        /// <summary>
        /// Metoda koja proverava postojanje cart item-a 
        /// </summary>
        /// <returns>vraca true ako postoji u spurotnom false</returns>
        public bool IsCartItemDisplayed()
        {
            return IsElementDisplayed("class", "cart_item");
        }

        /// <summary>
        /// Metoda koja klikne na remove dugme u cart page-u
        /// </summary>
        public void ClickOnRemoveButton()
        {
            ClickOnElement(removeButton);
        }
    }
}
