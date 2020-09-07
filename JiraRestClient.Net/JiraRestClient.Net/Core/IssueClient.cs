using System.Collections.Generic;
using System.Text.Json;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core
{
    /// <summary>
    /// Client to get Issues
    /// </summary>
    public class IssueClient : BaseClient
    {
        public IssueClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        /// <summary>
        /// Get a Issue by key
        /// </summary>
        /// <param name="key">The key of the Issue</param>
        /// <returns>A async Task containing the Issue</returns>
        public Issue GetIssueByKey(string key)
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.ISSUE, key);
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStringAsync(completeUri);
            var streamResult = stream.Result;
            return JsonSerializer.Deserialize<Issue>(streamResult);
        }


        public Issue GetIssueByKey(string key, List<string> fields, List<string> expand)
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.ISSUE, key);
            if(fields != null && fields.Count > 0)
            {
                var fieldsParam = string.Join(",", fields);
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.FIELDS, fieldsParam);
            }
            if(expand != null && expand.Count > 0)
            {
                var expandParam = string.Join(",", expand);
                UriHelper.AddQuery(restUriBuilder, RestParamConstants.EXPAND, expandParam);
            }
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStringAsync(completeUri);
            var streamResult = stream.Result;
            return JsonSerializer.Deserialize<Issue>(streamResult);
        }
    }
}