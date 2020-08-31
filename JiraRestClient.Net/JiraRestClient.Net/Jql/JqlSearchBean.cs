using System;
using System.Collections.Generic;
using Cschulc.Jira.Jql;

namespace JiraRestClient.Net.Jql
{
    public class JqlSearchBean
    {
        /**
         * Result list start at.
         */
        public int StartAt { get; set; }

        /**
         * Maximum result list size.
         */
        public int MaxResults { get; set; }

        /**
         * Result fields for a query.
         */
        public readonly List<string> fields = new List<string>();

        public string Jql { get; set; }

        public readonly List<string> Expand = new List<string>();


        public JqlSearchBean()
        {
            StartAt = 0;
            MaxResults = 50;
        }

        /**
         * Adds fields which should be returned after the request.
         *
         * @param fields = returned fields
         */
        public void AddField(params EField[] efields)
        {
            foreach (var element in efields)
            {
                fields.Add(element.ToString());
            }
        }

        public void AddExpand(params EField[] efields)
        {
            foreach (var element in efields)
            {
                Expand.Add(element.ToString());
            }
        }

    }
}
