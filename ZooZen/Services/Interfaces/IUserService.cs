using ZooZen.DTOs.User;
using ZooZen.Models;

namespace ZooZen.Services.Interfaces
{
    /// <summary>
    /// Интерфейс за управление на потребители в ZooZen
    /// </summary>
    public interface IUserService : IValidateModel
    {
        Task<bool> AuthenticateUserAsync(string username, string password);
        Task RegisterUserAsync(RegisterUserInputModel registrationModel);
        Task<bool> UpdateUserAsync(EditProfileInputModel user);
        User? GetLoggedInUserAsync();
        Task<User?> FindUserByIdAsync(Guid userId);
        Task<bool> DeleteUserAsync(Guid userId);
        void LogoutUser();
        Task<bool> IsUserAdminAsync(Guid userId);
        Task<bool> IsUsernameTaken(string username);
        Task<IEnumerable<UserDataViewModel>> GetUsersAsync();
        Task<bool> MakeUserAdminAsync(Guid userId);
        Task<bool> RemoveAdminRoleAsync(Guid userId);
    }
}
