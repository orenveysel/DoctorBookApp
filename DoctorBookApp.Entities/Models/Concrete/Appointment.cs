using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Appointment : BaseEntity
    {
        public Guid DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
