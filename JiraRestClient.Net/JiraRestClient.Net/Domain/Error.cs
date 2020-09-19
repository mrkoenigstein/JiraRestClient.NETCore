using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Errors
    {
        [JsonPropertyName("project")]
        public string Project {get;set;}
        [JsonPropertyName("subtasks")]
        public string Subtasks {get;set;}
        [JsonPropertyName("attachment")]
        public string Attachment {get;set;}
        [JsonPropertyName("issuelinks")]
        public string IssueLinks {get;set;}
        [JsonPropertyName("issuetype")]
        public string IssueType {get;set;}
        [JsonPropertyName("reporter")]
        public string Reporter {get;set;}
        [JsonPropertyName("assignee")]
        public string Assignee {get;set;}
        [JsonPropertyName("environment")]
        public string Environment {get;set;}
        [JsonPropertyName("filterName")]
        public string FilterName {get;set;}
        [JsonPropertyName("versions")]
        public string Versions {get;set;}
        [JsonPropertyName("components")]
        public string Components {get;set;}
        [JsonPropertyName("email")]
        public string Email {get;set;}
        [JsonPropertyName("projectType")]
        public string ProjectType {get;set;}
        [JsonPropertyName("projectKey")]
        public string ProjectKey {get;set;}
        [JsonPropertyName("projectName")]
        public string ProjectName {get;set;}
    }
}