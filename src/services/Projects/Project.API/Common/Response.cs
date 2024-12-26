using System.Net;
using System.Text.Json.Serialization;

namespace Project.API.Common;

public class Response
{
    [JsonPropertyOrder(0)] public bool Success { get; set; }
    [JsonPropertyOrder(1)] public int StatusCode { get; set; } = (int)HttpStatusCode.OK;
    [JsonPropertyOrder(2)] public string? Messages { get; set; }
    [JsonPropertyOrder(3)] public object? Data { get; set; }
}
