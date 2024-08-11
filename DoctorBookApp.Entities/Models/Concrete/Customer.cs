using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Customer : Person
    {
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public int NationalId { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
