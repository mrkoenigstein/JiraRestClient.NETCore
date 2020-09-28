namespace JiraRestClient.Net.Util
{
    public static class Constants
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

        public const string IssueTypeImprovement = "improvement";

        public const string IssueTypeBug = "bug";

        public const string IssueTypeNewFeature = "new feature";

        public const string IssueTypeSubtask = "sub-task";

        public const string IssueTypeTask = "task";

        public const string IssueTypeStory = "Story";

        //Priority für die SQL Suche
        
        public const string PriorityHighest = "1";

        public const string PriorityHigh = "2";
        
        public const string PriorityMedium = "3";

        public const string PriorityLow = "4";

        public const string PriorityLowest = "5";
    }
}
