using System.ComponentModel.DataAnnotations;

using static ZooZen.Common.Constants.ValidationConstants.UserConstants;
using static ZooZen.Common.Messages.ErrorMessages.UserMessages;

namespace ZooZen.DTOs.User
{
    public class LoginUserInputModel
    {
        [Required(ErrorMessage = UsernameIsRequired)]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = PasswordIsRequired)]
        [MinLength(PasswordMinLength)]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;
    }
}
