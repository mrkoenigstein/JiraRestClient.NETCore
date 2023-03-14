using System;

namespace JiraRestClient.Net.Test
{
    public abstract class BaseTest
    {
        protected readonly Uri Uri = new("http://localhost");

        protected const string Username = "";

        protected const string Password = "";

        protected const string ProjectKey = "Demo";

        protected const string IssuekeyToSearch = "DEMO-1";

        protected readonly JiraRestClient RestClient;

        public BaseTest(){
            RestClient =  new JiraRestClient(Uri, Username, Password);
        }
    }
}