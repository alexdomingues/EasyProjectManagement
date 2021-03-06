using EasyProjectManagement.Client;
using EasyProjectManagement.Client.Helpers;
using EasyProjectManagement.Client.Repository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace EasyProjectManagement.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientnService>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}