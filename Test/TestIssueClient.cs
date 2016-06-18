using Xunit;

namespace Micromata.Jira.Test
{
    public class TestIssueClient :BaseTest
    {
        [Fact]
        public void testGetIssueByKey(){
            JiraRestClient client = new JiraRestClient(uri, username, password);
            var task = client.IssueClient.getIssueByKey("DEMO-1");
            var issue = task.GetAwaiter().GetResult();
            Assert.NotNull(issue);
        }
    }
}