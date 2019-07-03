using System;
using Cschulc.Jira.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cschulc.Jira.Test
{
    [TestClass]
    public class TestUriHelper : BaseTest
    {
        [TestMethod]
        public void testBuilderPath()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var userUri = UriHelper.BuildPath(uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS, RestParamConstants.ISSUEKEY);
            Assert.AreEqual("http://localhost:2990/jira/rest/api/2/user/attachments/issueKey", userUri.ToString());
        }

        [TestMethod]
        [Ignore]
        public void testAddQuery()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var uribuilder = UriHelper.BuildPath(uri, RestPathConstants.ISSUE);
            UriHelper.AddQuery(uribuilder, "expand", "summary");
            UriHelper.AddQuery(uribuilder, "field", "renderedFields");
            Assert.AreEqual("http://localhost:2990/jira/rest/api/2/issue&expand=summary&field=renderedFields", uribuilder.ToString());           
        }
    }
}