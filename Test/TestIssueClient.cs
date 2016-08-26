using Micromata.Jira.Jql;
using System.Collections.Generic;
using Xunit;

namespace Micromata.Jira.Test
{
    public class TestIssueClient :BaseTest
    {
        [Fact]
        public void testGetIssueByKey(){
            var task = restClient.IssueClient.GetIssueByKey(issuekey_to_search);
            var issue = task.GetAwaiter().GetResult();
            Assert.NotNull(issue);
        }

        [Fact]
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
            Assert.NotNull(issue);
            Assert.NotNull(issue.fields.summary);
            Assert.NotNull(issue.fields.description);
            Assert.NotNull(issue.renderedFields.description);
           
        }
    }
}