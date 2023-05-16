using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class AddToCartFromInventoryPageTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Login user
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username,
                TestData.TestData.LoginTest.password
            );
        }

        [Test]
        public void AddtoCartFromInventory()
        {
            Pages.InventoryItemPage.ClickOnAddToCartButton();
            // Pages.InventoryPage.AddItemToCart(); - Poziva metodu iz inventory page klase

            string cartNumber = Pages.InventoryPage.GetCartNumber();

            Assert.AreEqual("1", cartNumber);

            // Assert
            Pages.InventoryItemPage.ClickOnCartButton();
            string itemName = Pages.CartPage.GetItemName();
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, itemName);
        }

        [TearDown]
        public void TearDown()
        {
            // Brisanje proizvoda iz korpe
            Pages.CartPage.ClickOnRemoveButton();
            Assert.IsFalse(Pages.CartPage.IsCartItemDisplayed());
        }
    }
}
