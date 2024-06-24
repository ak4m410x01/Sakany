using Microsoft.Extensions.DependencyInjection;
using Sakany.Application.Interfaces.Specifications.Base;
using Sakany.Persistence.Specifications.Base;

namespace Sakany.Persistence.Extensions.Specifications
{
    public static class SpecificationServiceCollection
    {
        public static IServiceCollection AddSpecification(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseSpecification<>), typeof(BaseSpecification<>));
            return services;
        }
    }
}