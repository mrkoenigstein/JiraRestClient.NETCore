using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Micromata.Jira.Core;

namespace Micromata.Jira
{
    public class JiraRestClient
    {
        private string _username;

        private readonly HttpClient _client;

        private readonly Uri _baseUri;

        private IssueClient _issueClient;

        private UserClient _userClient;

        private SearchClient _searchClient;

        private SystemClient _systemClient;

        public JiraRestClient(Uri uri, string username, string password)
        {
            this._client = new HttpClient();
            this._baseUri = uri;
            this._username = username;
            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            var token = Convert.ToBase64String(bytes);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
        }

        public IssueClient IssueClient
        {
            get
            {
                if (_issueClient == null)
                {
                    _issueClient = new IssueClient(this);
                }
                return _issueClient;
            }
        }


        public UserClient UserClient
        {
            get
            {
                if (_userClient == null)
                {
                    _userClient = new UserClient(this);
                }
                return _userClient;
            }
        }

        public SearchClient SearchClient
        {
            get
            {
                if (_searchClient == null)
                {
                    _searchClient = new SearchClient(this);
                }
                return _searchClient;
            }
        }

        public SystemClient SystemClient
        {
            get
            {
                if (_systemClient == null)
                {
                    _systemClient = new SystemClient(this);
                }
                return _systemClient;
            }
        }

        public HttpClient Client
        {
            get
            {
                return _client;
            }
        }

        public Uri BaseUri
        {
            get
            {
                return _baseUri;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }
    }

}
