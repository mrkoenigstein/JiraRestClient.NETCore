namespace JiraRestClient.Net.Jql
{
    public class SortOrder
    {
        private string Name { get; set; }

        public static readonly SortOrder Desc = new SortOrder("desc");
        public static readonly SortOrder Asc = new SortOrder("asc");

        private SortOrder(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
