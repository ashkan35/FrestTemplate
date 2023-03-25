using FrestTemplate;
using FrestTemplate.Infra.JsServices.SweetAlert;
using FrestTemplate.Infra;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Havit.Blazor.Components.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ISweetAlertService, SweetAlertService>();
builder.Services.AddScoped(sp => new HttpClient ());
builder.Services.AddHxServices();
await builder.Build().RunAsync();
