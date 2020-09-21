using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class IssueType : Base
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("iconurl")]
        public string IconUrl { get; set; }
        [JsonPropertyName("subtask")]
        public bool Subtask { get; set; }
    }
}
