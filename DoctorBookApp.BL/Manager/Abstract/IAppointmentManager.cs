using DoctorBookApp.Entities.Models.Concrete;

namespace DoctorBookApp.BL.Manager.Abstract
{
    public interface IAppointmentManager : IManagerBase<Appointment>
    {
        List<Appointment> GetAllAppointmentsByCustomerId(int id);

        int CancelAppointment(int id);
    }
}
