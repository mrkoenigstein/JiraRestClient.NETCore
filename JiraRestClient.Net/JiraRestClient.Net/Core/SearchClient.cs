using System.Net.Http;
using System.Text;
using System.Text.Json;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Jql;

namespace JiraRestClient.Net.Core
{
    public class SearchClient : BaseClient
    {
        public SearchClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public JqlSearchResult SearchIssues(JqlSearchBean jqlSearchBean)
        {
            var json = JsonHelper.ToJson(jqlSearchBean, typeof(JqlSearchBean));
            var uri = UriHelper.BuildPath(BaseUri, RestPathConstants.SEARCH);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(uri.ToString(), httpContent);
            var readAsStringAsync = response.Result.Content.ReadAsStringAsync();
            var result = readAsStringAsync.Result;
            return JsonSerializer.Deserialize<JqlSearchResult>(result);
        }
    }

}