namespace JiraRestClient.Net.Domain
{
    public class Version :Base
    {
        public string Description { get; set; }
        public bool Archived { get; set; }
        public bool Released { get; set; }
        public bool Overdue { get; set; }
        public string ReleaseDate { get; set; }
        public string UserReleaseDate { get; set; }
    }
}
