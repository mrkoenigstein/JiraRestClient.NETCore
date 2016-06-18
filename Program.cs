using System;
using Micromata.Jira;
using Micromata.Jira.Domain;
using Micromata.Jira.Jql;
using Micromata.Jira.Util;

namespace Micromata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // testUserClient();  
            // testUriHelper();
            // testIssueClient();
            testSearchclient();

        }

        public static void testUserClient()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var userclient = restclient.UserClient;
            var task = userclient.getLoggedInUser();
            var user = task.GetAwaiter().GetResult() as User;
            Console.WriteLine(user.self);
        }

        public static void testIssueClient()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var issueclient = restclient.IssueClient;
            var task = issueclient.getIssueByKey("DEMO-1");
            var issue = task.GetAwaiter().GetResult() as Issue;
            Console.WriteLine(issue.key);
        }

        public static void testUriHelper()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var userUri = UriHelper.buildPath(uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS, RestParamConstants.ISSUEKEY);
            Console.WriteLine(userUri.ToString());
        }

        public static void testSearchclient()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var jsb = new JqlSearchBean();
            JqlBuilder builder = new JqlBuilder();
            String jql = builder.addCondition(EField.PROJECT, EOperator.EQUALS, "DEMO")
                    .and().addCondition(EField.STATUS, EOperator.EQUALS, JqlConstants.STATUS_OPEN)
                    .orderBy(SortOrder.ASC, EField.CREATED);
            jsb.jql = jql;
            jsb.AddField(EField.ISSUE_KEY, EField.STATUS, EField.DUE, EField.SUMMARY, EField.ISSUE_TYPE, EField.PRIORITY, EField.UPDATED, EField.TRANSITIONS);
            jsb.AddExpand(EField.TRANSITIONS);
            var task = restclient.SearchClient.searchIssues(jsb);
            var result = task.GetAwaiter().GetResult() as JqlSearchResult;
            Console.WriteLine(result.total);
        }
    }
}
