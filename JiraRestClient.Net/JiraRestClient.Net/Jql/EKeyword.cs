namespace JiraRestClient.Net.Jql
{
    public class EKeyword
    {
        /**
         * Used to combine multiple clauses, allowing you to refine your search.
         * <p>Examples:</p>
         * <ul>
         * <li>project = "New office" and status = "open"</li>
         * <li>status = open and priority = urgent and assignee = jsmith</li>
         * <li>project = JRA and assignee != jsmith</li>
         * <li>project in (JRA,CONF) and fixVersion = "3.14"</li>
         * <li>reporter not in (Jack,Jill,John) and assignee not in (Jack,Jill,John)</li>
         * </ul>
         */
        public static readonly EKeyword AND = new EKeyword("and");

        /**
         * Used to combine multiple clauses, allowing you to expand your search.
         * <p>Examples:</p>
         * <ul>
         * <li>reporter = jsmith or reporter = jbrown</li>
         * <li>duedate < now() or duedate is empty</li>
         * </ul>
         */
        public static readonly EKeyword OR = new EKeyword("or");

        /**
         * Used to negate individual clauses or a complex JQL query (a query made up of more than one clause)
         * using parentheses, allowing you to refine your search.
         * <p>Examples:</p>
         * <ul>
         * <li>not assignee = jsmith</li>
         * <li>not (reporter = jsmith or reporter = jbrown)</li>
         * </ul>
         */
        public static readonly EKeyword NOT = new EKeyword("not");

        /**
         * Used to search for issues where a given field does not have a value.
         * <p>Examples:</p>
         * <ul>
         * <li>duedate = empty</li>
         * <li>duedate is empty</li>
         * </ul>
         */
        public static readonly EKeyword EMPTY = new EKeyword("empty");

        /**
         * Used to search for issues where a given field does not have a value.
         * <p>Examples:</p>
         * <ul>
         * <li>duedate = null</li>
         * <li>duedate is null</li>
         * </ul>
         */
        public static readonly EKeyword NULL = new EKeyword("null");

        /**
         * Used to specify the fields by whose values the search results will be sorted.
         * <p>Examples:</p>
         * <ul>
         * <li>duedate = empty order by created</li>
         * <li>duedate = empty order by created, priority desc</li>
         * <li>duedate = empty order by created, priority asc</li>
         * </ul>
         */
        public static readonly EKeyword ORDER_BY = new EKeyword("order by");


        private string Keyword { get; set; }

        /*
         * Instantiates a new keyword.
         *
         * @param keyword name of the keyword
         */
        private EKeyword(string keyword)
        {
            Keyword = keyword;
        }

        public override string ToString()
        {
            return Keyword;
        }
    }
}
