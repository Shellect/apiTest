using System.ComponentModel.DataAnnotations;

namespace ApiTest.ViewModels
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        public string? Password { get; set; }
    }
}