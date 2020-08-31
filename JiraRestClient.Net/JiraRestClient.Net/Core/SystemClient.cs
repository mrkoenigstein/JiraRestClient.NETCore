using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core
{
    public class SystemClient : BaseClient
    {
        public SystemClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<List<IssueType>> GetIssueTypes()
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.ISSUETPYES);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<IssueType>));
            return serializer.ReadObject(await stream) as List<IssueType>;
        }

        public async Task<List<Priority>> GetPriorities(){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PRIORITY);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Priority>));
            return serializer.ReadObject(await stream) as List<Priority>;
        }

        public async Task<List<Status>> GetStates(){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.STATUS);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Status>));
            return serializer.ReadObject(await stream) as List<Status>;
        }

    }
}