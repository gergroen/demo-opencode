using Microsoft.JSInterop;

namespace VriesAlert.Services;

public class NotificationService
{
    private readonly IJSRuntime _jsRuntime;

    public NotificationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task RequestPermission()
    {
        await _jsRuntime.InvokeVoidAsync("window.vriesAlert.requestNotificationPermission");
    }

    public async Task<string> GetPermissionStatus()
    {
         return await _jsRuntime.InvokeAsync<string>("window.vriesAlert.getNotificationPermissionStatus");
    }

    public async Task ShowNotification(string title, string body)
    {
        await _jsRuntime.InvokeVoidAsync("window.vriesAlert.showNotification", title, new { body = body, icon = "icon-192.png" });
    }
}
