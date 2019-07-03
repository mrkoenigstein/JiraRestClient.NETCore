using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cschulc.Jira.Test
{
    public class TestSystemClient : BaseTest
    {

        [TestMethod]
        public void TestGetIssueTypes()
        {           
            var task = restClient.SystemClient.GetIssueTypes();
            var issueTypes = task.GetAwaiter().GetResult();
            Assert.AreEqual(11, issueTypes.Count);
        }

        [TestMethod]
        public void TestGetPriorities(){
            var task = restClient.SystemClient.GetPriorities();
            var priorities = task.GetAwaiter().GetResult();
            Assert.AreEqual(5, priorities.Count);
        }
    }
}