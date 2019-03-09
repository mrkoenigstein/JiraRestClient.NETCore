using Micromata.Jira.Jql;
using Xunit;

namespace Cschulc.Jira.Test
{
    public class TestSearchClient : BaseTest
    {
        [Fact]
        public void testSearchIssues()
        {
            var jsb = new JqlSearchBean();
            JqlBuilder builder = new JqlBuilder();
            string jql = builder.AddCondition(EField.PROJECT, EOperator.EQUALS, "DEMO")
                    .And().AddCondition(EField.STATUS, EOperator.EQUALS, JqlConstants.STATUS_OPEN)
                    .OrderBy(SortOrder.ASC, EField.CREATED);
            jsb.jql = jql;
            jsb.AddField(EField.ISSUE_KEY, EField.STATUS, EField.DUE, EField.SUMMARY, EField.ISSUE_TYPE, EField.PRIORITY, EField.UPDATED, EField.TRANSITIONS);
            jsb.AddExpand(EField.TRANSITIONS);
            var task = restClient.SearchClient.SearchIssues(jsb);
            var result = task.GetAwaiter().GetResult() as JqlSearchResult;
            Assert.NotNull(result);
            Assert.Equal(7, result.total);
        }
    }

}