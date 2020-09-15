using System.Collections.Generic;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Jql
{
    public class JqlSearchResult
    {
        [JsonPropertyName("expand")]
        public string Expand { get; set; }

        [JsonPropertyName("startAt")]
        public int StartAt { get; set; }

        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("issues")]
        public List<Issue> Issues { get; set; }

    }
}
