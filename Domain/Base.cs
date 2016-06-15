namespace Micromata.Jira.Domain
{
    public class Base
    {
        public long id { get; set; }
        public string self { get; set; }
        public string name { get; set; }
    }

    public class Key : Base
    {
        public string key { get; set; }
    }
}
