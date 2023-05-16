using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LogoutTest : BaseTest
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
        public void Logout()
        {
            Pages.InventoryPage.ClickOnHamburgerMenu();
            Pages.InventoryPage.ClickOnMenuItem(AppConstants.Constants.MenuItems.logout);

            // Assert test
            // Check if Login button is displayed on the page
            Assert.IsTrue(Pages.LoginPage.IsElementDisplayed("id", "login-button"));
        }
    }
}
