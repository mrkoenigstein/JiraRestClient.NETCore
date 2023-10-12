using System;
using System.Linq;

namespace JiraRestClient.Net.Core.Extension;

public static class UriExtension
{
    public static Uri AddPaths(this Uri uri, params string[] paths)
    {
        return new Uri(paths.Aggregate(uri.AbsoluteUri, (current, path) =>
            $"{current.TrimEnd('/')}/{path.TrimStart('/')}"));
    }

    public static Uri AddQuery(this Uri uri, params string[] query)
    {
        var uriBuilder = new UriBuilder(uri) { Query = string.Join("&", query) };
        return uriBuilder.Uri;
    }

    public static Uri AddQuery(this Uri uri, string query)
    {
        var uriBuilder = new UriBuilder(uri) { Query = query };
        return uriBuilder.Uri;
    }
    
    public static Uri AddIssueKey(this Uri uri, string issueKey)
    {
        var temp = uri.AbsoluteUri + "/";
        var retVal = new Uri(temp);
        return new Uri(retVal, issueKey);
    }
}