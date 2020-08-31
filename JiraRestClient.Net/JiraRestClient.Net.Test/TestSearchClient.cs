using Cschulc.Jira.Jql;
using JiraRestClient.Net.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestSearchClient : BaseTest
    {
        [TestMethod]
        public void testSearchIssues()
        {
            var jsb = new JqlSearchBean();
            JqlBuilder builder = new JqlBuilder();
            string jql = builder.AddCondition(EField.Project, EOperator.EQUALS, "DEMO")
                    .And().AddCondition(EField.Status, EOperator.EQUALS, JqlConstants.StatusOpen)
                    .OrderBy(SortOrder.Asc, EField.Created);
            jsb.Jql = jql;
            jsb.AddField(EField.IssueKey, EField.Status, EField.Due, EField.Summary, EField.IssueType, EField.Priority, EField.Updated, EField.Transitions);
            jsb.AddExpand(EField.Transitions);
            var task = RestClient.SearchClient.SearchIssues(jsb);
            var result = task.GetAwaiter().GetResult();
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Total);
        }
    }

}