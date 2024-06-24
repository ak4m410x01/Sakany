using Microsoft.Extensions.DependencyInjection;
using Sakany.Application.Extensions.AutoMapper;

namespace Sakany.Application.Extensions
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            #region Configure AutoMapper

            services.AddAutoMapperConfiguration();

            #endregion Configure AutoMapper

            return services;
        }
    }
}