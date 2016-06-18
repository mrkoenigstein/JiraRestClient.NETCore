using Micromata.Jira.Jql;
using Xunit;

namespace Micromata.Jira.Test
{
    public class TestSearchClient : BaseTest
    {
        [Fact]
        public void testSearchIssues()
        {
            var restclient = new JiraRestClient(uri, username, password);
            var jsb = new JqlSearchBean();
            JqlBuilder builder = new JqlBuilder();
            string jql = builder.addCondition(EField.PROJECT, EOperator.EQUALS, "DEMO")
                    .and().addCondition(EField.STATUS, EOperator.EQUALS, JqlConstants.STATUS_OPEN)
                    .orderBy(SortOrder.ASC, EField.CREATED);
            jsb.jql = jql;
            jsb.AddField(EField.ISSUE_KEY, EField.STATUS, EField.DUE, EField.SUMMARY, EField.ISSUE_TYPE, EField.PRIORITY, EField.UPDATED, EField.TRANSITIONS);
            jsb.AddExpand(EField.TRANSITIONS);
            var task = restclient.SearchClient.searchIssues(jsb);
            var result = task.GetAwaiter().GetResult() as JqlSearchResult;
            Assert.NotNull(result);
            Assert.Equal(result.total, 7);
        }
    }

}