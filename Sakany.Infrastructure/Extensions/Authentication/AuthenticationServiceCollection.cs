using Sakany.Application.Interfaces.Services.Authentication;
using Sakany.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Sakany.Infrastructure.Extensions.Authentication
{
    public static class AuthenticationServiceCollection
    {
        public static IServiceCollection AddAuthenticationService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAuthenticationService), typeof(AuthenticationService));
            return services;
        }
    }
}