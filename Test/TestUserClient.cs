using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cschulc.Jira.Test
{
    [TestClass]
    public class TestUserClient : BaseTest
    {

        [TestMethod]
        public void testGetLoggedInUser()
        {
            var userclient = restClient.UserClient;
            var task = userclient.GetLoggedInUser();
            var user = task.GetAwaiter().GetResult();
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void TestGetUserByUsername()
        {
            var userclient = restClient.UserClient;
            var task = userclient.GetUserByUsername(username);
            var user = task.GetAwaiter().GetResult();
            Assert.IsNotNull(user);
        }
    }
}