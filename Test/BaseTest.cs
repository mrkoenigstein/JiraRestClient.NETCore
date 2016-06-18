using System;

namespace Micromata.Jira.Test
{
    public abstract class BaseTest
    {
        protected Uri uri = new Uri("http://localhost:2990/jira");
        protected string username = "admin";
        protected string password = "admin";
    }
}