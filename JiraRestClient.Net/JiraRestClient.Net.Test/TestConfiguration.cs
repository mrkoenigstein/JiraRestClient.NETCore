using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JiraRestClient.Net.Test;

public class TestConfiguration
{
    private readonly IDictionary _properties;
    
    public Uri Uri => new(GetProperty("BaseUrl"));

    public string AccountId => GetProperty("AccountId");

    public string Username => GetProperty("Username");

    public string Password => GetProperty("Password");

    public string ProjectKey => GetProperty("ProjectKey");

    public string IssueKeyToSearch => GetProperty("IssueKeyToSearch");

    public TestConfiguration(TestContext testContext)
    {
        _properties = testContext.Properties;
    }
    
    private string GetProperty(string name)
    {
        if (_properties.Contains(name) == false)
        {
            return null;
        }

        var property = _properties[name];
        return property as string;
    }
}