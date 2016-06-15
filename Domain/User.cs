using System.Collections.Generic;

namespace Micromata.Jira.Domain
{
    public class User : Key
    {
        public string emailAddress { get; set; }
        //public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public Groups groups { get; set; }
        public string expand { get; set; }
    }

    public class Groups
    {
        public int size { get; set; }
        public IList<Group> items { get; set; }
    }

    public class Group :Base
    {

    }
}
