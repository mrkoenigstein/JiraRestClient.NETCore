using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cschulc.Jira.Test
{
    [TestClass]
    public class TestProjectClient :BaseTest
    {
        [TestMethod]
        public void TestGetAllProjects(){
            var task = restClient.ProjectClient.GetAllProjects();
            var result = task.GetAwaiter().GetResult();
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void TestProjectByKey(){
            var task = restClient.ProjectClient.GetProjectByKey(project_key);
            var result = task.GetAwaiter().GetResult();
            Assert.AreEqual(project_key, result.key);
        }
    }
}