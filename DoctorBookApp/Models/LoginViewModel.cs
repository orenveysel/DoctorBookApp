using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.WebMvc.Models
{
    public class LoginViewModel
    {
        [Display(Name = "National ID")]
        [Range(10000000000, 99999999999, ErrorMessage = "National ID must be 11 digits.")]
        public long NationalId { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}

