using DataLayer.Repositories;

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