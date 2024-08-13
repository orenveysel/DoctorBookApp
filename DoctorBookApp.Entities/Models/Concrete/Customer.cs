using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Customer : Person
    {
        public long NationalId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
