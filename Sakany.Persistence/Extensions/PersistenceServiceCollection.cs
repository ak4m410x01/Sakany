using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sakany.Persistence.Extensions.DbContexts;
using Sakany.Persistence.Extensions.Identity;
using Sakany.Persistence.Extensions.Specifications;

namespace Sakany.Persistence.Extensions
{
    public static class PersistenceServiceCollection
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextsConfiguration(configuration)
                    .AddIdentityConfiguration();

            services.AddSpecification();
            return services;
        }
    }
}