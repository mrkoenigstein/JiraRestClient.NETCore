using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Micromata.Jira.Jql;
using Micromata.Jira.Util;

namespace Micromata.Jira.Core
{
    public class SearchClient : BaseClient
    {
        public SearchClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {


        }

        public async Task<JqlSearchResult> searchIssues(JqlSearchBean jqlSearchBean)
        {
            var json = JsonHelper.toJson(jqlSearchBean, typeof(JqlSearchBean));
            var uri = UriHelper.buildPath(baseUri, RestPathConstants.SEARCH);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri.ToString(), httpContent);
            var serializer = new DataContractJsonSerializer(typeof(JqlSearchResult));
            return serializer.ReadObject(await response.Content.ReadAsStreamAsync()) as JqlSearchResult;
        }
    }

}