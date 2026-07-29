using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Content.Server.Administration;

public sealed partial class AdminApiHelpers : IPostInjectInit
{
    [Dependency] private ILogManager _log = default!;

    private static HttpClient _httpClient = new HttpClient();
    private static ISawmill _sawmill = default!;

    public void PostInject()
    {
        _sawmill = _log.GetSawmill("admin.api");
    }

    public static async Task<string> GetCreatedTime(string userid)
    {
        var url = $"https://auth.spacestation14.com/api/query/userid?userid={userid}";

        try
        {
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                _sawmill.Warning($"Request failed for userid {userid}: {response.StatusCode}");
                return $"Request failed for userid{userid}: {response.StatusCode}";
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonDocument = JsonDocument.Parse(jsonResponse);

            if (jsonDocument.RootElement.TryGetProperty("createdTime", out var createdTimeElement) &&
                createdTimeElement.ValueKind != JsonValueKind.Null &&
                createdTimeElement.ValueKind != JsonValueKind.Undefined)
            {
                var createdTime = createdTimeElement.GetString();
                if (!string.IsNullOrEmpty(createdTime))
                {
                    var dateObj = DateTimeOffset.Parse(createdTime);
                    return dateObj.ToString("dd.MM.yyyy");
                }
            }

            _sawmill.Warning($"Missing createdTime element for userid {userid}");
            return $"Missing createdTime element for userid {userid}";
        }
        catch (HttpRequestException httpEx)
        {
            _sawmill.Warning($"HTTP error for userid {userid}: {httpEx.Message}");
            return $"HTTP error for userid {userid}: {httpEx.Message}";
        }
        catch (JsonException jsonEx)
        {
            _sawmill.Warning($"JSON parsing error for userid {userid}: {jsonEx.Message}");
            return $"Error while parsing JSON: {jsonEx.Message}";
        }
        catch (FormatException formatEx)
        {
            _sawmill.Warning($"Invalid date format for userid {userid}: {formatEx.Message}");
            return $"Invalid date format for userid {userid}: {formatEx.Message}";
        }
        catch (Exception ex)
        {
            _sawmill.Warning($"Unexpected error for userid {userid}: {ex.Message}");
            return $"Exception error for userid {userid}: {ex.Message}";
        }
    }
}
