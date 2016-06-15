using System;

namespace Micromata.Jira.Util
{
    public static class UriHelper
    {
        public static Uri AddQuery(this Uri uri, string name, string value)
        {
            var ub = new UriBuilder(uri);
            string query = ub.Query;
            return ub.Uri;
        }


        public static Uri AddIssueKey(this Uri uri, string issueKey)
        {
            string temp = uri.AbsoluteUri + "/";
            Uri retval = new Uri(temp);
            return new Uri(retval, issueKey);
        }
    }
}
