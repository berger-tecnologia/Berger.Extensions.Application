using Berger.Extensions.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Application
{
    public static class ApplicationServiceConfiguration
    {
        public static void ConfigureBaseApplication(this IServiceCollection services)
        {
            // Application Services
            services.AddScoped(typeof(IBaseApplication<,>), typeof(BaseApplication<,>));
        }
    }
}