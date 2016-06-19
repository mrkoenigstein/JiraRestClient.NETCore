using Xunit;

namespace Micromata.Jira.Test
{
    public class TestIssueClient :BaseTest
    {
        [Fact]
        public void testGetIssueByKey(){
            var task = restClient.IssueClient.GetIssueByKey("DEMO-1");
            var issue = task.GetAwaiter().GetResult();
            Assert.NotNull(issue);
        }
    }
}