namespace Micromata.Jira.Jql
{
    public class EKeyword
    {
        /**
         * Used to combine multiple clauses, allowing you to refine your search.
         * <p>Examples:
         * <li>project = "New office" and status = "open"
         * <li>status = open and priority = urgent and assignee = jsmith
         * <li>project = JRA and assignee != jsmith
         * <li>project in (JRA,CONF) and fixVersion = "3.14"
         * <li>reporter not in (Jack,Jill,John) and assignee not in (Jack,Jill,John)
         */
        public static readonly EKeyword AND = new EKeyword("and");

        /**
         * Used to combine multiple clauses, allowing you to expand your search.
         * <p>Examples:
         * <li>reporter = jsmith or reporter = jbrown
         * <li>duedate < now() or duedate is empty
         */
        public static readonly EKeyword OR = new EKeyword("or");

        /**
         * Used to negate individual clauses or a complex JQL query (a query made up of more than one clause)
         * using parentheses, allowing you to refine your search.
         * <p>Examples:
         * <li>not assignee = jsmith
         * <li>not (reporter = jsmith or reporter = jbrown)
         */
        public static readonly EKeyword NOT = new EKeyword("not");

        /**
         * Used to search for issues where a given field does not have a value.
         * <p>Examples:
         * <li>duedate = empty
         * <li>duedate is empty
         */
        public static readonly EKeyword EMPTY = new EKeyword("empty");

        /**
         * Used to search for issues where a given field does not have a value.
         * <p>Examples:
         * <li>duedate = null
         * <li>duedate is null
         */
        public static readonly EKeyword NULL = new EKeyword("null");

        /**
         * Used to specify the fields by whose values the search results will be sorted.
         * <p>Examples:
         * <li>duedate = empty order by created
         * <li>duedate = empty order by created, priority desc
         * <li>duedate = empty order by created, priority asc
         */
        public static readonly EKeyword ORDER_BY = new EKeyword("order by");


        private string keyword { get; set; }

        /*
         * Instantiates a new keyword.
         *
         * @param keyword name of the keyword
         */
        private EKeyword(string _keyword)
        {
            keyword = _keyword;
        }

        public override string ToString()
        {
            return keyword;
        }
    }
}
