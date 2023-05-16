using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class CheckoutPage : BasePage
    {
        /// <summary>
        /// Konstruktor bez parametra
        /// </summary>
        public CheckoutPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrom
        /// </summary>
        /// <param name="webDriver">driver</param>
        public CheckoutPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators

        By firstNameField = By.Id("first-name");
        By lastNameField = By.Id("last-name");
        By zipPostalCodeField = By.Id("postal-code");
        By continueButton = By.Id("continue");
        By finishButton = By.Id("finish");
        By completeTextHeader = By.ClassName("complete-header");

        /// <summary>
        /// Metoda koja upisuje vrednost u polje First Name
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteTextToElement(firstNameField, firstName);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Last Name
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLasttName(string lastName)
        {
            WriteTextToElement(lastNameField, lastName);
        }

        /// <summary>
        /// Metoda koja upisuje vrednost u polje Zip/Postal code
        /// </summary>
        /// <param name="zipCode">Postal code</param>
        private void EnterZipPostalCode(string zipCode)
        {
            WriteTextToElement(zipPostalCodeField, zipCode);
        }

        /// <summary>
        /// Metoda koja klikne na dugme Continue
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(continueButton);
        }
        
        /// <summary>
        /// Metoda koja klikne na dugme Finish
        /// </summary>
        public void ClickFinishButton()
        {
            ClickOnElement(finishButton);
        }

        public string GetOrderMessage()
        {
            return GetTextFromElement(completeTextHeader);
        }

        /// <summary>
        /// Metoda koja popunjava formu Your information
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="postalCode">Zip/Postal code</param>
        public void FillOutFormYourInformation(string firstName, string lastName, string postalCode)
        {
            EnterFirstName(firstName);
            EnterLasttName(lastName);
            EnterZipPostalCode(postalCode);
            ClickContinueButton();
        }
    }
}
