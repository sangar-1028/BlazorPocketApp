using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPocket.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.TryAddMudBlazorUI(builder.Configuration);
builder.Services.TryAddProcketbase(builder.Configuration);
await builder.Build().RunAsync();