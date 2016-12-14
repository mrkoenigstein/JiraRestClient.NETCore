using Xunit;

namespace Micromata.Jira.Test
{
    public class TestProjectClient :BaseTest
    {
        [Fact]
        public void TestGetAllProjects(){
            var task = restClient.ProjectClient.GetAllProjects();
            var result = task.GetAwaiter().GetResult();
            Assert.Equal(5, result.Count);
        }

        public void TestProjectByKey(){
            var task = restClient.ProjectClient.GetProjectByKey(project_key);
            var result = task.GetAwaiter().GetResult();
            Assert.Equal(project_key, result.key);
        }
    }
}