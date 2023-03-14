using JiraRestClient.Net.Core.Extension;
using JiraRestClient.Net.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestUriHelper : BaseTest
    {
        [TestMethod]
        public void TestBuilderPath()
        {
            var uri = BaseUri.AddPaths(RestPathConstants.User, RestPathConstants.Attachments,
                RestParamConstants.IssueKey);
            Assert.AreEqual($"{BaseUri}/user/attachments/issueKey", uri.ToString());
        }

        [TestMethod]
        public void TestAddQuery()
        {
            var uri = BaseUri.AddQuery("expand=summary", "field=renderedFields");
            Assert.AreEqual($"{BaseUri}?expand=summary&field=renderedFields",
                uri.ToString());
        }
    }
}