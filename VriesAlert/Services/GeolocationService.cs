using Microsoft.JSInterop;
using VriesAlert.Models;

namespace VriesAlert.Services;

public class GeolocationService
{
    private readonly IJSRuntime _jsRuntime;

    public GeolocationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<GeoLocation> GetCurrentPosition()
    {
        return await _jsRuntime.InvokeAsync<GeoLocation>("window.vriesAlert.getGeolocation");
    }
}
