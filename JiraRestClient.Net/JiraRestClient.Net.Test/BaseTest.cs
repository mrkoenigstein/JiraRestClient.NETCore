using System;

namespace JiraRestClient.Net.Test
{
    public abstract class BaseTest
    {
        protected readonly Uri Uri = new Uri("http://localhost:2990/jira");

        protected const string Username = "admin";

        protected const string Password = "admin";

        protected const string ProjectKey = "DEMO";

        protected const string IssuekeyToSearch = "DEMO-1";

        protected readonly JiraRestClient RestClient;

        public BaseTest(){
            RestClient =  new JiraRestClient(Uri, Username, Password);
        }
    }
}