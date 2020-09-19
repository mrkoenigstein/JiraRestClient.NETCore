using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Core
{
    public class UserClient : BaseClient
    {
        public UserClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public User GetLoggedInUser()
        {        
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.User);
            restUriBuilder.Query = "username=" + Username;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStringAsync(completeUri);
            var streamResult = stream.Result;
            return  JsonSerializer.Deserialize<User>(streamResult);
        }

        public User GetUserByUsername(string username){
             var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.User);
            restUriBuilder.Query = "username=" + username;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStringAsync(completeUri);
            return  JsonSerializer.Deserialize<User>(stream.Result);
        }
    }
}