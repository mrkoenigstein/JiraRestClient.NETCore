using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Base
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("self")]
        public string Self { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class KeyBase : Base
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
