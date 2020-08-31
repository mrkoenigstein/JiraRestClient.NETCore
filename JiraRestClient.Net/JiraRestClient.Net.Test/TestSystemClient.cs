using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    public class TestSystemClient : BaseTest
    {

        [TestMethod]
        public void TestGetIssueTypes()
        {           
            var task = RestClient.SystemClient.GetIssueTypes();
            var issueTypes = task.GetAwaiter().GetResult();
            Assert.AreEqual(11, issueTypes.Count);
        }

        [TestMethod]
        public void TestGetPriorities(){
            var task = RestClient.SystemClient.GetPriorities();
            var priorities = task.GetAwaiter().GetResult();
            Assert.AreEqual(5, priorities.Count);
        }
    }
}