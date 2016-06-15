using System;

namespace Micromata.Jira.Util
{
    public class RestUriBuilder2
    {
        public static UriBuilder buildURI(Uri baseUri, params string[] paths){
            UriBuilder uribuilder = new UriBuilder(baseUri + RestPathConstants.BASE_REST_PATH + paths[0]);
            
            return uribuilder;
        }
    }
}