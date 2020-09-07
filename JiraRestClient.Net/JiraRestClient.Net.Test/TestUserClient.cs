using FluentAssertions;
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
            var user = userClient.GetLoggedInUser();
            user.Should().NotBeNull();
        }

        [TestMethod]
        public void TestGetUserByUsername()
        {
            var userClient = RestClient.UserClient;
            var user = userClient.GetUserByUsername(Username);
            user.Should().NotBeNull();
        }
    }
}