﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Sakany.Domain.IdentityEntities;
using Sakany.Persistence.DbContexts;

namespace Sakany.Persistence.Extensions.Identity
{
    internal static class IdentityServiceCollection
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            // Identity Configuration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddUserManager<UserManager<ApplicationUser>>()
                    .AddRoleManager<RoleManager<IdentityRole>>()
                    .AddEntityFrameworkStores<SakanyDbContext>()
                    .AddDefaultTokenProviders();
            return services;
        }
    }
}