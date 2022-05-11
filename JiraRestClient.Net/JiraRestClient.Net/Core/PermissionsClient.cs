using System.Text.Json;
using JiraRestClient.Net.Core.Converter;
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
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.MyPermissions);
            if (string.IsNullOrEmpty(projectKey) == false)
            {
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.ProjectKey, projectKey);
            }

            if (string.IsNullOrEmpty(projectId) == false)
            {
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.ProjectId, projectId);
            }

            if (string.IsNullOrEmpty(issueKey) == false)
            {
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.IssueKey, issueKey);
            }

            if (string.IsNullOrEmpty(issueId) == false)
            {
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.IssueId, issueId);
            }

            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            var streamResult = stream.Result;
            return JsonSerializer.Deserialize<Permissions>(streamResult);
        }
    }
}