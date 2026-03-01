using ZooZen.DTOs.User;
using ZooZen.Models;
using ZooZen.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using ZooZen.Data;

namespace ZooZen.Services
{
    /// <summary>
    /// Service for user management in ZooZen
    /// </summary>
    public class UserService : BaseService, IUserService
    {
        private readonly ZooZenDbContext dbContext;
        private User? loggedInUser;

        public UserService(ZooZenDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.PasswordHash == password);

            if (user != null)
            {
                loggedInUser = user;
                return true;
            }

            return false;
        }

        public async Task RegisterUserAsync(RegisterUserInputModel registrationModel)
        {
            // Find the Client role
            var clientRole = await dbContext.Roles.FirstOrDefaultAsync(r => r.Name == "Client");

            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = registrationModel.Username,
                PasswordHash = registrationModel.Password,
                FirstName = registrationModel.FirstName,
                LastName = registrationModel.LastName,
                Phone = registrationModel.Phone,
                Address = registrationModel.Address,
                ProfilePicturePath = registrationModel.ProfilePicturePath
            };

            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();

            // Assign Client role to the new user
            if (clientRole != null)
            {
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = clientRole.Id
                };
                dbContext.UserRoles.Add(userRole);
                await dbContext.SaveChangesAsync();
            }
        }

        public User? GetLoggedInUserAsync()
        {
            return loggedInUser;
        }

        public async Task<bool> UpdateUserAsync(EditProfileInputModel userModel)
        {
            // Admin can edit any user; client can only edit themselves
            var user = await dbContext.Users.FindAsync(userModel.Id);
            if (user == null) return false;

            user.Username  = userModel.Username;
            user.FirstName = userModel.FirstName;
            user.LastName  = userModel.LastName;
            user.Phone     = userModel.Phone;
            user.Address   = userModel.Address;
            if (userModel.ProfilePicturePath != null)
                user.ProfilePicturePath = userModel.ProfilePicturePath;
            if (!string.IsNullOrWhiteSpace(userModel.Password))
                user.PasswordHash = userModel.Password;

            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUserAsync(Guid userId)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null) return false;

            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> IsUserAdminAsync(Guid userId)
        {
            return await dbContext.UserRoles
                .AnyAsync(ur => ur.UserId == userId && ur.Role.Name == "Admin");
        }

        public void LogoutUser()
        {
            loggedInUser = null;
        }

        public async Task<bool> IsUsernameTaken(string username)
        {
            return await dbContext.Users.AnyAsync(u => u.Username == username);
        }

        public async Task<IEnumerable<UserDataViewModel>> GetUsersAsync()
        {
            var users = await dbContext.Users
                .Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .ToListAsync();

            return users.Select(user => new UserDataViewModel
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Address = user.Address,
                IsAdmin = user.UserRoles.Any(ur => ur.Role.Name == "Admin")
            });
        }

        public async Task<bool> MakeUserAdminAsync(Guid userId)
        {
            var user = await dbContext.Users.FindAsync(userId);
            if (user == null) return false;

            var adminRole = await dbContext.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");
            if (adminRole == null) return false;

            if (dbContext.UserRoles.Any(ur => ur.UserId == userId && ur.RoleId == adminRole.Id))
                return false;

            var userRole = new UserRole
            {
                UserId = userId,
                RoleId = adminRole.Id
            };

            dbContext.UserRoles.Add(userRole);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveAdminRoleAsync(Guid userId)
        {
            var adminRole = await dbContext.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");
            if (adminRole == null) return false;

            var userRole = await dbContext.UserRoles
                .FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == adminRole.Id);

            if (userRole == null) return false;

            dbContext.UserRoles.Remove(userRole);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<User?> FindUserByIdAsync(Guid userId)
        {
            return await dbContext.Users.FindAsync(userId);
        }
    }
}
