using System.Collections.Generic;

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
        public readonly List<string> Fields = new();

        public string Jql { get; set; }

        public readonly List<string> Expand = new();


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
                Fields.Add(element.ToString());
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
