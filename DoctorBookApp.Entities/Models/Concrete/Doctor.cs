using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Doctor : BaseEntity
    {
        public string FullName { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
