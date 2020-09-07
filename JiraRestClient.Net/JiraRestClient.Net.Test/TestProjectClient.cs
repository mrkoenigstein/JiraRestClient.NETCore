using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestProjectClient :BaseTest
    {
        [TestMethod]
        public void TestGetAllProjects(){
            var task = RestClient.ProjectClient.GetAllProjects();
            task.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void TestProjectByKey(){
            var project = RestClient.ProjectClient.GetProjectByKey(ProjectKey);
            project.Should().NotBeNull();
            project.Key.Should().Be(ProjectKey);
        }
    }
}