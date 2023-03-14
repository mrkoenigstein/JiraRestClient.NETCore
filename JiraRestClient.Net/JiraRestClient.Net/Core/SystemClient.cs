using System.Collections.Generic;
using System.Text.Json;
using JiraRestClient.Net.Core.Extension;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Domain.Issue;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Core
{
    public class SystemClient : BaseClient
    {
        public SystemClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public IEnumerable<IssueType> GetIssueTypes()
        {
            var restUriBuilder = BaseUri.AddPaths(RestPathConstants.IssueTypes);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<IssueType>>(stream.Result);
        }

        public IEnumerable<Priority> GetPriorities(){
            var restUriBuilder = BaseUri.AddPaths(RestPathConstants.Priority);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Priority>>(stream.Result);
        }

        public List<Status> GetStates(){
            var restUriBuilder = BaseUri.AddPaths(RestPathConstants.Status);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Status>>(stream.Result);
        }
    }
}