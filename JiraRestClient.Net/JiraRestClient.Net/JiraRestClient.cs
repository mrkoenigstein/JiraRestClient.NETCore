using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using JiraRestClient.Net.Core;

namespace JiraRestClient.Net
{
    public class JiraRestClient
    {
        public HttpClient Client { get; }

        public Uri BaseUri { get; }

        public string Username { get; }
        
        
        private IssueClient _issueClient;

        private UserClient _userClient;

        private SearchClient _searchClient;

        private SystemClient _systemClient;

        private ProjectClient _projectClient;

        public JiraRestClient(Uri uri, string username, string password)
        {
            Client = new HttpClient();
            BaseUri = uri;
            Username = username;
            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            var token = Convert.ToBase64String(bytes);
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
        }

        public IssueClient IssueClient => _issueClient ?? (_issueClient = new IssueClient(this));


        public UserClient UserClient => _userClient ?? (_userClient = new UserClient(this));

        public SearchClient SearchClient => _searchClient ?? (_searchClient = new SearchClient(this));

        public SystemClient SystemClient => _systemClient ?? (_systemClient = new SystemClient(this));

        public ProjectClient ProjectClient => _projectClient ?? (_projectClient = new ProjectClient(this));


    }

}
