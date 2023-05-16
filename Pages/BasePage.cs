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
        /// Metoda koja proverva vidljivost elementa na page-u
        /// </summary>
        /// <returns>vraca true ako postoji na page-u u suprotnom false</returns>
        public bool IsElementDisplayed(string className)
        {
            try
            {
                // Find the table row element
                IWebElement cartItem = driver.FindElement(By.ClassName(className));

                // Return whether the table row is displayed or not
                return cartItem.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the table row element is not found, return false
                return false;
            }
        }
    }    
}
