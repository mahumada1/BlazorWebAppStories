using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StoriesWebApp.Client;
using StoriesWebApp.Client.Configuracion;
using StoriesWebApp.Client.Servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IStoriesService, StoriesService>();

var paginationConfig = new PaginationConfig();
builder.Configuration.GetSection("Pagination").Bind(paginationConfig);
builder.Services.AddSingleton(paginationConfig);

await builder.Build().RunAsync();

