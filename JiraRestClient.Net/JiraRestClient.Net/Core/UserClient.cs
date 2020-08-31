using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core
{
    public class UserClient : BaseClient
    {
        public UserClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<User> GetLoggedInUser()
        {        
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.USER);
            restUriBuilder.Query = "username=" + Username;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(User));
            return serializer.ReadObject(await stream) as User;
        }

        public async Task<User> GetUserByUsername(string username){
             var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.USER);
            restUriBuilder.Query = "username=" + username;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(User));
            return serializer.ReadObject(await stream) as User;
        }
    }
}