namespace JiraRestClient.Net.Jql
{
    public static class JqlConstants
    {
        public const string Project = "project";

        public const string OrderBy = "ORDER_BY";

        public const string Issuetype = "issuetype";

        public const string Status = "status";

        public const string And = "and";

        public const string Or = "or";

        // Issue Field Names für die JQL Suche

        public const string FieldSummary = "summary";

        public const string FieldIssuetype = "issuetype";

        public const string FieldStatus = "status";

        public const string FieldDuedate = "duedate";

        public const string FieldPriority = "priority";

        //Issue Status für die JQL Suche

        public const string StatusOpen = "open";

        public const string StatusClosed = "closed";

        public const string StatusResolved = "resolved";

        public const string StatusInProgress = "in progress";

        public const string StatusReopened = "reopened";

        //Issue Type für die JQL Suche

        public const string IssuetypeImprovement = "improvement";

        public const string IssuetypeBug = "bug";

        public const string IssuetypeNewFeature = "new feature";

        public const string IssuetypeSubtask = "sub-task";

        public const string IssuetypeTask = "task";

        //Priority für die SQL Suche

        public const string PriorityMajor = "major";

        public const string PriorityBlocker = "blocker";

        public const string PriorityCritical = "critical";

        public const string PriorityMinor = "minor";

        public const string PriorityTrivial = "trivial";
    }
}
