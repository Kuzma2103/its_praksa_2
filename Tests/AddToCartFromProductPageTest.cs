using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class AddToCartFromProductPageTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username, 
                TestData.TestData.LoginTest.password
            );

            Pages.InventoryPage.ClickOnItem(TestData.TestData.AddToCart.itemName);
        }

        [Test]
        public void AddToCartFromProductPage()
        {
            Pages.InventoryItemPage.ClickOnAddToCartButton();

            // Assert
            Pages.InventoryItemPage.ClickOnCartButton();
            string itemName = Pages.CartPage.GetItemName();
            Assert.AreEqual(TestData.TestData.AddToCart.itemName, itemName);
        }
    }
}
