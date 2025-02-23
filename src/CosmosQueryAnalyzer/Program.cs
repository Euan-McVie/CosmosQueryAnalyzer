using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CosmosQueryAnalyzer;
using MudBlazor.Services;
using CosmosQueryAnalyzer.Services;
using MudBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddSingleton<CosmosContainerService>();

MudGlobal.ButtonDefaults.Variant = Variant.Filled;
MudGlobal.InputDefaults.Variant = Variant.Outlined;

await builder.Build().RunAsync();
