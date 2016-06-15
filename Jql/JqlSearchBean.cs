using System;
using System.Collections.Generic;

namespace Micromata.Jira.Jql
{
    public class JqlSearchBean
    {
        /**
         * Result list start at.
         */
        public int startAt { get; set; }

        /**
         * Maximum result list size.
         */
        public int maxResults { get; set; }

        /**
         * Result fields for a query.
         */
        public List<string> fields = new List<string>();

        public String jql { get; set; }

        public List<String> expand = new List<string>();


        public JqlSearchBean()
        {
            startAt = 0;
            maxResults = 50;
        }

        /**
         * Adds fields which should be returned after the request.
         *
         * @param fields = returned fields
         */
        public void AddField(params EField[] efields)
        {
            foreach (EField element in efields)
            {
                fields.Add(element.ToString());
            }
        }

        public void AddExpand(params EField[] efields)
        {
            foreach (EField element in efields)
            {
                expand.Add(element.ToString());
            }
        }

    }
}
