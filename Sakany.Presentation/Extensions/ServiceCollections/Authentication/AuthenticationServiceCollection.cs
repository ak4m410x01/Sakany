using Microsoft.Extensions.Options;
using Sakany.Presentation.Extensions.ServiceCollections.Authentication.Options;
using Sakany.Shared.Helpers.JwtSettings;

namespace Sakany.Presentation.Extensions.ServiceCollections.Authentication
{
    public static class AuthenticationServiceCollection
    {
        public static IServiceCollection AddAuthenticationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthenticationOptions()
                    .AddJwtBearerOptions(configuration);

            services.Configure<JwtSettings>(configuration.GetSection("Jwt"));
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<JwtSettings>>().Value);

            return services;
        }
    }
}