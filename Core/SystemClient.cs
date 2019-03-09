using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Cschulc.Jira.Domain;
using Cschulc.Jira.Util;

namespace Cschulc.Jira.Core
{
    public class SystemClient : BaseClient
    {
        public SystemClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<List<IssueType>> GetIssueTypes()
        {
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.ISSUETPYES);
            var stream = client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<IssueType>));
            return serializer.ReadObject(await stream) as List<IssueType>;
        }

        public async Task<List<Priority>> GetPriorities(){
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.PRIORITY);
            var stream = client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Priority>));
            return serializer.ReadObject(await stream) as List<Priority>;
        }

        public async Task<List<Status>> GetStates(){
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.STATUS);
            var stream = client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Status>));
            return serializer.ReadObject(await stream) as List<Status>;
        }

    }
}