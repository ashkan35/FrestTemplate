using FrestTemplate;
using FrestTemplate.Infradtructure;
using FrestTemplate.Infradtructure.JsServices.SweetAlert;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ISweetAlertService, SweetAlertService>();
builder.Services.AddScoped(sp => new HttpClient ());
await builder.Build().RunAsync();
