using System.Net.Http.Json;
using VriesAlert.Models;

namespace VriesAlert.Services;

public class GeocodingService
{
    private readonly HttpClient _httpClient;

    public GeocodingService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        // Nominatim requires a User-Agent header
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "VriesAlert-App/1.0");
    }

    public async Task<string> GetPlaceName(double latitude, double longitude)
    {
        try
        {
            string url = $"https://nominatim.openstreetmap.org/reverse?format=json&lat={latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}&lon={longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
            var response = await _httpClient.GetFromJsonAsync<PlaceResponse>(url);
            
            return response?.Address?.GetDisplayName() ?? "Onbekende locatie";
        }
        catch
        {
            return "Locatie onbekend";
        }
    }
}
