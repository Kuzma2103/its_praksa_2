using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomationFramework.Pages
{
    public class InventoryItemPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public InventoryItemPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public InventoryItemPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // locators
        By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        By cartButton = By.ClassName("shopping_cart_link");

        /// <summary>
        /// Metoda koja vrsi klik na dugme add to cart
        /// </summary>
        public void ClickOnAddToCartButton()
        {
            ClickOnElement(addToCartButton);
        }
        
        /// <summary>
        /// Metoda koja klikne na dugme cart
        /// </summary>
        public void ClickOnCartButton()
        {
            ClickOnElement(cartButton);
        }

        /// <summary>
        /// Metoda koja klikne na sve dugmice Add to cart u inventory page-u
        /// </summary>
        public void ClickOnAllAddToCartButtons()
        {
            IReadOnlyCollection<IWebElement> buttons = driver.FindElements(By.XPath("//button[contains(., 'Add to cart')]"));

            foreach (IWebElement button in buttons)
            {
                button.Click();
            }
        }
    }
}
