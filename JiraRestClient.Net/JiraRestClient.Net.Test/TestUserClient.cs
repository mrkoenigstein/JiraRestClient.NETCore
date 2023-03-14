using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestUserClient : BaseTest
    {
        
        [TestMethod]
        public void TestGetUserByUsername()
        {
            var userClient = RestClient.UserClient;
            var user = userClient.GetUserByUsername(AccountId);
            user.Should().NotBeNull();
        }

        [TestMethod]
        public void TestGetAccountIds()
        {
            var usernames = new List<string>
            {
                Username
            };
            var userClient = RestClient.UserClient;
            var userMigrations = userClient.GetAccountIds(usernames);
            userMigrations.Should().NotBeNull().And.NotBeEmpty();
        }
    }
}