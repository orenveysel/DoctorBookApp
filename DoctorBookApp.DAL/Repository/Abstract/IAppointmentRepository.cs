using DoctorBookApp.Entities.Models.Concrete;

namespace DoctorBookApp.DAL.Repository.Abstract
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        List<Appointment> GetAppointmentsByCustomerId(int id);
    }
}
