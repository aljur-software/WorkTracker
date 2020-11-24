using DataLayer.Repositories;
using Core.Abstractions.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public static class DataLayerStartup
    {
        public static void AddDatalayer(this IServiceCollection services)
        {
            services.AddTransient<IJobRepository, JobRepository>();
        }
    }
}