using Microsoft.Extensions.DependencyInjection;
using Sakany.Infrastructure.Extensions.Authentication;
using Sakany.Infrastructure.Extensions.Media;

namespace Sakany.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddTokenService();
            services.AddAuthenticationService();
            services.AddMediaService();
            return services;
        }
    }
}