using System.Text.Json;
using JiraRestClient.Net.Core.Extension;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Core
{
    public class PermissionsClient : BaseClient
    {
        public PermissionsClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public Permissions GetMyPermissions(string projectKey = null,
            string projectId = null,
            string issueKey = null,
            string issueId = null)
        {
            var uri = BaseUri.AddPaths(RestPathConstants.MyPermissions);
            if (string.IsNullOrEmpty(projectKey) == false)
            {
                uri = uri.AddQuery($"{RestParamConstants.ProjectKey}={projectKey}");
            }

            if (string.IsNullOrEmpty(projectId) == false)
            {
                uri = uri.AddQuery($"{RestParamConstants.ProjectId}={projectId}");
            }

            if (string.IsNullOrEmpty(issueKey) == false)
            {
                uri = uri.AddQuery($"{RestParamConstants.IssueKey}={issueKey}");
            }

            if (string.IsNullOrEmpty(issueId) == false)
            {
                uri = uri.AddQuery($"{RestParamConstants.IssueId}={issueId}");
            }

            var stream = Client.GetStringAsync(uri.ToString());
            var streamResult = stream.Result;
            return JsonSerializer.Deserialize<Permissions>(streamResult);
        }
    }
}