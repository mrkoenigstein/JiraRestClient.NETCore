using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Component :Base
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
