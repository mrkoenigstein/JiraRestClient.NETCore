namespace JiraRestClient.Net.Domain
{
    public class IssueType : Base
    {
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool Subtask { get; set; }
    }
}
