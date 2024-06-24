using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;

namespace Sakany.Presentation.Extensions.ServiceCollections.Authentication.Options
{
    public static class AuthenticationOptions
    {
        public static AuthenticationBuilder AddAuthenticationOptions(this IServiceCollection services)
        {
            return services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });
        }
    }
}