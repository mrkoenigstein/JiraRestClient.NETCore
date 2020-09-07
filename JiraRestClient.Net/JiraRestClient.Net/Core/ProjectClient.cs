using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Cschulc.Jira.Util;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core
{
    /// <summary>
    /// Client to get Issues
    /// </summary>
    public class ProjectClient : BaseClient
    {
        public ProjectClient(JiraRestClient jiraRestClient) : base(jiraRestClient)
        {
        }

        public Project GetProjectByKey(string key)
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT);
            restUriBuilder.Query = RestParamConstants.PROJECT + "=" + key;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStringAsync(completeUri);
            return JsonSerializer.Deserialize<Project>(stream.Result);
        }

        public List<Project> GetAllProjects()
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Project>>(stream.Result);
        }

        public List<Version> GetProjectVersions(string key){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT, key, RestPathConstants.VERSIONS);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Version>>(stream.Result);
        }

        public List<Component> GetProjectComponents(string key){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT, key, RestPathConstants.COMPONENTS);
            var stream = Client.GetStringAsync(restUriBuilder.ToString());
            return JsonSerializer.Deserialize<List<Component>>(stream.Result);
        }
    }
}