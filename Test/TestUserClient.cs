using Micromata.Jira.Domain;
using Xunit;

namespace Micromata.Jira.Test
{
    public class TestUserClient : BaseTest
    {

        [Fact]
        public void testGetLoggedInUser()
        {
            var restclient = new JiraRestClient(uri, username, password);
            var userclient = restclient.UserClient;
            var task = userclient.getLoggedInUser();
            var user = task.GetAwaiter().GetResult() as User;
            Assert.NotNull(user);
        }
    }
}