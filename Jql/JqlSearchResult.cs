using System.Collections.Generic;
using Micromata.Jira.Domain;

namespace Micromata.Jira.Jql
{
    public class JqlSearchResult
    {
        public string expand { get; set; }

        public int startAt { get; set; }

        public int maxResults { get; set; }

        public int total { get; set; }

        public List<Issue> issues { get; set; }

    }
}
