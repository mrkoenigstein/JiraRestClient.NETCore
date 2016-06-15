using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System;

namespace Micromata.Jira
{
    public class IssueClient : BaseClient
    {
        public IssueClient(JiraRestClient jiraRestClient) :base(jiraRestClient)
        {
        }

        public void getIssueByKey(string key)
        {
            var token = Convert.ToBase64String(Encoding.ASCII.GetBytes("admin:admin"));
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
                var url = new Uri("http://localhost:2990/jira/rest/api/2/issue/DEMO-1");
                var response = client.GetAsync(url).GetAwaiter().GetResult();
                var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Console.WriteLine(json);
            }
            
        }

    }
}