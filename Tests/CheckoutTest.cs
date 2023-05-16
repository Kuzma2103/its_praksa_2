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

            Pages.InventoryPage.ClickOnItem(TestData.TestData.AddToCart.itemName);
            Pages.InventoryItemPage.ClickOnAddToCartButton();
            Pages.InventoryItemPage.ClickOnCartButton();
        }

        [Test]
        public void PurchaseItem()
        {
            Pages.CartPage.ClickOnCheckoutButton();
            Pages.CheckoutPage.FillOutFormYourInformation(
                TestData.TestData.Checkout.firstName,
                TestData.TestData.Checkout.lastName,
                TestData.TestData.Checkout.zipPostalCode
            );
            Pages.CheckoutPage.ClickFinishButton();

            // Assert test
            Assert.AreEqual(
                Pages.CheckoutPage.GetOrderMessage(), 
                AppConstants.Constants.SystemMessages.orderMessage
            );        
        }
    }
}
