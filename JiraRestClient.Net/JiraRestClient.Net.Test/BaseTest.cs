using System;

namespace JiraRestClient.Net.Test;

public abstract class BaseTest
{
    protected readonly Uri Uri = new("https://sma.atlassian.net");

    protected const string AccountId = "5ccaa3a43252b611c8ec161a";

    protected const string Username = "christian.schulze@sma.de";

    protected const string Password = "ATATT3xFfGF0qVQ9EOgJLEyyh2ip9sTbeYlZwXTVlbLO9KT0u0JvZNQ6nBAhfs-HGC2eaKB7EKg8mLP7FR129mP41qBNF42A_ivRYtpVXjp3Hc95tP6yhq_7XWNVLmoCHoAzsqkWLnq3OooN0ClSyjl7MPw4kEaHU5gOXXkYRZKm1ZtUcxyzQXI=05F7C8F6";

    protected const string ProjectKey = "UITEST";

    protected const string IssueKeyToSearch = "UITEST-1420";

    protected readonly JiraRestClient RestClient;
    
    protected Uri BaseUri;

    public BaseTest(){
        RestClient =  new JiraRestClient(Uri, Username, Password);
        BaseUri = RestClient.BaseUri;
    }
}