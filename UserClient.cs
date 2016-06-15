using System.Runtime.Serialization.Json;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;

namespace Micromata.Jira
{
    public class UserClient : BaseClient
    {
        public UserClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public User getLoggedInUser()
        {        
            var restUriBuilder = RestUriBuilder2.buildURI(baseUri, RestPathConstants.USER);
            restUriBuilder.Query = "username=" + username;
            var completeURI = restUriBuilder.ToString();
            var stream = client.GetStreamAsync(completeURI).GetAwaiter().GetResult();
            var serializer = new DataContractJsonSerializer(typeof(User));
            return serializer.ReadObject(stream) as User;
        }
    }
}