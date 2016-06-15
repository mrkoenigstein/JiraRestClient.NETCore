using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Micromata.Jira.Util;

namespace Micromata.Jira
{
    public class JiraRestClient
    {
        private string _username;

        private readonly HttpClient _client;

        private readonly Uri _baseUri;

        private IssueClient _issueClient;

        private UserClient _userClient;

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
