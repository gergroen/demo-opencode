namespace VriesAlert.Models;

public class City
{
    public string Name { get; set; } = "";
    public string CountryCode { get; set; } = ""; // Voor vlag emoji
    public string CountryName { get; set; } = ""; // Volledige naam
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
    // Helper property to get flag emoji from country code
    public string Flag => string.Concat(CountryCode.ToUpper().Select(x => char.ConvertFromUtf32(x + 0x1F1A5)));
}

public static class CapitalData
{
    public static List<City> List = new()
    {
        new City { Name = "Amsterdam", CountryCode = "NL", CountryName = "Nederland", Latitude = 52.3676, Longitude = 4.9041 },
        new City { Name = "Brussel", CountryCode = "BE", CountryName = "België", Latitude = 50.8503, Longitude = 4.3517 },
        new City { Name = "Londen", CountryCode = "GB", CountryName = "Verenigd Koninkrijk", Latitude = 51.5074, Longitude = -0.1278 },
        new City { Name = "Parijs", CountryCode = "FR", CountryName = "Frankrijk", Latitude = 48.8566, Longitude = 2.3522 },
        new City { Name = "Berlijn", CountryCode = "DE", CountryName = "Duitsland", Latitude = 52.5200, Longitude = 13.4050 },
        new City { Name = "Oslo", CountryCode = "NO", CountryName = "Noorwegen", Latitude = 59.9139, Longitude = 10.7522 },
        new City { Name = "Stockholm", CountryCode = "SE", CountryName = "Zweden", Latitude = 59.3293, Longitude = 18.0686 },
        new City { Name = "Helsinki", CountryCode = "FI", CountryName = "Finland", Latitude = 60.1695, Longitude = 24.9354 },
        new City { Name = "Kopenhagen", CountryCode = "DK", CountryName = "Denemarken", Latitude = 55.6761, Longitude = 12.5683 },
        new City { Name = "Reykjavik", CountryCode = "IS", CountryName = "IJsland", Latitude = 64.1466, Longitude = -21.9426 },
        new City { Name = "Moskou", CountryCode = "RU", CountryName = "Rusland", Latitude = 55.7558, Longitude = 37.6173 },
        new City { Name = "Warschau", CountryCode = "PL", CountryName = "Polen", Latitude = 52.2297, Longitude = 21.0122 },
        new City { Name = "Praag", CountryCode = "CZ", CountryName = "Tsjechië", Latitude = 50.0755, Longitude = 14.4378 },
        new City { Name = "Wenen", CountryCode = "AT", CountryName = "Oostenrijk", Latitude = 48.2082, Longitude = 16.3738 },
        new City { Name = "Zurich", CountryCode = "CH", CountryName = "Zwitserland", Latitude = 47.3769, Longitude = 8.5417 }, 
        new City { Name = "Bern", CountryCode = "CH", CountryName = "Zwitserland", Latitude = 46.9480, Longitude = 7.4474 },
        new City { Name = "Ottawa", CountryCode = "CA", CountryName = "Canada", Latitude = 45.4215, Longitude = -75.6972 },
        new City { Name = "Washington D.C.", CountryCode = "US", CountryName = "Verenigde Staten", Latitude = 38.9072, Longitude = -77.0369 },
        new City { Name = "New York", CountryCode = "US", CountryName = "Verenigde Staten", Latitude = 40.7128, Longitude = -74.0060 }, 
        new City { Name = "Anchorage", CountryCode = "US", CountryName = "Verenigde Staten (Alaska)", Latitude = 61.2181, Longitude = -149.9003 },
        new City { Name = "Nuuk", CountryCode = "GL", CountryName = "Groenland", Latitude = 64.1814, Longitude = -51.6941 },
        new City { Name = "Beijing", CountryCode = "CN", CountryName = "China", Latitude = 39.9042, Longitude = 116.4074 },
        new City { Name = "Tokio", CountryCode = "JP", CountryName = "Japan", Latitude = 35.6762, Longitude = 139.6503 },
        new City { Name = "Seoul", CountryCode = "KR", CountryName = "Zuid-Korea", Latitude = 37.5665, Longitude = 126.9780 },
        new City { Name = "Ulaanbaatar", CountryCode = "MN", CountryName = "Mongolië", Latitude = 47.9184, Longitude = 106.9176 },
        new City { Name = "Astana", CountryCode = "KZ", CountryName = "Kazachstan", Latitude = 51.1694, Longitude = 71.4491 },
        new City { Name = "Tallinn", CountryCode = "EE", CountryName = "Estland", Latitude = 59.4370, Longitude = 24.7535 },
        new City { Name = "Riga", CountryCode = "LV", CountryName = "Letland", Latitude = 56.9496, Longitude = 24.1052 },
        new City { Name = "Vilnius", CountryCode = "LT", CountryName = "Litouwen", Latitude = 54.6872, Longitude = 25.2797 },
        new City { Name = "Minsk", CountryCode = "BY", CountryName = "Wit-Rusland", Latitude = 53.9045, Longitude = 27.5615 },
        new City { Name = "Kiev", CountryCode = "UA", CountryName = "Oekraïne", Latitude = 50.4501, Longitude = 30.5234 },
        new City { Name = "Boedapest", CountryCode = "HU", CountryName = "Hongarije", Latitude = 47.4979, Longitude = 19.0402 },
        new City { Name = "Boekarest", CountryCode = "RO", CountryName = "Roemenië", Latitude = 44.4268, Longitude = 26.1025 },
        new City { Name = "Sofia", CountryCode = "BG", CountryName = "Bulgarije", Latitude = 42.6977, Longitude = 23.3219 },
        new City { Name = "Ankara", CountryCode = "TR", CountryName = "Turkije", Latitude = 39.9334, Longitude = 32.8597 }
    };
}
