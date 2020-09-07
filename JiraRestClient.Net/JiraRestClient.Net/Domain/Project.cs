using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Project : KeyBase
    {
        [JsonPropertyName("expand")]
        public string Expand { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("lead")]
        public User Lead { get; set; }
        [JsonPropertyName("components")]
        public List<Component> Components { get; set; }
        [JsonPropertyName("issuetypes")]
        public List<IssueType> IssueTypes { get; set; }
        [JsonPropertyName("assigneetype")]
        public string AssigneeType { get; set; }
        [JsonPropertyName("versions")]
        public List<Version> Versions { get; set; }
        [JsonPropertyName("roles")]
        public Roles Roles { get; set; }
        [JsonPropertyName("avatarurls")]
        public AvatarUrls AvatarUrls { get; set; }
    }

    public class Roles
    {
        [JsonPropertyName("users")]
        public string Users { get; set; }
        [JsonPropertyName("administrators")]
        public string Administrators { get; set; }
        [JsonPropertyName("developers")]
        public string Developers { get; set; }
    }
}
