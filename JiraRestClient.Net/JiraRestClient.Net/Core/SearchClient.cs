using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Jql;

namespace JiraRestClient.Net.Core
{
    public class SearchClient : BaseClient
    {
        public SearchClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public async Task<JqlSearchResult> SearchIssues(JqlSearchBean jqlSearchBean)
        {
            var json = JsonHelper.ToJson(jqlSearchBean, typeof(JqlSearchBean));
            var uri = UriHelper.BuildPath(BaseUri, RestPathConstants.SEARCH);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(uri.ToString(), httpContent);
            var serializer = new DataContractJsonSerializer(typeof(JqlSearchResult));
            return serializer.ReadObject(await response.Content.ReadAsStreamAsync()) as JqlSearchResult;
        }
    }

}