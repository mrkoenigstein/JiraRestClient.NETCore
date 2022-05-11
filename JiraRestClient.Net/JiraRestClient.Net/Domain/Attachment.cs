using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain;

public class Attachment
{
    [JsonPropertyName("author")]
    private User Author { get; set; }

    [JsonPropertyName("content")]
    private string Content { get; set; }

    [JsonPropertyName("created")]
    private string Created { get; set; }

    [JsonPropertyName("filename")]
    private string Filename { get; set; }

    [JsonPropertyName("id")]
    private string Id { get; set; }

    [JsonPropertyName("self")]
    private string Self { get; set; }

    [JsonPropertyName("size")]
    private string Size { get; set; }

    [JsonPropertyName("thumbmail")]
    private string Thumbnail { get; set; }
}