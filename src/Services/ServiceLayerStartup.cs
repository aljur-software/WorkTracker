using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
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
