using System.Threading.Tasks;
using Cschulc.Jira.Domain;
using Cschulc.Jira.Util;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Cschulc.Jira.Core
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
        public async Task<Issue> GetIssueByKey(string key)
        {
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.ISSUE, key);
            var completeUri = restUriBuilder.ToString();
            var stream = client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(Issue));
            return serializer.ReadObject(await stream) as Issue;
        }


        public async Task<Issue> GetIssueByKey(string key, List<string> fields, List<string> expand)
        {
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.ISSUE, key);
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
            var stream = client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(Issue));
            return serializer.ReadObject(await stream) as Issue;
        }
    }
}