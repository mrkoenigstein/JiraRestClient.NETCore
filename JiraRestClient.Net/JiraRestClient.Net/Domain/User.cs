using System.Collections.Generic;

namespace JiraRestClient.Net.Domain
{
    public class User : KeyBase
    {
        public string EmailAddress { get; set; }
        //public AvatarUrls avatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
        public Groups Groups { get; set; }
        public string Expand { get; set; }
    }

    public class Groups
    {
        public int Size { get; set; }
        public IList<Group> Items { get; set; }
    }

    public class Group :Base
    {

    }
}
