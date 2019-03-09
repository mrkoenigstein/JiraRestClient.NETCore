using System.Collections.Generic;

namespace Cschulc.Jira.Jql
{
    public class EFieldType
    {
        /*
     * The version.
     */
        public static readonly EFieldType VERSION = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        /**
         * The user.
         */
        public static readonly EFieldType USER = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        /**
         * The category.
         */
        public static readonly EFieldType CATEGORY = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The text.
         */
        public static readonly EFieldType TEXT = new EFieldType(EOperator.CONTAINS, EOperator.DOES_NOT_CONTAIN, EOperator.IS, EOperator.IS_NOT);

        /**
         * The component.
         */
        public static readonly EFieldType COMPONENT = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The date.
         */
        public static readonly EFieldType DATE = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);

        /**
         * The filter.
         */
        public static readonly EFieldType FILTER = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IN, EOperator.NOT_IN);

        /**
         * The issue.
         */
        public static readonly EFieldType ISSUE = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);

        /**
         * The security level.
         */
        public static readonly EFieldType SECURITY_LEVEL = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The duration.
         */
        public static readonly EFieldType DURATION = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);

        /**
         * The priority.
         */
        public static readonly EFieldType PRIORITY = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        /**
         * The project.
         */
        public static readonly EFieldType PROJECT = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The resolution.
         */
        public static readonly EFieldType RESOLUTION = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN, EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        /**
         * The number.
         */
        public static readonly EFieldType NUMBER = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The status.
         */
        public static readonly EFieldType STATUS = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        /**
         * The text master.
         */
        public static readonly EFieldType TEXT_MASTER = new EFieldType(EOperator.CONTAINS);

        /**
         * The issue type.
         */
        public static readonly EFieldType ISSUE_TYPE = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        /**
         * The custom type.
         */
        public static readonly EFieldType CUSTOM_TYPE;


        public List<EOperator> supportedOperators { get; private set; }

        public EFieldType(params EOperator[] values)
        {
            supportedOperators = new List<EOperator>(values);
        }
    }

}
