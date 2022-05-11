using System.Net.Http;
using System.Text;
using System.Text.Json;
using JiraRestClient.Net.Jql;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Core
{
    public class SearchClient : BaseClient
    {
        public SearchClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public JqlSearchResult SearchIssues(JqlSearchBean jqlSearchBean)
        {
            var json = JsonSerializer.Serialize(jqlSearchBean);
            var uri = UriHelper.BuildPath(BaseUri, RestPathConstants.Search);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = Client.PostAsync(uri.ToString(), httpContent);
            var readAsStringAsync = response.Result.Content.ReadAsStringAsync();
            var result = readAsStringAsync.Result;
            return JsonSerializer.Deserialize<JqlSearchResult>(result);
        }
    }

}