using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RestApp.Client.Services;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;
namespace RestApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTcyNzM5QDMxMzkyZTMzMmUzMFVuSFIwVjBLQ3RLYTFNTm1HNXBMak1ldDkvSFdYSlczV1o1RXQ3NERjYnc9;NTcyNzQwQDMxMzkyZTMzMmUzMFlkUk5oZ25ZakRRbkhiQjJOYkdMazhRMFJUclE0SVhZckR4a0w1aTZQcVU9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("RestApp.ServerAPI", (sp, client) =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.EnableIntercept(sp);
            })
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RestApp.ServerAPI"));


            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddScoped<HttpInterceptorService>();

            builder.Services.AddSyncfusionBlazor();

            builder.Services.AddApiAuthorization();
            await builder.Build().RunAsync();
        }
    }
}
