using Sakany.Presentation.Extensions.Middlewares.Authorization;
using Sakany.Presentation.Extensions.ServiceCollections.ApiVersioning;
using Sakany.Presentation.Extensions.ServiceCollections.Authentication;
using Sakany.Presentation.Extensions.ServiceCollections.Cors;
using Sakany.Presentation.Extensions.ServiceCollections.Swagger;

namespace Sakany.Presentation.Extensions.ServiceCollections
{
    public static class PresentationServiceCollection
    {
        public static IServiceCollection AddPresentationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Configure Api Versioning

            services.AddApiVersioningConfiguration();

            #endregion Configure Api Versioning

            #region Configure Authentication

            services.AddAuthenticationConfiguration(configuration);

            #endregion Configure Authentication

            #region Configure Authorization

            services.AddAuthorizationConfiguration();

            #endregion Configure Authorization

            #region Configure Controllers

            services.AddControllers();

            #endregion Configure Controllers

            #region Configure Cors

            services.AddCorsConfiguration();

            #endregion Configure Cors

            #region Configure Swagger/OpenAPI

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddSwaggerConfiguration(configuration);

            #endregion Configure Swagger/OpenAPI

            return services;
        }
    }
}