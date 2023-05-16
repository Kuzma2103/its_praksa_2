using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class CheckoutTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Login user
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username,
                TestData.TestData.LoginTest.password
            );

            // Dodavanje proizvoda u korpu
            AddItemToCart();
        }

        [Test]
        public void PurchaseItem()
        {
            // Kupovina proizvoda
            Pages.CartPage.ClickOnCheckoutButton();
            Pages.CheckoutPage.FillOutFormYourInformation(
                TestData.TestData.Checkout.firstName,
                TestData.TestData.Checkout.lastName,
                TestData.TestData.Checkout.zipPostalCode
            );
            Pages.CheckoutPage.ClickFinishButton();

            // Assert test - Provera poruke nakon kupovine
            Assert.AreEqual(
                Pages.CheckoutPage.GetOrderMessage(), 
                AppConstants.Constants.SystemMessages.orderMessage
            );        
        }

        /// <summary>
        /// Preduslovna metoda koja dodaje proizvod u korpu
        /// </summary>
        private void AddItemToCart()
        {
            Pages.InventoryPage.ClickOnItem(TestData.TestData.AddToCart.itemName);
            Pages.InventoryItemPage.ClickOnAddToCartButton();
            Pages.InventoryItemPage.ClickOnCartButton();
        }
    }
}
