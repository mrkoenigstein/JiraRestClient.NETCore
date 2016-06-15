using System;
using System.Net.Http;

namespace Micromata.Jira
{
    public abstract class BaseClient
    {
        protected JiraRestClient jiraRestClient;

        protected Uri baseUri;

        protected HttpClient client;

        protected string username;

        public BaseClient(JiraRestClient jiraRestClient)
        {
            this.jiraRestClient = jiraRestClient;
            this.client = jiraRestClient.Client;
            this.baseUri = jiraRestClient.BaseUri;
            this.username = jiraRestClient.Username;
        }
    }
}