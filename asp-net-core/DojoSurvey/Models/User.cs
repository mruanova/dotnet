using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class User
    {
        [Required(ErrorMessage = "Required")]
        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Your Username:")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Range(1, 100)]
        // [Range(0 , double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int Age { get; set; }

        // [Required]
        // [Display(Name = "Re-type Password")]
        // [Compare(CompareField = Password, ErrorMessage = "Passwords do not match")]
        // public string PasswordConfirm { get; set; }
    }
}
