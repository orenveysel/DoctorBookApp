using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Doctor : Person
    {
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
