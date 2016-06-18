using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Micromata.Jira.Domain
{
    public class Issue : Key
    {
        public string expand { get; set; }

        public IssueFields fields { get; set; }
    }


    public class IssueFields
    {
        public string summary { get; set; }
        public Progress progress { get; set; }
        public Timetracking timetracking { get; set; }
        public IssueType issuetype { get; set; }
        public Votes votes { get; set; }
        public Resolution resolution { get; set; }
        public List<Version> fixVersions { get; set; }
        public string resolutiondate { get; set; }
        public int? timespent { get; set; }
        public Creator creator { get; set; }
        public Reporter reporter { get; set; }
        public int? aggregatetimeoriginalestimate { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string description { get; set; }
        public Priority priority { get; set; }
        public string duedate { get; set; }
        public List<object> issuelinks { get; set; }
        public Watches watches { get; set; }
        public Worklog worklog { get; set; }
        public List<object> subtasks { get; set; }
        public Status status { get; set; }
        public List<string> labels { get; set; }
        public int? workratio { get; set; }
        public Assignee assignee { get; set; }
        public List<Attachment> attachment { get; set; }
        public int? aggregatetimeestimate { get; set; }
        public Project project { get; set; }
        public List<Version> versions { get; set; }
        public string environment { get; set; }
        public int? timeestimate { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public string lastViewed { get; set; }
        public List<Component> components { get; set; }
        
        [DataMember(Name="comment")]
        public CommentList commentList { get; set; }
        public int? timeoriginalestimate { get; set; }
        public int? aggregatetimespent { get; set; }
    }

    public class Timetracking
    {
        public string originalEstimate { get; set; }
        public int? originalEstimateSeconds { get; set; }
    }

    public class Votes
    {
        public string self { get; set; }
        public int? votes { get; set; }
        public bool hasVoted { get; set; }
    }

    public class Progress
    {
        public int? progress { get; set; }
        public int? total { get; set; }
    }

    public class AvatarUrls
    {

        [DataMember(Name = "16x16")]
        public string url16x16 { get; set; }

        [DataMember(Name = "24x24")]
        public string url24x24 { get; set; }
        [DataMember(Name = "24x24")]
        public string url32x32 { get; set; }
        [DataMember(Name = "24x24")]
        public string url48x48 { get; set; }
    }

    public class Creator
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }


    public class Reporter
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }

    public class Priority
    {
        public string self { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Watches
    {
        public string self { get; set; }
        public int? watchCount { get; set; }
        public bool isWatching { get; set; }
    }

    public class Worklog
    {
        public int? startAt { get; set; }
        public int? maxResults { get; set; }
        public int? total { get; set; }
        public List<object> worklogs { get; set; }
    }

    public class StatusCategory
    {
        public string self { get; set; }
        public int? id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public StatusCategory statusCategory { get; set; }
    }

    public class Assignee
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }


    public class Author
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }

    public class Attachment
    {
        public string self { get; set; }
        public string id { get; set; }
        public string filename { get; set; }
        public Author author { get; set; }
        public string created { get; set; }
        public int? size { get; set; }
        public string mimeType { get; set; }
        public string content { get; set; }
        public string thumbnail { get; set; }
    }

    public class Aggregateprogress
    {
        public int? progress { get; set; }
        public int? total { get; set; }
    }

    public class CommentList
    {
        public int? startAt { get; set; }
        public int? maxResults { get; set; }
        public int? total { get; set; }
        public List<Comment> comments { get; set; }
    }

    public class Resolution : Base
    {
        public string description { get; set; }
    }

    public class Comment : Base
    {
        public User author { get; set; }

        public String body { get; set; }

        public User updateAuthor { get; set; }

        public string created { get; set; }

        public string updated { get; set; }
    }

}
