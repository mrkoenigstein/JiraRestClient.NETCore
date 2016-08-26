using System;
using Micromata.Jira.Util;
using Xunit;

namespace Micromata.Jira.Test
{
    public class TestUriHelper : BaseTest
    {
        [Fact]
        public void testBuilderPath()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var userUri = UriHelper.BuildPath(uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS, RestParamConstants.ISSUEKEY);
            Assert.Equal("{http://localhost:2990/jira/rest/api/2/user/attachments/issueKey}", userUri.ToString());
        }

        [Fact]
        public void testAddQuery()
        {
            var uri = new Uri("http://localhost:2990/jira");
            var uribuilder = UriHelper.BuildPath(uri, RestPathConstants.ISSUE);
            UriHelper.AddQuery(uribuilder, "expand", "summary");
            UriHelper.AddQuery(uribuilder, "field", "renderedFields");
            Assert.Equal("http://localhost:2990/jira/rest/api/2/issue&expand=summary&field=renderedFields", uribuilder.ToString());           
        }
    }
}