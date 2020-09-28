using System;
using System.Net;
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

        public string Username { get; private set; }

        private string Base64Token { get; set; }
        
        private IssueClient _issueClient;

        private UserClient _userClient;

        private SearchClient _searchClient;

        private SystemClient _systemClient;

        private ProjectClient _projectClient;

        private PermissionsClient _permissionsClient;


        public JiraRestClient(Uri uri, string username, string password)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            Client = new HttpClient();
            BaseUri = uri;
            Username = username;
            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            Base64Token = Convert.ToBase64String(bytes);
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Token);
        }

        public JiraRestClient(Uri uri, string token)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            Client = new HttpClient();
            BaseUri = uri;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
        }

        public JiraRestClient(Uri uri)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            Client = new HttpClient();
            BaseUri = uri;
        }

        public string Login(string username, string password)
        {
            Username = username;
            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            Base64Token = Convert.ToBase64String(bytes);
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Token);
            return Base64Token;
        }

        public void Login(string base64Token)
        {
            Base64Token = base64Token;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Token);
        }

        public IssueClient IssueClient => _issueClient ??= new IssueClient(this);
        
        public UserClient UserClient => _userClient ??= new UserClient(this);

        public SearchClient SearchClient => _searchClient ??= new SearchClient(this);

        public SystemClient SystemClient => _systemClient ??= new SystemClient(this);

        public ProjectClient ProjectClient => _projectClient ??= new ProjectClient(this);

        public PermissionsClient PermissionsClient =>
            _permissionsClient ??= new PermissionsClient(this);


    }

}
