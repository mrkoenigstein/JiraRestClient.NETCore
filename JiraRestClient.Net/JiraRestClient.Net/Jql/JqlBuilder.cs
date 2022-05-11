using System;
using System.Text;

namespace JiraRestClient.Net.Jql
{
    public class JqlBuilder
    {
        private StringBuilder Jql { get; set; }

        public JqlBuilder()
        {
            Jql = new StringBuilder();
        }

        public JqlKeyword AddCondition(EField field, EOperator eoperator, String operand)
        {
            var jqlKeyword = new JqlKeyword {Jqlbuilder = this};
            if (field != null)
            {
                Jql.Append(field + " ");
            }
            if (eoperator != null)
            {
                Jql.Append(eoperator + " ");
            }
            if (operand != null)
            {
                Jql.Append(operand + " ");
            }
            return jqlKeyword;
        }

        public void Clear()
        {
            Jql.Clear();
        }

        public class JqlKeyword
        {
            public JqlBuilder Jqlbuilder { get; set; }

            public JqlBuilder And()
            {
                Jqlbuilder.Jql.Append(EKeyword.AND + " ");
                return Jqlbuilder;
            }

            public JqlBuilder Or()
            {
                Jqlbuilder.Jql.Append(EKeyword.OR + " ");
                return Jqlbuilder;
            }

            public String OrderBy(SortOrder order, params EField[] fields)
            {
                if (fields == null || order == null || fields.Length == 0)
                {
                    return Build();
                }

                Jqlbuilder.Jql.Append(EKeyword.ORDER_BY + " ");
                Jqlbuilder.Jql.Append(fields[0]);

                for (int i = 1; i < fields.Length; i++)
                {
                    Jqlbuilder.Jql.Append(", ");
                    Jqlbuilder.Jql.Append(fields[i]);
                }

                Jqlbuilder.Jql.Append(" " + order);

                return Build();
            }
            public String Build()
            {
                String request = Jqlbuilder.Jql.ToString();
                Jqlbuilder.Clear();
                return request;
            }


        }

    }
}
