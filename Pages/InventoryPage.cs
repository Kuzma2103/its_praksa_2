using OpenQA.Selenium;

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

        /// <summary>
        /// Metoda koja klikne na zeljeni proizvod
        /// </summary>
        /// <param name="itemName">Ime proizvoda</param>
        public void ClickOnItem(string itemName)
        {
            driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][contains(., '{itemName}')]")).Click();
        }
    }
}
