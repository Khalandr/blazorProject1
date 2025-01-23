using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEaseApp;
using EventEaseApp.Services;

using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredLocalStorage(); // Register the LocalStorage service
builder.Services.AddScoped<UserSessionService>(); // Register the UserSessionService
builder.RootComponents.Add<App>("#app");

// Build and initialize the app
var app = builder.Build();

// Initialize the UserSessionService to load session state
var sessionService = app.Services.GetRequiredService<UserSessionService>();
await sessionService.InitializeAsync(); // Ensure session state is loaded

await app.RunAsync();
