using Microsoft.EntityFrameworkCore;
using ZooZen.Data;

namespace ZooZen.Models.DbConfiguration
{
    /// <summary>
    /// Seeds the initial admin account on first startup
    /// </summary>
    public static class SeedAdmin
    {
        public static async Task SeedAdminUserAsync()
        {
            using (var context = new ZooZenDbContext())
            {
                // Create the database if it doesn't exist
                await context.Database.EnsureCreatedAsync();

                var adminRole = await context.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");

                if (adminRole == null)
                {
                    adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin" };
                    context.Roles.Add(adminRole);
                    await context.SaveChangesAsync();
                }

                // Create Client role if it doesn't exist
                var clientRole = await context.Roles.FirstOrDefaultAsync(r => r.Name == "Client");
                if (clientRole == null)
                {
                    clientRole = new Role { Id = Guid.NewGuid(), Name = "Client" };
                    context.Roles.Add(clientRole);
                    await context.SaveChangesAsync();
                }

                var existingAdmin = await context.Users.FirstOrDefaultAsync(u => u.Username == "admin");

                if (existingAdmin == null)
                {
                    var adminUser = new User
                    {
                        Id = Guid.NewGuid(),
                        Username = "admin",
                        PasswordHash = "admin123",
                        FirstName = "Administrator",
                        LastName = "ZooZen",
                        Phone = "0888000000",
                        Address = "Sofia, Bulgaria"
                    };

                    context.Users.Add(adminUser);
                    await context.SaveChangesAsync();

                    var adminUserRole = new UserRole
                    {
                        UserId = adminUser.Id,
                        RoleId = adminRole.Id
                    };

                    context.UserRoles.Add(adminUserRole);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
