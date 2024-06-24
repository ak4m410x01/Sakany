using Sakany.Application.Interfaces.Services.Authentication;
using Sakany.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Sakany.Infrastructure.Extensions.Authentication
{
    public static class TokenServiceCollection
    {
        public static IServiceCollection AddTokenService(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITokenService), typeof(TokenService));

            return services;
        }
    }
}