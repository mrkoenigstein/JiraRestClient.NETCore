using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using JiraRestClient.Net.Domain;

namespace JiraRestClient.Net.Core.Converter
{
    public class PermissionListConverter : JsonConverter<Permissions>
    {
        public override Permissions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.PropertyName:
                        break;
                    case JsonTokenType.StartObject:
                        break;
                    case JsonTokenType.None:
                        break;
                    case JsonTokenType.EndObject:
                        break;
                    case JsonTokenType.StartArray:
                        break;
                    case JsonTokenType.EndArray:
                        break;
                    case JsonTokenType.Comment:
                        break;
                    case JsonTokenType.String:
                        break;
                    case JsonTokenType.Number:
                        break;
                    case JsonTokenType.True:
                        break;
                    case JsonTokenType.False:
                        break;
                    case JsonTokenType.Null:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return new Permissions();
        }

        public override void Write(Utf8JsonWriter writer, Permissions value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}