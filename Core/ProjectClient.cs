using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Micromata.Jira.Domain;
using Micromata.Jira.Util;

namespace Micromata.Jira.Core
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
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.PROJECT);
            restUriBuilder.Query = RestParamConstants.PROJECT + "=" + key;
            var completeURI = restUriBuilder.ToString();
            var stream = client.GetStreamAsync(completeURI);
            var serializer = new DataContractJsonSerializer(typeof(Project));
            return serializer.ReadObject(await stream) as Project;
        }

        public async Task<List<Project>> GetAllProjects()
        {
            var restUriBuilder = UriHelper.BuildPath(baseUri, RestPathConstants.PROJECT);
            var stream = client.GetStreamAsync(restUriBuilder.ToString());
            var serializer = new DataContractJsonSerializer(typeof(List<Project>));
            return serializer.ReadObject(await stream) as List<Project>;
        }
    }
}