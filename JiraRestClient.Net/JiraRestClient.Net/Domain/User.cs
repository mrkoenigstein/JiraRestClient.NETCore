using System.Collections.Generic;
using System.Text.Json.Serialization;
using JiraRestClient.Net.Domain.Issue;

namespace JiraRestClient.Net.Domain
{
    public class User : KeyBase
    {
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
        
        [JsonPropertyName("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }
        
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
        
        [JsonPropertyName("groups")]
        public Groups Groups { get; set; }
        
        [JsonPropertyName("expand")]
        public string Expand { get; set; }
    }

    public class Groups
    {
        [JsonPropertyName("size")]
        public int Size { get; set; }
        
        [JsonPropertyName("items")]
        public IList<Group> Items { get; set; }
    }

    public class Group :Base
    {

    }
}
