using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEaseApp;
using EventEaseApp.Services;


using Blazored.LocalStorage;
using EventEaseApp.Services; // Import the namespace for UserSessionService

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredLocalStorage(); // Register the LocalStorage service
builder.Services.AddScoped<UserSessionService>(); // Register the UserSessionService
builder.RootComponents.Add<App>("#app");

await builder.Build().RunAsync();
