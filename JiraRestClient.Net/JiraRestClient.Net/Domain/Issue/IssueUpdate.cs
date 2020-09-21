using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JiraRestClient.Net.Domain.Issue
{
    public class IssueUpdate
    {
        [JsonPropertyName("fields")] 
        public IssueFields Fields { get; set; }
        
        [JsonPropertyName("transition")]
        public Transition Transition { get; set; }
        
        [JsonPropertyName("historyMetadata")]
        public HistoryMetadata HistoryMetadata { get; set; }
        
        [JsonPropertyName("properties")]
        public List<EntityProperty> Properties { get; set; }
    }

    public class HistoryMetadata
    {
        [JsonPropertyName("activityDescription")]
        public string ActivityDescription { get; set; }

        [JsonPropertyName("activityDescriptionKey")]
        public string ActivityDescriptionKey { get; set; }

        [JsonPropertyName("actor")]
        public HistoryMetadataParticipant Actor { get; set; }

        [JsonPropertyName("cause")]
        public HistoryMetadataParticipant Cause { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("descriptionKey")]
        public string DescriptionKey { get; set; }

        [JsonPropertyName("emailDescription")]
        public string EmailDescription { get; set; }

        [JsonPropertyName("emailDescriptionKey")]
        public string EmailDescriptionKey { get; set; }

        [JsonPropertyName("extraData")]
        public ExtraData ExtraData { get; set; }

        [JsonPropertyName("generator")]
        public HistoryMetadataParticipant Generator { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ExtraData
    {
    }

    public class HistoryMetadataParticipant
    {
        [JsonPropertyName("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("displayNameKey")]
        public string DisplayNameKey { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class EntityProperty
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}