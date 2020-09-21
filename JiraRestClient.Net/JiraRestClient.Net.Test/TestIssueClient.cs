using System;
using System.Collections.Generic;
using FluentAssertions;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Domain.Issue;
using JiraRestClient.Net.Jql;
using JiraRestClient.Net.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Version = JiraRestClient.Net.Domain.Version;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestIssueClient : BaseTest
    {
        [TestMethod]
        public void TestGetIssueByKey()
        {
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

        [TestMethod]
        public void TestCreateIssue()
        {
            var issueUpdate = new IssueUpdate
            {
                Fields = new IssueFields
                {
                    Description = "This is an new Issue",
                    Summary = "Created via RestAPI",
                    Project = new Project
                    {
                        Id = "10000"
                    },
                    Issuetype = new IssueType
                    {
                        Id = "10001"
                    },
                    Priority = new Priority
                    {
                        Id = "3"
                    }
                }
            };
            var issueResponse = RestClient.IssueClient.CreateIssue(issueUpdate);
            issueResponse.Should().NotBeNull();
            issueResponse.Key.Should().NotBeNullOrEmpty();
        }
    }
}