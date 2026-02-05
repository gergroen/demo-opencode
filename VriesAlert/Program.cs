using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VriesAlert;
using VriesAlert.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<GeolocationService>();
builder.Services.AddScoped<WeatherService>();
builder.Services.AddScoped<GeocodingService>();
builder.Services.AddScoped<NotificationService>();

await builder.Build().RunAsync();
