using BlazorAppCA3;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Headers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
{
    var client = new HttpClient { BaseAddress = new Uri("https://api.api-ninjas.com/v1/") };
    client.DefaultRequestHeaders.Add("X-Api-Key", "IVt7a6ouh1jiTKWaHvejvQ==aD8HedXtojuDwxwv");
    return client;
});


await builder.Build().RunAsync();

