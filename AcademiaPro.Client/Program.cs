using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AcademiaPro.Client;
using AcademiaPro.Client.HttpRepository.Contracts;
using AcademiaPro.Client.HttpRepository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IClassHttpRepository, ClassHttpRepository>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44320/api/") });

await builder.Build().RunAsync();
