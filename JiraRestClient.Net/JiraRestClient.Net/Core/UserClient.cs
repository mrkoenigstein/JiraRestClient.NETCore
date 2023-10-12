using System.Collections.Generic;
using System.Text.Json;
using JiraRestClient.Net.Core.Extension;
using JiraRestClient.Net.Domain;
using JiraRestClient.Net.Util;

namespace JiraRestClient.Net.Core;

public class UserClient : BaseClient
{
    public UserClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
    {
    }
        
    public User GetUserByUsername(string accountId)
    {
        var uri = BaseUri.AddPaths(RestPathConstants.User);
        uri = uri.AddQuery($"accountId={accountId}");
        var stream = Client.GetStringAsync(uri);
        var result = stream.Result;
        return JsonSerializer.Deserialize<User>(result);
    }

    public IEnumerable<UserMigration> GetAccountIds(List<string> username)
    {
        var uri = BaseUri.AddPaths(RestPathConstants.User, RestPathConstants.Bulk, RestPathConstants.Migration);
        uri = uri.AddQuery($"username={username}");
        var stream = Client.GetStringAsync(uri);
        var streamResult = stream.Result;
        return JsonSerializer.Deserialize<List<UserMigration>>(streamResult);
    }
}