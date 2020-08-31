using Cschulc.Jira.Util;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Jql
{
    public class ERoles
    {
        public static readonly ERoles Administrators = new ERoles(JsonConstants.RoleAdministrators);
        public static readonly ERoles Users = new ERoles(JsonConstants.RoleUsers);
        public static readonly ERoles Developers = new ERoles(JsonConstants.RoleDevelopers);

        private string Name { get; set; }

        public ERoles(string name)
        {
            Name = name;
        }
    }
}
