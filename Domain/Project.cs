using System.Collections.Generic;

namespace Micromata.Jira.Domain
{
    public class Project :Key
    {
        public string expand { get; set; }
        public string description { get; set; }
        public User lead { get; set; }
        public List<Component> components { get; set; }
        public List<IssueType> issueTypes { get; set; }
        public string assigneeType { get; set; }
        public List<Version> versions { get; set; }
        public Roles roles { get; set; }
        public AvatarUrls avatarUrls { get; set; }
    }

    public class Roles
    {
        public string Users { get; set; }
        public string Administrators { get; set; }
        public string Developers { get; set; }
    }
}
