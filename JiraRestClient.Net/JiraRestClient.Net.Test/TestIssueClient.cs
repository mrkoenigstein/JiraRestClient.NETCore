using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Domain.Issue;
using JiraRestClient.Net.Jql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


        [TestMethod]
        public void TestAddAttachment()
        {
            var png = File.OpenRead("./Resources/frogs.png");
            var pdf = File.OpenRead("./Resources/test.pdf");
            
            var streams = new List<FileStream>
            {
                png, pdf
            };
            var attachments = RestClient.IssueClient.AddAttachment("DEMO-3", streams);
            attachments.Should().NotBeEmpty().And.HaveCount(2);
        }
    }
}