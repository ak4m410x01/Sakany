using Microsoft.AspNetCore.Identity;
using Sakany.Domain.Enumerations.Users;
using Sakany.Domain.IdentityEntities;

namespace Sakany.Persistence.DataSeeding.Security.Users
{
    public static class UsersDataSeeding
    {
        private static async Task InitializeSuperAdminsAsync(this UserManager<ApplicationUser> userManager)
        {
            var superAdmin = new ApplicationUser()
            {
                Email = "superadmin@ecommerceapi.com",
                UserName = "superadmin"
            };

            await userManager.CreateAsync(superAdmin, "P@ssw0rd");
            await userManager.AddToRoleAsync(superAdmin, UserRole.SuperAdmin.ToString());
        }

        private static async Task InitializeAdminsAsync(this UserManager<ApplicationUser> userManager)
        {
            var admin = new ApplicationUser()
            {
                UserName = "admin",
                Email = "admin@ecommerceapi.com"
            };

            await userManager.CreateAsync(admin, "P@ssw0rd");
            await userManager.AddToRoleAsync(admin, UserRole.Admin.ToString());
        }

        public static async Task InitializeUsersDataSeedingAsync(this UserManager<ApplicationUser> userManager)
        {
            await userManager.InitializeAdminsAsync();
            await userManager.InitializeSuperAdminsAsync();
        }
    }
}