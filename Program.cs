using System;
using Micromata.Jira;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;

namespace Micromata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // testUserClient();  
            // testUriHelper();
            testIssueClient();
        }

        public static void testUserClient(){
            var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var userclient = restclient.UserClient;
            var task = userclient.getLoggedInUser();
            var user = task.GetAwaiter().GetResult() as User;
            Console.WriteLine(user.self);  
        }

        public static void testIssueClient(){
                   var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var issueclient = restclient.IssueClient;
            var task = issueclient.getIssueByKey("DEMO-1");
            var issue = task.GetAwaiter().GetResult() as Issue;
            Console.WriteLine(issue.key);
        }

        public static void testUriHelper(){
              var uri = new Uri("http://localhost:2990/jira");
              var userUri = UriHelper.buildPath(uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS, RestParamConstants.ISSUEKEY);
              Console.WriteLine(userUri.ToString());
        }
    }
}
