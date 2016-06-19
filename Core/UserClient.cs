using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;

namespace Micromata.Jira.Core
{
    public class UserClient : BaseClient
    {
        public UserClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<User> GetLoggedInUser()
        {        
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.USER);
            restUriBuilder.Query = "username=" + username;
            var completeURI = restUriBuilder.ToString();
            var stream = client.GetStreamAsync(completeURI);
            var serializer = new DataContractJsonSerializer(typeof(User));
            return serializer.ReadObject(await stream) as User;
        }
    }
}