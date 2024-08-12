using System.Text.Json.Serialization;

namespace Employees_SII_G.DataAccess;

public class ApiResponse<T>
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("data")]
    public T Data { get; set; } = default!;
}