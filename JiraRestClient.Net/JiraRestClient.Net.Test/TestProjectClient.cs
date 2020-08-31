using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestProjectClient :BaseTest
    {
        [TestMethod]
        public void TestGetAllProjects(){
            var task = RestClient.ProjectClient.GetAllProjects();
            var result = task.GetAwaiter().GetResult();
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void TestProjectByKey(){
            var task = RestClient.ProjectClient.GetProjectByKey(ProjectKey);
            var result = task.GetAwaiter().GetResult();
            Assert.AreEqual(ProjectKey, result.Key);
        }
    }
}