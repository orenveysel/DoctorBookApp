using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.Entities.Models.Concrete
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        public bool IsCanceled { get; set; } = false;
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
