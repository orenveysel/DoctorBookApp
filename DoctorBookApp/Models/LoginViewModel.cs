using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.WebMvc.Models
{
    public class LoginViewModel
    {
        [Range(10000000000, 99999999999, ErrorMessage = "National ID must be 11 digits.")]
        public long NationalId { get; set; }
        public string Password { get; set; }
    }
}

