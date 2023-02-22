using MaskinparkBlazor;
using MaskinparkBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IMaskinparkClient, MaskinparkClient>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();
