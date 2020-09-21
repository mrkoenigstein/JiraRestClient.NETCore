using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain.Issue
{
    public class IssueResponse : KeyBase
    {
        [JsonPropertyName("errorMessages")]
        public List<string> ErrorMessages { get; set; }
        
        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }
    }
}