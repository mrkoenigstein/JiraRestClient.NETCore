namespace JiraRestClient.Net.Domain
{
    public class Base
    {
        public long Id { get; set; }
        public string Self { get; set; }
        public string Name { get; set; }
    }

    public class KeyBase : Base
    {
        public string Key { get; set; }
    }
}
