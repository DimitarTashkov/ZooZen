using System;
using System.ComponentModel.DataAnnotations;

using static ZooZen.Common.Constants.ValidationConstants.UserConstants;
using static ZooZen.Common.Messages.ErrorMessages.UserMessages;

namespace ZooZen.DTOs.User
{
    public class EditProfileInputModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = UsernameIsRequired)]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [MaxLength(NameMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(NameMaxLength)]
        public string? LastName { get; set; }

        [MaxLength(PhoneMaxLength)]
        public string? Phone { get; set; }

        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }
    }
}
