using Microsoft.Extensions.DependencyInjection;
using Sakany.Application.Repositories.Base;
using Sakany.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakany.Persistence.Extensions.Repositories.Base
{
    public static class BaseRepositoryServiceCollection
    {
        public static IServiceCollection AddBaseRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}