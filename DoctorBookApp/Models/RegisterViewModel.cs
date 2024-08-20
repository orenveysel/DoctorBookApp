using DoctorBookApp.BL.Manager.Concrete;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.WebMvc.Models
{
    public class RegisterViewModel : IdentityUser
    {
        [Required]
        [Display(Name = "National ID")]
        [Range(10000000000, 99999999999, ErrorMessage = "National ID must be 11 digits.")]
        public long NationalId { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DateNotInFuture(ErrorMessage = "Birth date cannot be in the future.")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [Range(1000000000, 9999999999, ErrorMessage = "Phone number must be 10 digits.")]
        public long PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}



