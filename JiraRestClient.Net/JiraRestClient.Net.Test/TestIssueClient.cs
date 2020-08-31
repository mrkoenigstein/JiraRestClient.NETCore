using System.Collections.Generic;
using JiraRestClient.Net.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestIssueClient :BaseTest
    {
        [TestMethod]
        public void TestGetIssueByKey(){
            var task = RestClient.issueClient.GetIssueByKey(IssuekeyToSearch);
            var issue = task.GetAwaiter().GetResult();
            Assert.IsNotNull(issue);
        }

        [TestMethod]
        public void TestGetIssueByKeyWithFields()
        {
            var fields = new List<string> {EField.Summary.Field, EField.Description.Field};
            var expands = new List<string>
            {
                EField.Renderedfields.Field, EField.Transitions.Field, EField.Changelog.Field
            };
            var task = RestClient.issueClient.GetIssueByKey(IssuekeyToSearch, fields, expands);
            var issue = task.GetAwaiter().GetResult();
            Assert.IsNotNull(issue);
            Assert.IsNotNull(issue.Fields.Summary);
            Assert.IsNotNull(issue.Fields.Description);
            Assert.IsNotNull(issue.RenderedFields.Description);
           
        }
    }
}