using Microsoft.Extensions.DependencyInjection;

namespace CBA.Services.Configuration
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<CountingService>();
            services.AddScoped<CountingRule1>();
            services.AddScoped<CountingRule2>();
            services.AddScoped<CountingRule3>();
            services.AddScoped<CountingRule4>();
            services.AddScoped<LogService>();
        }
    }
}