using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Version :Base
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
        [JsonPropertyName("released")]
        public bool Released { get; set; }
        [JsonPropertyName("overdue")]
        public bool Overdue { get; set; }
        [JsonPropertyName("releasedate")]
        public string ReleaseDate { get; set; }
        [JsonPropertyName("userreleasedate")]
        public string UserReleaseDate { get; set; }
    }
}
