using System.Collections.Generic;
using FluentAssertions;
using JiraRestClient.Net.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestIssueClient :BaseTest
    {
        [TestMethod]
        public void TestGetIssueByKey(){
            var issue = RestClient.IssueClient.GetIssueByKey(IssuekeyToSearch);
            issue.Should().NotBeNull();
        }

        [TestMethod]
        public void TestGetIssueByKeyWithFields()
        {
            var fields = new List<string> {EField.Summary.Field, EField.Description.Field};
            var expands = new List<string>
            {
                EField.Renderedfields.Field, EField.Transitions.Field, EField.Changelog.Field
            };
            var issue = RestClient.IssueClient.GetIssueByKey(IssuekeyToSearch, fields, expands);
            issue.Should().NotBeNull();
            issue.Fields.Summary.Should().NotBeNull();
            issue.Fields.Description.Should().NotBeNull();
            issue.RenderedFields.Description.Should().NotBeNull();
        }
    }
}