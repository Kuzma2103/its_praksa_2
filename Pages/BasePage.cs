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
    }

    
}
