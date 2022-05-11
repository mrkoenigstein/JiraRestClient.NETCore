using System;
using System.Net;

namespace JiraRestClient.Net.Util
{
    public static class UriHelper
    {
        public static UriBuilder AddQuery(UriBuilder uriBuilder, string name, string value)
        {
            var query = uriBuilder.Query;
            var queryParam = name + "=" + WebUtility.UrlEncode(value);
            if(string.IsNullOrEmpty(query))
            {
                uriBuilder.Query = queryParam;
            }
            else
            {
                uriBuilder.Query = query + "&" + queryParam;
            }
            return uriBuilder;
        }


        public static Uri AddIssueKey(Uri baseUri, string issueKey)
        {
            var temp = baseUri.AbsoluteUri + "/";
            var retVal = new Uri(temp);
            return new Uri(retVal, issueKey);
        }

        public static UriBuilder BuildPath(Uri baseUri, params string[] paths)
        {
            if (baseUri.AbsolutePath.EndsWith("/") == false)
            {
                baseUri = new Uri(baseUri.AbsoluteUri + "/");
            }
            UriBuilder uribuilder = new UriBuilder(baseUri + RestPathConstants.BaseRestPath);
            var path = uribuilder.Path;
            foreach (var item in paths)
            {
                if(item.StartsWith("/") == false){
                    path+= "/" + item;
                }else{
                    path+=item;
                }
            }
            uribuilder.Path = path;
            return uribuilder;
        }
    }
}
