using Microsoft.Extensions.DependencyInjection;
using Core.Abstractions.Services;

namespace Services
{
    public static class ServiceLayerStartup
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            services.AddTransient<IJobService, JobService>();
        }
    }
}
