using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class CartIconTest : BaseTest
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
        public void ValidateCartIconCounter()
        {
            Pages.InventoryItemPage.ClickOnAllAddToCartButtons();
            string cartNumber = Pages.InventoryPage.GetCartNumber(); // Broj u korpi nakon klikova na dugme add to cart
            Pages.InventoryPage.ClickOnRemoveButton();
            string cartNumberAfterDelete = Pages.InventoryPage.GetCartNumber(); // broj u korpi nakon brisanja jednog proizvoda

            // Assert test - Provera da li su dva broja iz korpe razlicita posle brisanja
            // jednog proizvoda iz korpe
            Assert.AreNotEqual(cartNumber, cartNumberAfterDelete);
        }
    }
}
