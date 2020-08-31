using System.Collections.Generic;
using System.Runtime.Serialization.Json;
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

        public async Task<Project> GetProjectByKey(string key)
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT);
            restUriBuilder.Query = RestParamConstants.PROJECT + "=" + key;
            var completeUri = restUriBuilder.ToString();
            var stream = Client.GetStreamAsync(completeUri);
            var serializer = new DataContractJsonSerializer(typeof(Project));
            return serializer.ReadObject(await stream) as Project;
        }

        public async Task<List<Project>> GetAllProjects()
        {
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Project>));
            return serializer.ReadObject(await stream) as List<Project>;
        }

        public async Task<List<Version>> GetProjectVersions(string key){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT, key, RestPathConstants.VERSIONS);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Version>));
            return serializer.ReadObject(await stream) as List<Version>;
        }

        public async Task<List<Component>> GetProjectComponents(string key){
            var restUriBuilder = UriHelper.BuildPath(BaseUri, RestPathConstants.PROJECT, key, RestPathConstants.COMPONENTS);
            var stream = Client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Component>));
            return serializer.ReadObject(await stream) as List<Component>;
        }
    }
}