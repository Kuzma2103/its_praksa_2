using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void LoginUser()
        {
            Pages.LoginPage.LoginUser(
                TestData.TestData.LoginTest.username, 
                TestData.TestData.LoginTest.password
            );

            // Asert testa
            Assert.IsTrue(Pages.LoginPage.IsLoggedIn());
        }

    }
}
