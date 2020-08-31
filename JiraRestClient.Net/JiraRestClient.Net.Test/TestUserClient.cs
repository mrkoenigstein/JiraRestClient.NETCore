using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestUserClient : BaseTest
    {

        [TestMethod]
        public void TestGetLoggedInUser()
        {
            var userClient = RestClient.UserClient;
            var task = userClient.GetLoggedInUser();
            var user = task.GetAwaiter().GetResult();
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void TestGetUserByUsername()
        {
            var userClient = RestClient.UserClient;
            var task = userClient.GetUserByUsername(Username);
            var user = task.GetAwaiter().GetResult();
            Assert.IsNotNull(user);
        }
    }
}