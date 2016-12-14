using Xunit;

namespace Micromata.Jira.Test
{
    public class TestSystemClient : BaseTest
    {

        [Fact]
        public void TestGetIssueTypes()
        {           
            var task = restClient.SystemClient.GetIssueTypes();
            var issueTypes = task.GetAwaiter().GetResult();
            Assert.Equal(11, issueTypes.Count);
        }

        [Fact]
        public void TestGetPriorities(){
            var task = restClient.SystemClient.GetPriorities();
            var priorities = task.GetAwaiter().GetResult();
            Assert.Equal(5, priorities.Count);
        }
    }
}