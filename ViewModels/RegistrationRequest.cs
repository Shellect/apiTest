using System.ComponentModel.DataAnnotations;

namespace ApiTest.ViewModels
{
    public class RegistrationRequest
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Login is required")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Birth date is required field")]
        public string? BirthDay { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        public string? Password { get; set; }

        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
    }
}