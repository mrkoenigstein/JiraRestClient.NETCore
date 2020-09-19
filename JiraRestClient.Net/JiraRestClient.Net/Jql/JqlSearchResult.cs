using System.Collections.Generic;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Domain.Issue;

namespace JiraRestClient.Net.Jql
{
    public class JqlSearchResult
    {
        public string Expand { get; set; }

        public int StartAt { get; set; }

        public int MaxResults { get; set; }

        public int Total { get; set; }

        public List<Issue> Issues { get; set; }

    }
}
