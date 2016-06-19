using System.Threading.Tasks;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;
using System.Runtime.Serialization.Json;

namespace Micromata.Jira.Core
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

    }
}