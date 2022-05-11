using System;

namespace JiraRestClient.Net.Test
{
    public abstract class BaseTest
    {
        protected readonly Uri Uri = new Uri("http://localhost:8080");

        protected const string Username = "admin";

        protected const string Password = "admin";

        protected const string ProjectKey = "DEMO";

        protected const string IssuekeyToSearch = "DEMO-25";

        protected readonly JiraRestClient RestClient;

        public BaseTest(){
            RestClient =  new JiraRestClient(Uri, Username, Password);
        }
    }
}