using System.Text.Json.Serialization;

namespace VriesAlert.Models;

public class PlaceResponse
{
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }
}

public class Address
{
    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("town")]
    public string? Town { get; set; }

    [JsonPropertyName("village")]
    public string? Village { get; set; }
    
    [JsonPropertyName("hamlet")]
    public string? Hamlet { get; set; }
    
    [JsonPropertyName("suburb")]
    public string? Suburb { get; set; }

    public string GetDisplayName()
    {
        return City ?? Town ?? Village ?? Hamlet ?? Suburb ?? "Onbekende locatie";
    }
}
