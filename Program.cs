using System;
using Micromata.Jira;

namespace Micromata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = new Uri("http://localhost:2990/jira");
            var username = "admin";
            var password = "admin";
            var restclient = new JiraRestClient(uri, username, password);
            var userclient = restclient.UserClient;
            var user = userclient.getLoggedInUser();
            Console.WriteLine(user.self);            
        }
    }
}
