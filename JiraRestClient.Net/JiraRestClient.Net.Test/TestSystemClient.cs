using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestSystemClient : BaseTest
    {

        [TestMethod]
        public void TestGetIssueTypes()
        {           
            var issueTypes = RestClient.SystemClient.GetIssueTypes();
            issueTypes.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void TestGetPriorities(){
            var priorities = RestClient.SystemClient.GetPriorities();
            priorities.Should().NotBeNullOrEmpty();
        }
    }
}