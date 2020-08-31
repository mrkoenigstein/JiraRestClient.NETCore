using Cschulc.Jira.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test
{
    [TestClass]
    public class TestUriHelper : BaseTest
    {
        [TestMethod]
        public void TestBuilderPath()
        {
            var userUri = UriHelper.BuildPath(Uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS,
                RestParamConstants.ISSUEKEY);
            Assert.AreEqual("http://localhost:2990/jira/rest/api/2/user/attachments/issueKey", userUri.ToString());
        }

        [TestMethod]
        [Ignore]
        public void TestAddQuery()
        {
            var uriBuilder = UriHelper.BuildPath(Uri, RestPathConstants.ISSUE);
            UriHelper.AddQuery(uriBuilder, "expand", "summary");
            UriHelper.AddQuery(uriBuilder, "field", "renderedFields");
            Assert.AreEqual("http://localhost:2990/jira/rest/api/2/issue&expand=summary&field=renderedFields",
                uriBuilder.ToString());
        }
    }
}