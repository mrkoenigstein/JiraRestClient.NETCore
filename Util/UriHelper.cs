using System;
using System.Net;

namespace Micromata.Jira.Util
{
    public static class UriHelper
    {
        public static Uri AddQuery(Uri baseUri, string name, string value)
        {
            var ub = new UriBuilder(baseUri);
            string query = ub.Query;
            return ub.Uri;
        }

        public static UriBuilder AddQuery(UriBuilder uribuilder, string name, string value)
        {
            var query = uribuilder.Query;
            var queryParam = name + "=" + WebUtility.UrlEncode(value);
            if(String.IsNullOrEmpty(query) == true)
            {
                uribuilder.Query = queryParam;
            }
            else
            {
                uribuilder.Query = query + "&" + queryParam;
            }
            return uribuilder;
        }


        public static Uri AddIssueKey(Uri baseUri, string issueKey)
        {
            string temp = baseUri.AbsoluteUri + "/";
            Uri retval = new Uri(temp);
            return new Uri(retval, issueKey);
        }

        public static UriBuilder BuildPath(Uri baseUri, params string[] paths)
        {
            if (baseUri.AbsolutePath.EndsWith("/") == false)
            {
                baseUri = new Uri(baseUri.AbsoluteUri + "/");
            }
            UriBuilder uribuilder = new UriBuilder(baseUri + RestPathConstants.BASE_REST_PATH);
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
