using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Permission : KeyBase
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
            
        [JsonPropertyName("description")]
        public string Description{ get; set; }
        
        [JsonPropertyName("havePermission")]
        public bool HavePermission { get; set; }
            
        [JsonPropertyName("deprecatedKey")]
        public bool DeprecatedKey { get; set; }
    }
}