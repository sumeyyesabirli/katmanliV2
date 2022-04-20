using katmanliV2.DataAccess.Schema.Repositories.Abstract;
using katmanliV2.DataAccess.Schema.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katmanliV2.DataAccess
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataAccessRegistration(this IServiceCollection services)
        {
            services.AddScoped<ILessonRepository, LessonRepository>();
            return services;
        }

    }
}
