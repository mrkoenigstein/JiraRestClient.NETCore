using System.Collections.Generic;

namespace JiraRestClient.Net.Domain
{
    public class Project :KeyBase
    {
        public string Expand { get; set; }
        public string Description { get; set; }
        public User Lead { get; set; }
        public List<Component> Components { get; set; }
        public List<IssueType> IssueTypes { get; set; }
        public string AssigneeType { get; set; }
        public List<Version> Versions { get; set; }
        public Roles Roles { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
    }

    public class Roles
    {
        public string Users { get; set; }
        public string Administrators { get; set; }
        public string Developers { get; set; }
    }
}
