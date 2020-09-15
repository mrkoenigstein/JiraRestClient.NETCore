using FluentAssertions;
using JiraRestClient.Net.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestSearchClient : BaseTest
    {
        [TestMethod]
        public void TestSearchIssues()
        {
            var jsb = new JqlSearchBean();
            var builder = new JqlBuilder();
            var jql = builder.AddCondition(EField.Project, EOperator.EQUALS, "DEMO")
                    .And().AddCondition(EField.Status, EOperator.EQUALS, JqlConstants.StatusInProgress)
                    .OrderBy(SortOrder.Asc, EField.Created);
            jsb.Jql = jql;
            jsb.AddField(EField.IssueKey, EField.Status, EField.Due, EField.Summary, EField.IssueType, EField.Priority, EField.Updated, EField.Transitions);
            jsb.AddExpand(EField.Transitions);
            var result = RestClient.SearchClient.SearchIssues(jsb);
            result.Should().NotBeNull();
        }
    }
}