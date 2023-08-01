using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Application
{
    public static class BaseApplicationConfiguration
    {
        public static void ConfigureBaseApplication(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseApplication<,>), typeof(BaseApplication<,>));
        }
    }
}