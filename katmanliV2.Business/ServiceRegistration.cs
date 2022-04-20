using katmanliV2.Business.Abstract;
using katmanliV2.Business.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace katmanliV2.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessRegistration(this IServiceCollection services)
        {
            services.AddScoped<ILessonService, LessonService>();
            return services;
        }

    }
}
