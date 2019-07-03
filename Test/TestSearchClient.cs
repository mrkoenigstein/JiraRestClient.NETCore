using Cschulc.Jira.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cschulc.Jira.Test
{
    [TestClass]
    public class TestSearchClient : BaseTest
    {
        [TestMethod]
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
            var result = task.GetAwaiter().GetResult();
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.total);
        }
    }

}