using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Cschulc.Jira.Jql;
using Cschulc.Jira.Util;

namespace Cschulc.Jira.Core
{
    public class SearchClient : BaseClient
    {
        public SearchClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<JqlSearchResult> SearchIssues(JqlSearchBean jqlSearchBean)
        {
            var json = JsonHelper.ToJson(jqlSearchBean, typeof(JqlSearchBean));
            var uri = UriHelper.BuildPath(baseUri, RestPathConstants.SEARCH);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri.ToString(), httpContent);
            var serializer = new DataContractJsonSerializer(typeof(JqlSearchResult));
            return serializer.ReadObject(await response.Content.ReadAsStreamAsync()) as JqlSearchResult;
        }
    }

}