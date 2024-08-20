using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.WebMvc.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        //public string? StreetAddress { get; set; }
        //public string? City { get; set; }
        //public string? State { get; set; }
        //public string? PostalCode { get; set; }
        [Required]
        public long NationalId { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }
        //public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
