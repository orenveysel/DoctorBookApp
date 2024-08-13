using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.WebMvc.Models
{
    public class RegisterViewModel
    {
        [Range(10000000000, 99999999999, ErrorMessage = "National ID must be 11 digits.")]
        public long NationalId { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        [Range(1000000000, 9999999999, ErrorMessage = "Phone number must be 10 digits.")]
        public long PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}



