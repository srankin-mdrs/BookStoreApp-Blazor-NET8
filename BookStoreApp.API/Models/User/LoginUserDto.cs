using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.User
{
    public class LoginUserDto 
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
