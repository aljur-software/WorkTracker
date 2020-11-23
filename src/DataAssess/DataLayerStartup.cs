using Core.Abstractions.Repositories;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public static class DataLayerStartup
    {
        public static void AddDatalayer(this IServiceCollection services)
        {
            services.AddTransient<IRX_JobRepository, RX_JobRepository>();
        }
    }
}