using System.Collections.Generic;

namespace JiraRestClient.Net.Jql
{
    public class EFieldType
    {
        public static readonly EFieldType Version = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN,
            EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);
        
        public static readonly EFieldType User = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS,
            EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT,
            EOperator.WAS_NOT_IN, EOperator.CHANGED);

     
        public static readonly EFieldType Category = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

     
        public static readonly EFieldType Text = new EFieldType(EOperator.CONTAINS, EOperator.DOES_NOT_CONTAIN,
            EOperator.IS, EOperator.IS_NOT);

      
        public static readonly EFieldType Component = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

     
        public static readonly EFieldType Date = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);

    
        public static readonly EFieldType Filter =
            new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IN, EOperator.NOT_IN);

       
        public static readonly EFieldType Issue = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);


        public static readonly EFieldType SecurityLevel = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        public static readonly EFieldType Duration = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT);


        public static readonly EFieldType Priority = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN,
            EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

        public static readonly EFieldType Project = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS,
            EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        public static readonly EFieldType Resolution = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.LESS_THAN, EOperator.LESS_THAN_EQUALS, EOperator.IN, EOperator.NOT_IN, EOperator.GREATER_THAN,
            EOperator.GREATER_THAN_EQUALS, EOperator.IS, EOperator.IS_NOT, EOperator.WAS, EOperator.WAS_IN,
            EOperator.WAS_NOT, EOperator.WAS_NOT_IN, EOperator.CHANGED);

 
        public static readonly EFieldType Number = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS,
            EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);


        public static readonly EFieldType Status = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS, EOperator.IS,
            EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN, EOperator.WAS, EOperator.WAS_IN, EOperator.WAS_NOT,
            EOperator.WAS_NOT_IN, EOperator.CHANGED);


        public static readonly EFieldType TextMaster = new EFieldType(EOperator.CONTAINS);


        public static readonly EFieldType IssueType = new EFieldType(EOperator.EQUALS, EOperator.NOT_EQUALS,
            EOperator.IS, EOperator.IS_NOT, EOperator.IN, EOperator.NOT_IN);

        public static readonly EFieldType CustomType;
        
        public List<EOperator> SupportedOperators { get; private set; }

        public EFieldType(params EOperator[] values)
        {
            SupportedOperators = new List<EOperator>(values);
        }
    }
}