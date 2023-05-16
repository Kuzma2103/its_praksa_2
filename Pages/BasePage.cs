using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        // Driver
        public IWebDriver? driver;
        // WebDriverWait
        public WebDriverWait wait;

        /// <summary>
        /// Metoda koja ceka vidljivost elementa
        /// </summary>
        /// <param name="element">lokator elementa</param>
        private void WaitForElementToBeVisible(By element)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }

        /// <summary>
        /// Metoda koja vrsi klik na element
        /// </summary>
        /// <param name="element">lokator elementa</param>
        public void ClickOnElement(By element)
        {
            WaitForElementToBeVisible(element);
            driver.FindElement(element).Click();
        }

        /// <summary>
        /// Metoda koja upisuje tekst u element
        /// </summary>
        /// <param name="element">element</param>
        /// <param name="text">tekst koji upisujemo u element</param>
        public void WriteTextToElement(By element, string text)
        {
            WaitForElementToBeVisible(element);
            driver.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Metoda koja vraca text iz elementa
        /// </summary>
        /// <param name="element">lokator elementa</param>
        /// <returns>Vraca tekst iz elementa</returns>
        public string GetTextFromElement(By element)
        {
            WaitForElementToBeVisible(element);
            return driver.FindElement(element).Text;
        }

        /// <summary>
        /// Metoda koja proverava da li je element vidljiv na stranici
        /// </summary>
        /// <param name="attributeName">atribut iz html-a po kome se gadja lokator</param>
        /// <param name="attributeValue">vrednost atributa</param>
        /// <returns>Vraca true ako je element vidljiv, false ako nije</returns>
        public bool IsElementDisplayed(string attributeName, string attributeValue)
        {
            try
            {
                // Locator of element
                string locator = $"//*[@{attributeName}='{attributeValue}']";
                IWebElement element = driver.FindElement(By.XPath(locator));

                // Return whether the element is displayed or not
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return false
                return false;
            }
        }

        /// <summary>
        /// Metoda koja klikne na menu element
        /// </summary>
        /// <param name="menuItemId">id lokator elementa iz menija</param>
        public void ClickOnMenuItem(string menuItemId)
        {
            string menuItemLocator = $"{menuItemId}";
            driver.FindElement(By.Id(menuItemLocator)).Click();
        }
    }    
}
