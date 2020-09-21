using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestPermissionsClient : BaseTest
    {

        [TestMethod]
        public void TestGetMyPermissions()
        {
            var myPermissions = RestClient.PermissionsClient.GetMyPermissions(ProjectKey);
            myPermissions.Should().NotBeNull();
        }
    }
}