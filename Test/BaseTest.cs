using System;

namespace Micromata.Jira.Test
{
    public abstract class BaseTest
    {
        protected Uri uri = new Uri("http://localhost:2990/jira");

        protected const string username = "admin";

        protected const string password = "admin";

        protected const string project_key = "DEMO";

        protected const string issuekey_to_search = "DEMO-1";

        protected JiraRestClient restClient;

        public BaseTest(){
            restClient =  new JiraRestClient(uri, username, password);
        }
    }
}