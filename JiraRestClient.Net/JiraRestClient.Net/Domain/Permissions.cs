using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class Permissions : Base
    {
        [JsonPropertyName("permissions")]
       public PermissionsList PermissionsList { get; set; }
    }

    public class PermissionsList
    {
        [JsonPropertyName("CREATE_ISSUES")]
        public Permission CreateIssue { get; set; }

        [JsonPropertyName("EDIT_ISSUE")]
        public Permission EditIssue { get; set; }
    }
}