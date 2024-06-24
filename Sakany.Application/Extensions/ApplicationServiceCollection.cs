using Microsoft.Extensions.DependencyInjection;
using Sakany.Application.Extensions.AutoMapper;
using Sakany.Application.Extensions.MediatR;

namespace Sakany.Application.Extensions
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            #region Configure AutoMapper

            services.AddAutoMapperConfiguration();

            #endregion Configure AutoMapper

            #region Configure MediatR

            services.AddMediatRConfiguration();

            #endregion Configure MediatR

            return services;
        }
    }
}