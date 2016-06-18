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
            var userUri = UriHelper.buildPath(uri, RestPathConstants.USER, RestPathConstants.ATTACHMENTS, RestParamConstants.ISSUEKEY);
        }
    }
}