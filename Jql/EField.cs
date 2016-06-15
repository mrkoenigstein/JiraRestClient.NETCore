namespace Micromata.Jira.Jql
{
    public class EField
    {
        public static readonly EField ALL = new EField("*all", null);

        public static readonly EField NAVIGABLE = new EField("*navigable", null);

        /**
         * Issues that are assigned to a particular Affects Version(s).
         * <p/>
         * <p>Examples:
         * <li>affectedVersion = "3.14"
         * <li>affectedVersion = "Big Ted"
         * <li>affectedVersion = 10350
         */
        public static readonly EField AFFECTED_VERSION = new EField("affectedVersion", EFieldType.VERSION);

        /**
         * Issues that are assigned to a particular user.
         * <p>Examples:
         * <li>assignee = "John Smith"
         * <li>assignee = jsmith
         * <li>assignee WAS "John Smith"
         * <li>assignee WAS jsmith
         * <li>assignee = "bob@mycompany.com"
         */
        public static readonly EField ASSIGNEE = new EField("assignee", EFieldType.USER);

        /**
         * Issues that belong to projects in a particular Category.
         * <p>Examples:
         * <li>category = "Alphabet Projects"
         */
        public static readonly EField CATEGORY = new EField("category", EFieldType.CATEGORY);

        /**
         * Issues that have a Comment which contains particular text.
         * <p>Examples:
         * <li>comment ~ "My PC is quite old"
         * <li>comment ~ "\"My PC is quite old\""
         */
        public static readonly EField COMMENT = new EField("comment", EFieldType.TEXT);

        /**
         * Issues that belong to a particular component(s) of a project.
         * <p>Examples:
         * <li>component in (Comp1, Comp2)
         * <li>component in (Comp1) and component in (Comp2)
         * <li>component = Comp1 and component = Comp2
         * <li>component = 20500
         */
        public static readonly EField COMPONENT = new EField("component", EFieldType.COMPONENT);

        /**
         * Issues that were created on, before or after a particular date (or date range).
         * <p>Use one of the following formats:
         * <li>"yyyy/MM/dd HH:mm"</li>
         * <li>"yyyy-MM-dd HH:mm"</li>
         * <li>"yyyy/MM/dd"</li>
         * <li>"yyyy-MM-dd"</li>
         * <p>Alias <b>createdDate</b>.
         * <p>Examples:
         * <li>created < "2010/12/12"
         * <li>created <= "2010/12/13"
         * <li>created > "2010/12/12" and created < "2010/12/12 14:00"
         * <li>created > "-1d"
         * <li>created > "2011/01/01" and created < "2011/02/01"
         * <li>created > "2011/01/15" and created < "2011/01/16"
         */
        public static readonly EField CREATED = new EField("created", EFieldType.DATE);

        //	CUSTOM_FIELD("CustomFieldName", EFieldType.CUSTOM_TYPE),

        /**
         * Issues where the Description contains particular text.
         * <p>Examples:
         * <li>description ~ "Please see screenshot"
         * <li>description ~ "\"Please see screenshot\""
         */
        public static readonly EField DESCRIPTION = new EField("description", EFieldType.TEXT);

        /**
         * Issues that were due on, before or after a particular date (or date range).
         * <p>Use one of the following formats:
         * <li>"yyyy/MM/dd"</li>
         * <li>"yyyy-MM-dd"</li>
         * <p>Alias <b>dueDate</b>.
         * <p>Examples:
         * <li>due < "2010/12/31"
         * <li>due <= "2011/01/01"
         * <li>due = "1d"
         * <li>due >= "2011/01/01" and due <= "2011/01/31"
         * <li>due = "2011/01/15"
         */
        public static readonly EField DUE = new EField("due", EFieldType.DATE);

        /**
         * Issues where the Environment contains particular text.
         * <p>Examples:
         * <li>environment ~ "Third floor"
         * <li>environment ~ "\"Third floor\""
         */
        public static readonly EField ENVIRONMENT = new EField("environment", EFieldType.TEXT);

        /**
         * <i>Only available if you are using GreenHopper 6.1.2 or later.</i>
         * <p>Issues that belong to a particular epic in GreenHopper.
         * <p>Examples:
         * <li>"epic link" = ANERDS-317
         * <li>"epic link" = Jupiter
         */
        public static readonly EField EPIC_LINKS = new EField("epic link", EFieldType.CUSTOM_TYPE);

        /**
         * You can use a saved filter to narrow your search. You can search by filter name or
         * filter ID (i.e. the number that JIRA automatically allocates to a saved filter).
         * <p>Alias <b>request</b>, <b>savedFilter</b>, <b>searchRequest</b>.
         * <p>Examples:
         * <li>filter = "My Saved Filter" and assignee = jsmith
         * <li>filter = 12000 and assignee = jsmith
         */
        public static readonly EField FILTER = new EField("filter", EFieldType.FILTER);

        /**
         * Issues that are assigned to a particular Fix Version.
         * <p>Examples:
         * <li>fixVersion in ("3.14", "4.2")
         * <li>fixVersion = "Little Ted"
         * <li>fixVersion = 10001
         */
        public static readonly EField FIX_VERSION = new EField("fixVersion", EFieldType.VERSION);

        /**
         * Issues with a particular Issue Key or Issue ID (i.e. the number that JIRA automatically allocates to an Issue).
         * <p>Alias <b>id</b>, <b>issue</b>, <b>key</b>.
         * <p>Examples:
         * <li>issueKey = ABC-123
         */
        public static readonly EField ISSUE_KEY = new EField("issueKey", EFieldType.ISSUE);

        /**
         * Issues that were last viewed on, before or after a particular date (or date range).
         * <p>Use one of the following formats:
         * <li>"yyyy/MM/dd HH:mm"</li>
         * <li>"yyyy-MM-dd HH:mm"</li>
         * <li>"yyyy/MM/dd"</li>
         * <li>"yyyy-MM-dd"</li>
         * <p>Examples:
         * <li>lastViewed < "2010/12/12"
         * <li>lastViewed <= "2010/12/13"
         * <li>lastViewed > "2010/12/12" and created < "2010/12/12 14:00"
         * <li>lastViewed > "-1d"
         * <li>lastViewed > "2011/01/01" and created < "2011/02/01"
         * <li>lastViewed > "2011/01/15" and created < "2011/01/16"
         */
        public static readonly EField LAST_VIEWED = new EField("lastViewed", EFieldType.DATE);

        /**
         * <i>Only available if Issue Level Security has been enabled by your JIRA administrator.</i>
         * <p>Issues with a particular Security Level.
         * <p>Examples:
         * <li>level in ("Really High", level1)
         * <li>level = 123
         */
        public static readonly EField LEVEL = new EField("level", EFieldType.SECURITY_LEVEL);

        /**
         * <i>Only available if time-tracking has been enabled by your JIRA administrator.</i>
         * <p>Search for issues where the Original Estimate is set to a particular value (i.e. a number, not a date or date range).
         * <p>Alias <b>timeOriginalEstimate</b>
         * <p>Examples:
         * <li>originalEstimate = 1h
         * <li>originalEstimate > 2d
         */
        public static readonly EField ORIGINAL_ESTIMATE = new EField("originalEstimate", EFieldType.DURATION);

        /**
         * <i>Only available if sub-tasks have been enabled by your JIRA administrator.</i>
         * <p>Search for all sub-tasks of a particular issue.
         * <p>Examples:
         * <li>parent = TEST-1234
         */
        public static readonly EField PARENT = new EField("parent", EFieldType.ISSUE);

        /**
         * Issues with a particular Priority.
         * <p>Examples:
         * <li>priority = High
         * <li>priority = 10000
         */
        public static readonly EField PRIORITY = new EField("priority", EFieldType.PRIORITY);

        /**
         * Issues that belong to a particular Project.
         * <p>Examples:
         * <li>project = "ABC Project"
         * <li>project = "ABC"
         * <li>project = 1234
         */
        public static readonly EField PROJECT = new EField("project", EFieldType.PROJECT);

        /**
         * <i>Only available if time-tracking has been enabled by your JIRA administrator.</i>
         * <p>Search for issues where the Remaining Estimate is set to a particular value (i.e. a number, not a date or date range).
         * <p>Alias <b>timeEstimate</b>
         * <p>Examples:
         * <li>remainingEstimate > 4h
         */
        public static readonly EField REMAINING_ESTIMATE = new EField("remainingEstimate", EFieldType.DURATION);

        /**
         * Issues that were reported by (i.e. created by) a particular user.
         * <p>Examples:
         * <li>reporter = "Jill Jones"
         * <li>reporter = jjones
         * <li>reporter = "bob@mycompany.com"
         */
        public static readonly EField REPORTER = new EField("reporter", EFieldType.USER);

        /**
         * Issues that have a particular Resolution.
         * <p>Examples:
         * <li>resolution in ("Cannot Reproduce", "Won't Fix")
         * <li>resolution = 5
         * <li>resolution = unresolved
         */
        public static readonly EField RESOLUTION = new EField("resolution", EFieldType.RESOLUTION);

        /**
         * Issues that were resolved on, before or after a particular date (or date range).
         * <p>Use one of the following formats:
         * <li>"yyyy/MM/dd HH:mm"</li>
         * <li>"yyyy-MM-dd HH:mm"</li>
         * <li>"yyyy/MM/dd"</li>
         * <li>"yyyy-MM-dd"</li>
         * <p>Alias <b>resolutionDate</b>
         * <p>Examples:
         * <li>resolved <= "2010/12/31"
         * <li>resolved < "2010/12/31 14:00"
         * <li>resolved <= "2011/01/01"
         * <li>resolved > "2011/01/01" and resolved < "2011/02/01"
         * <li>resolved > "2011/01/15" and resolved < "2011/01/16"
         * <li>resolved > -1h
         */
        public static readonly EField RESOLVED = new EField("resolved", EFieldType.DATE);

        /**
         * <i>Only available if you are using GreenHopper.</i>
         * <p>Search for issues that are assigned to a particular sprint in GreenHopper.
         * <p>Examples:
         * <li>sprint = 999
         * <li>sprint = "February 1"
         * <li>sprint in ("February 1","February 2","February 3")
         * <li>sprint is not empty
         */
        public static readonly EField SPRINT = new EField("sprint", EFieldType.NUMBER);

        /**
         * Issues that have a particular Status.
         * <p>Examples:
         * <li>status = Open
         * <li>status = 1
         * <li>status WAS Open
         */
        public static readonly EField STATUS = new EField("status", EFieldType.STATUS);

        /**
         * Issues where the Summary contains particular text.
         * <p>Examples:
         * <li>summary ~ "Error saving file"
         * <li>summary ~ "\"Error saving file\""
         */
        public static readonly EField SUMMARY = new EField("summary", EFieldType.TEXT);

        /**
         * This is a "master-field" that allows you to search all text fields, i.e.:
         * <li>Summary</li>
         * <li>Description</li>
         * <li>Environment</li>
         * <li>Comments</li>
         * <p>Examples:
         * <li>text ~ "Fred"
         * <li>text ~ Fred
         * <li>text ~ "\"full screen\""
         */
        public static readonly EField TEXT = new EField("text", EFieldType.TEXT_MASTER);

        /**
         * Issues that have a particular Issue Type.
         * <p>Alias <b>issueType</b>
         * <p>Examples:
         * <li>type = Bug
         * <li>issueType in (Bug,Improvement)
         * <li>issueType = 2
         */
        public static readonly EField ISSUE_TYPE = new EField("issuetype", EFieldType.ISSUE_TYPE);

        /**
         * <i>Only available if time-tracking has been enabled by your JIRA administrator.</i>
         * <p>Search for issues where the Time Spent is set to a particular value (i.e. a number, not a date or date range).
         * <p>Examples:
         * <li>timeSpent > 5d
         */
        public static readonly EField TIME_SPENT = new EField("timeSpent", EFieldType.DURATION);

        /**
         * Issues that were updated on, before or after a particular date (or date range).
         * <p>Use one of the following formats:
         * <li>"yyyy/MM/dd HH:mm"</li>
         * <li>"yyyy-MM-dd HH:mm"</li>
         * <li>"yyyy/MM/dd"</li>
         * <li>"yyyy-MM-dd"</li>
         * <p>Alias <b>updatedDate</b>
         * <p>Examples:
         * <li>updated < "2010/12/12"
         * <li>updated < "2010/12/13"
         * <li>updated < "2010/12/31 14:00"
         * <li>updated < "-2w"
         * <li>updated > "2011/01/15" and updated < "2011/01/16"
         * <li>updated > "20011/01/01" and updated < "2011/02/01"
         */
        public static readonly EField UPDATED = new EField("updated", EFieldType.DATE);

        /**
         * Issues for which a particular user has voted.
         * <p>Examples:
         * <li>voter = "jsmith"
         */
        public static readonly EField VOTER = new EField("voter", EFieldType.USER);

        /**
         * Issues with a specified number of votes.
         * <p>Examples:
         * <li>votes >= 12
         */
        public static readonly EField VOTES = new EField("votes", EFieldType.NUMBER);

        /**
         * Issues that a particular user is watching.
         * <p>Examples:
         * <li>watcher = "jsmith"
         */
        public static readonly EField WATCHER = new EField("watcher", EFieldType.USER);

        /**
         * Issues with a specified number of watchers.
         * <p>Examples:
         * <li>watchers > 3
         */
        public static readonly EField WATCHERS = new EField("watchers", EFieldType.NUMBER);

        /**
         * <i>Only available if time-tracking has been enabled by your JIRA administrator.</i>
         * <p>Issues where the Work Ratio has a particular value.</p>
         * Work Ratio is calculated as follows: workRatio = timeSpent / originalEstimate) x 100
         * <p>Examples:
         * <li>workRatio > 75
         */
        public static readonly EField WORK_RATIO = new EField("workRatio", EFieldType.NUMBER);

        /** <i>Avaiable Transitions for the Issue</i>
         *  <p>an Issue has several Transition to which the status can change.</p>
         */
        public static readonly EField TRANSITIONS = new EField("transitions", EFieldType.CUSTOM_TYPE);


        /** <i>Avaiable changelog for an Issue</i>
         */
        public static readonly EField CHANGELOG = new EField("changelog", EFieldType.CUSTOM_TYPE);

        /** <i>Renders the Description Markup to HTML</i>
         */
        public static readonly EField RENDEREDFIELDS = new EField("renderedFields", EFieldType.CUSTOM_TYPE);


        public string field { get; private set; }

        public EFieldType type { get; private set; }

        private EField(string field, EFieldType type)
        {
            this.field = field;
            this.type = type;
        }

        public override string ToString() 
        {
            return field;
        }
    }
}
