using System;
using System.Text;

namespace Cschulc.Jira.Jql
{
    public class JqlBuilder
    {
        private StringBuilder jql { get; set; }

        public JqlBuilder()
        {
            jql = new StringBuilder();
        }

        public JqlKeyword AddCondition(EField field, EOperator eoperator, String operand)
        {
            JqlKeyword jqlKeyword = new JqlKeyword();
            jqlKeyword.jqlbuilder = this;
            if (field != null)
            {
                jql.Append(field.ToString() + " ");
            }
            if (eoperator != null)
            {
                jql.Append(eoperator.ToString() + " ");
            }
            if (operand != null)
            {
                jql.Append(operand + " ");
            }
            return jqlKeyword;
        }

        public void Clear()
        {
            jql.Clear();
        }

        public class JqlKeyword
        {
            public JqlBuilder jqlbuilder { get; set; }

            public JqlBuilder And()
            {
                jqlbuilder.jql.Append(EKeyword.AND + " ");
                return jqlbuilder;
            }

            public JqlBuilder Or()
            {
                jqlbuilder.jql.Append(EKeyword.OR + " ");
                return jqlbuilder;
            }

            public String OrderBy(SortOrder order, params EField[] fields)
            {
                if (fields == null || order == null || fields.Length == 0)
                {
                    return Build();
                }

                jqlbuilder.jql.Append(EKeyword.ORDER_BY + " ");
                jqlbuilder.jql.Append(fields[0]);

                for (int i = 1; i < fields.Length; i++)
                {
                    jqlbuilder.jql.Append(", ");
                    jqlbuilder.jql.Append(fields[i]);
                }

                jqlbuilder.jql.Append(" " + order);

                return Build();
            }
            public String Build()
            {
                String request = jqlbuilder.jql.ToString();
                jqlbuilder.Clear();
                return request;
            }


        }

    }
}
