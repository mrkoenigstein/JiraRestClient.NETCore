namespace JiraRestClient.Net.Jql
{
    public class EField
    {
        public static readonly EField All = new EField("*all", null);

        public static readonly EField Navigable = new EField("*navigable", null);
        
        public static readonly EField AffectedVersion = new EField("affectedVersion", EFieldType.Version);
        
        public static readonly EField Assignee = new EField("assignee", EFieldType.User);

        public static readonly EField Category = new EField("category", EFieldType.Category);
        
        public static readonly EField Comment = new EField("comment", EFieldType.Text);
        
        public static readonly EField Component = new EField("component", EFieldType.Component);
        
        public static readonly EField Created = new EField("created", EFieldType.Date);
        
        public static readonly EField Description = new EField("description", EFieldType.Text);

        public static readonly EField Due = new EField("due", EFieldType.Date);
        
        public static readonly EField Environment = new EField("environment", EFieldType.Text);
        
        public static readonly EField EpicLinks = new EField("epic link", EFieldType.CustomType);
        
        public static readonly EField Filter = new EField("filter", EFieldType.Filter);
        
        public static readonly EField FixVersion = new EField("fixVersion", EFieldType.Version);
        
        public static readonly EField IssueKey = new EField("issueKey", EFieldType.Issue);
        
        public static readonly EField LastViewed = new EField("lastViewed", EFieldType.Date);
        
        public static readonly EField Level = new EField("level", EFieldType.SecurityLevel);
        
        public static readonly EField OriginalEstimate = new EField("originalEstimate", EFieldType.Duration);
        
        public static readonly EField Parent = new EField("parent", EFieldType.Issue);
        
        public static readonly EField Priority = new EField("priority", EFieldType.Priority);
        
        public static readonly EField Project = new EField("project", EFieldType.Project);
        
        public static readonly EField RemainingEstimate = new EField("remainingEstimate", EFieldType.Duration);
        
        public static readonly EField Reporter = new EField("reporter", EFieldType.User);
        
        public static readonly EField Resolution = new EField("resolution", EFieldType.Resolution);
        
        public static readonly EField Resolved = new EField("resolved", EFieldType.Date);
        
        public static readonly EField Sprint = new EField("sprint", EFieldType.Number);
        
        public static readonly EField Status = new EField("status", EFieldType.Status);
        
        public static readonly EField Summary = new EField("summary", EFieldType.Text);
        
        public static readonly EField Text = new EField("text", EFieldType.TextMaster);
        
        public static readonly EField IssueType = new EField("issuetype", EFieldType.IssueType);
        
        public static readonly EField TimeSpent = new EField("timeSpent", EFieldType.Duration);

        public static readonly EField Updated = new EField("updated", EFieldType.Date);
        
        public static readonly EField Voter = new EField("voter", EFieldType.User);
        
        public static readonly EField Votes = new EField("votes", EFieldType.Number);
        
        public static readonly EField Watcher = new EField("watcher", EFieldType.User);
        
        public static readonly EField Watchers = new EField("watchers", EFieldType.Number);

        public static readonly EField WorkRatio = new EField("workRatio", EFieldType.Number);
        
        public static readonly EField Transitions = new EField("transitions", EFieldType.CustomType);
        
        public static readonly EField Changelog = new EField("changelog", EFieldType.CustomType);

        public static readonly EField Renderedfields = new EField("renderedFields", EFieldType.CustomType);
        
        public string Field { get; private set; }

        public EFieldType Type { get; private set; }

        private EField(string field, EFieldType type)
        {
            this.Field = field;
            this.Type = type;
        }

        public override string ToString()
        {
            return Field;
        }
    }
}