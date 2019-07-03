using Cschulc.Jira.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Cschulc.Jira.Test
{
    [TestClass]
    public class TestIssueClient :BaseTest
    {
        [TestMethod]
        public void testGetIssueByKey(){
            var task = restClient.IssueClient.GetIssueByKey(issuekey_to_search);
            var issue = task.GetAwaiter().GetResult();
            Assert.IsNotNull(issue);
        }

        [TestMethod]
        public void TestGetIssueByKeyWithFields()
        {
            List<string> fields = new List<string>();
            fields.Add(EField.SUMMARY.field);
            fields.Add(EField.DESCRIPTION.field);
            List<string> expands = new List<string>();
            expands.Add(EField.RENDEREDFIELDS.field);
            expands.Add(EField.TRANSITIONS.field);
            expands.Add(EField.CHANGELOG.field);
            var task = restClient.IssueClient.GetIssueByKey(issuekey_to_search, fields, expands);
            var issue = task.GetAwaiter().GetResult();
            Assert.IsNotNull(issue);
            Assert.IsNotNull(issue.fields.summary);
            Assert.IsNotNull(issue.fields.description);
            Assert.IsNotNull(issue.renderedFields.description);
           
        }
    }
}