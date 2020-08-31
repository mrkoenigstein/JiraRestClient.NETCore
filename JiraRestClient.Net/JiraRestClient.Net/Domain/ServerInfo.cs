using System.Collections.Generic;

namespace JiraRestClient.Net.Domain
{
    public class ServerInfo
    {
        public string BaseUrl { get; set; }
        public string Version { get; set; }
        public IList<int> VersionNumbers { get; set; }
        public int BuildNumber { get; set; }
        public string BuildDate { get; set; }
        public string ServerTime { get; set; }
        public string ScmInfo { get; set; }
        public string ServerTitle { get; set; }
    }
}
