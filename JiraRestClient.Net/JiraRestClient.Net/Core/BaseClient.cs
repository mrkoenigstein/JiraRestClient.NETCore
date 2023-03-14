using System;
using System.Net.Http;

namespace JiraRestClient.Net.Core
{
    /// <summary>
    /// Base Class for all Clients, contains common Informations.
    /// </summary>
    public abstract class BaseClient
    {
        protected readonly Uri BaseUri;

        protected readonly HttpClient Client;

        protected readonly string Username;
        
        protected BaseClient(JiraRestClient jiraRestClient)
        {
            Client = jiraRestClient.Client;
            BaseUri = jiraRestClient.BaseUri;
            Username = jiraRestClient.Username;
        }
    }
}