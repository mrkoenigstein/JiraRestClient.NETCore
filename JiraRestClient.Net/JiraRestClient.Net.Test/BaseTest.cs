using System;

namespace JiraRestClient.Net.Test;

public abstract class BaseTest
{
    protected readonly Uri Uri = new("");

    /// <summary>
    /// To get a User from the RestApi
    /// </summary>
    protected const string AccountId = "";

    protected const string Username = "";

    protected const string Password = "";

    protected const string ProjectKey = "KAN";

    protected const string IssueKeyToSearch = "KAN-1";

    protected readonly JiraRestClient RestClient;
    
    protected Uri BaseUri;

    public BaseTest(){
        RestClient =  new JiraRestClient(Uri, Username, Password);
        BaseUri = RestClient.BaseUri;
    }
}