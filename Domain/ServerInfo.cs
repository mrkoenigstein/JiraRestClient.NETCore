using System.Collections.Generic;

namespace Micromata.Jira.Domain
{
    public class ServerInfo
    {
        public string baseUrl { get; set; }
        public string version { get; set; }
        public IList<int> versionNumbers { get; set; }
        public int buildNumber { get; set; }
        public string buildDate { get; set; }
        public string serverTime { get; set; }
        public string scmInfo { get; set; }
        public string serverTitle { get; set; }
    }
}
