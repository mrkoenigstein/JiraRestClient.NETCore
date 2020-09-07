using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain
{
    public class ServerInfo
    {
        [JsonPropertyName("baseurl")]
        public string BaseUrl { get; set; }
        [JsonPropertyName("version")]
        public string Version { get; set; }
        [JsonPropertyName("versionnumbers")]
        public IList<int> VersionNumbers { get; set; }
        [JsonPropertyName("buildnumber")]
        public int BuildNumber { get; set; }
        [JsonPropertyName("builddate")]
        public string BuildDate { get; set; }
        [JsonPropertyName("servertime")]
        public string ServerTime { get; set; }
        [JsonPropertyName("scminfo")]
        public string ScmInfo { get; set; }
        [JsonPropertyName("servertitle")]
        public string ServerTitle { get; set; }
    }
}
