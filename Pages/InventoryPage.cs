using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class InventoryPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public InventoryPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public InventoryPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        By cartIcon = By.ClassName("shopping_cart_badge");
        By hamburgerMenu = By.Id("react-burger-menu-btn");
        By removeButton = By.Id("remove-sauce-labs-backpack");

        /// <summary>
        /// Metoda koja klikne na zeljeni proizvod
        /// </summary>
        /// <param name="itemName">Ime proizvoda</param>
        public void ClickOnItem(string itemName)
        {
            driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][contains(., '{itemName}')]")).Click();
        }

        /// <summary>
        /// Metoda koja klikne na dugme Add to cart
        /// </summary>
        private void ClickOnAddToCartButton()
        {
            ClickOnElement(addToCartButton);
        }

        /// <summary>
        /// Metoda koja vraca text/broj iz cart ikonice
        /// </summary>
        /// <returns>broj iz cart ikonice tipa string</returns>
        public string GetCartNumber()
        {
            return GetTextFromElement(cartIcon);
        }

        /// <summary>
        /// Metoda koja ubacuje u korpu odredjeni proizvod
        /// </summary>
        public void AddItemToCart()
        {
            ClickOnAddToCartButton();
        }

        /// <summary>
        /// Metoda koja klikne na hamburger menu dugme
        /// </summary>
        public void ClickOnHamburgerMenu()
        {
            ClickOnElement(hamburgerMenu);
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Metoda koja klikne na dugme remove na inventory page-u
        /// </summary>
        public void ClickOnRemoveButton()
        {
            ClickOnElement(removeButton);
            Thread.Sleep(800);
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
