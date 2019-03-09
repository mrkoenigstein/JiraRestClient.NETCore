using Cschulc.Jira.Util;

namespace Cschulc.Jira.Jql
{
    public class ERoles
    {
        public static readonly ERoles ADMINISTRATORS = new ERoles(JsonConstants.ROLE_ADMINISTRATORS);
        public static readonly ERoles USERS = new ERoles(JsonConstants.ROLE_USERS);
        public static readonly ERoles DEVELOPERS = new ERoles(JsonConstants.ROLE_DEVELOPERS);

        private string name { get; set; }

        public ERoles(string _name)
        {
            name = _name;
        }
    }
}
