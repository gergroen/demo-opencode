using System.Net.Http.Json;
using System.Text.Json;
using VriesAlert.Models;

namespace VriesAlert.Services;

public class WeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherResponse?> GetCurrentTemperature(double latitude, double longitude)
    {
        string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}&longitude={longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}&current=temperature_2m,weather_code";
        return await _httpClient.GetFromJsonAsync<WeatherResponse>(url);
    }

    public async Task<List<(double? Temp, int Code)>> GetWeatherData(List<City> cities)
    {
        if (cities == null || !cities.Any()) return new List<(double? Temp, int Code)>();

        var lats = string.Join(",", cities.Select(c => c.Latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)));
        var lons = string.Join(",", cities.Select(c => c.Longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)));

        string url = $"https://api.open-meteo.com/v1/forecast?latitude={lats}&longitude={lons}&current=temperature_2m,weather_code";

        try 
        {
            // When requesting multiple locations, Open-Meteo returns a JSON Array of objects
            var responses = await _httpClient.GetFromJsonAsync<List<WeatherResponse>>(url);
            return responses?.Select(r => (r.Current?.Temperature2m, r.Current?.WeatherCode ?? 0)).ToList() ?? new List<(double? Temp, int Code)>();
        }
        catch
        {
            return new List<(double? Temp, int Code)>();
        }
    }
}
