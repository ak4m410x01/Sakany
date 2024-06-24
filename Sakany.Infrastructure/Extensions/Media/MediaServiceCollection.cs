using Sakany.Application.Interfaces.Services.Media;
using Sakany.Infrastructure.Services.Media;
using Microsoft.Extensions.DependencyInjection;

namespace Sakany.Infrastructure.Extensions.Media
{
    public static class MediaServiceCollection
    {
        public static IServiceCollection AddMediaService(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IMediaService), typeof(MediaService));
            return services;
        }
    }
}