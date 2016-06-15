namespace Micromata.Jira.Jql
{
    public class SortOrder
    {
        public string name { get; set; }

        public static readonly SortOrder DESC = new SortOrder("desc");
        public static readonly SortOrder ASC = new SortOrder("asc");

        public SortOrder(string _name)
        {
            name = _name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
