using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Version = JiraRestClient.Net.Domain.Version;

namespace JiraRestClient.Net.Domain
{
    public class Issue : KeyBase
    {
        public string Expand { get; set; }

        public IssueFields Fields { get; set; }

        public RenderedFields RenderedFields { get; set; }

        public List<Transition> Transitions { get; set; }

        public ChangeLog Changelog { get; set; }
    }


    public class IssueFields
    {
        public string Summary { get; set; }
        public Progress Progress { get; set; }
        public Timetracking Timetracking { get; set; }
        public IssueType Issuetype { get; set; }
        public Votes Votes { get; set; }
        public Resolution Resolution { get; set; }
        public List<Version> FixVersions { get; set; }
        public string Resolutiondate { get; set; }
        public int? Timespent { get; set; }
        public Creator Creator { get; set; }
        public Reporter Reporter { get; set; }
        public int? Aggregatetimeoriginalestimate { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public string Duedate { get; set; }
        public List<object> Issuelinks { get; set; }
        public Watches Watches { get; set; }
        public Worklog Worklog { get; set; }
        public List<object> Subtasks { get; set; }
        public Status Status { get; set; }
        public List<string> Labels { get; set; }
        public int? Workratio { get; set; }
        public Assignee Assignee { get; set; }
        public List<Attachment> Attachment { get; set; }
        public int? Aggregatetimeestimate { get; set; }
        public Project Project { get; set; }
        public List<Version> Versions { get; set; }
        public string Environment { get; set; }
        public int? Timeestimate { get; set; }
        public Aggregateprogress Aggregateprogress { get; set; }
        public string LastViewed { get; set; }
        public List<Component> Components { get; set; }

        [DataMember(Name = "comment")]
        public CommentList CommentList { get; set; }
        public int? Timeoriginalestimate { get; set; }
        public int? Aggregatetimespent { get; set; }
    }

    public class Timetracking
    {
        public string OriginalEstimate { get; set; }
        public int? OriginalEstimateSeconds { get; set; }
    }

    public class Votes
    {
        public string Self { get; set; }
        public int? votes { get; set; }
        public bool HasVoted { get; set; }
    }

    public class Progress
    {
        public int? progress { get; set; }
        public int? Total { get; set; }
    }

    public class AvatarUrls
    {

        [DataMember(Name = "16x16")]
        public string Url16X16 { get; set; }

        [DataMember(Name = "24x24")]
        public string Url24X24 { get; set; }
        [DataMember(Name = "24x24")]
        public string Url32X32 { get; set; }
        [DataMember(Name = "24x24")]
        public string Url48X48 { get; set; }
    }

    public class Creator
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }


    public class Reporter
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }

    public class Priority
    {
        public string Self { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Watches
    {
        public string Self { get; set; }
        public int? WatchCount { get; set; }
        public bool IsWatching { get; set; }
    }

    public class Worklog
    {
        public int? StartAt { get; set; }
        public int? MaxResults { get; set; }
        public int? Total { get; set; }
        public List<object> Worklogs { get; set; }
    }

    public class StatusCategory
    {
        public string Self { get; set; }
        public int? Id { get; set; }
        public string Key { get; set; }
        public string ColorName { get; set; }
        public string Name { get; set; }
    }

    public class Status
    {
        public string Self { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public StatusCategory StatusCategory { get; set; }
    }

    public class Assignee
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }


    public class Author
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }

    public class Attachment
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Filename { get; set; }
        public Author Author { get; set; }
        public string Created { get; set; }
        public int? Size { get; set; }
        public string MimeType { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
    }

    public class Aggregateprogress
    {
        public int? Progress { get; set; }
        public int? Total { get; set; }
    }

    public class CommentList
    {
        public int? StartAt { get; set; }
        public int? MaxResults { get; set; }
        public int? Total { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class Resolution : Base
    {
        public string Description { get; set; }
    }

    public class Comment : Base
    {
        public User Author { get; set; }

        public string Body { get; set; }

        public User UpdateAuthor { get; set; }

        public string Created { get; set; }

        public string Updated { get; set; }
    }

    public class RenderedFields : Base
    {

        public string Aggregatetimeestimate { get; set; }

        public string Aggregatetimeoriginalestimate { get; set; }

        public Timetracking Timetracking { get; set; }

        public string Environment { get; set; }

        public string Created { get; set; }

        public string Updated { get; set; }

        public string Description { get; set; }

        public string Timeestimate { get; set; }

        public string Duedate { get; set; }

        public string LastViewed { get; set; }

        public List<Attachment> Attachment { get; set; }

        public CommentList Comment { get; set; }

        public string Timeoriginalestimate { get; set; }

        public object Timespent { get; set; }

        public Worklog Worklog { get; set; }

        public object Aggregatetimespent { get; set; }
    }

    public class ChangeLog : Base
    {

        public int StartAt { get; set; }

        public int MaxResults { get; set; }

        public int Total { get; set; }

        public List<History> Histories { get; set; }
    }

    public class History : Base
    {

        public User Author { get; set; }

        public string Created { get; set; }

        public List<Item> Items { get; set; }
    }

    public class Item : Base
    {

        public string Field { get; set; }

        public string Fieldtype { get; set; }

        public string From { get; set; }

        public string FromString { get; set; }

        public string To { get; set; }
        
    }

    public class Transition
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Status To { get; set; }
    }

}
