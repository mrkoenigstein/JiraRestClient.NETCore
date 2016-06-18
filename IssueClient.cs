using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System;
using System.Threading.Tasks;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;
using System.Runtime.Serialization.Json;

namespace Micromata.Jira
{
    public class IssueClient : BaseClient
    {
        public IssueClient(JiraRestClient jiraRestClient) :base(jiraRestClient)
        {
        }

        public async Task<Issue> getIssueByKey(string key)
        {
            var restUriBuilder = UriHelper.buildPath(baseUri, RestPathConstants.ISSUE, key);
            Console.WriteLine(restUriBuilder);
            var completeUri = restUriBuilder.ToString();
            var stream = client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(Issue));
            return serializer.ReadObject(await stream) as Issue;           
        }

    }
}