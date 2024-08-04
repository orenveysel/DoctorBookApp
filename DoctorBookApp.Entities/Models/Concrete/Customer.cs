using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Customer : Person
    {
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int NationalId { get; set; }
        public int PhoneNumber { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
