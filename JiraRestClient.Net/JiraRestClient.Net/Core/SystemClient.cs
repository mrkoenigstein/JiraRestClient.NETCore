using System.Collections.Generic;
using System.Text.Json;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core
{
    public class SystemClient : BaseClient
    {
        public SystemClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public List<IssueType> GetIssueTypes()
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.ISSUETPYES);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<IssueType>>(stream.Result);
        }

        public List<Priority> GetPriorities(){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PRIORITY);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Priority>>(stream.Result);
        }

        public List<Status> GetStates(){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.STATUS);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Status>>(stream.Result);
        }
    }
}