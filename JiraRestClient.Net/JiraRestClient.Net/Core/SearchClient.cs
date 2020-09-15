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
            var uri = UriHelper.BuildPath(BaseUri, RestPathConstants.SEARCH);
            uri = UriHelper.AddQuery(uri, "jql",jqlSearchBean.Jql);
            var response = Client.GetAsync(uri.ToString());
            var readAsStringAsync = response.Result.Content.ReadAsStringAsync();
            var result = readAsStringAsync.Result;
            return JsonSerializer.Deserialize<JqlSearchResult>(result);
        }
    }

}