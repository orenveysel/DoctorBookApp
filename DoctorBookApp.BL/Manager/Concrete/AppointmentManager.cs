using DoctorBookApp.BL.Manager.Abstract;
using DoctorBookApp.Entities.Models.Concrete;

namespace DoctorBookApp.BL.Manager.Concrete
{
    public class AppointmentManager : ManagerBase<Appointment>, IAppointmentManager
    {
        private readonly ICustomerManager _customerManager;
        public AppointmentManager(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        public override int Insert(Appointment input)
        {
            var customer  = _customerManager.IsThereAnyCustomer(input.Customer.NationalId);
            if (customer == null)
            {
                input.CustomerId = _customerManager.CreateCustomer(input.Customer);
            }
            else
            {
                input.CustomerId = customer.Id;
            }

            var doctor = base.GetById(input.Doctor.Id);
            if (doctor != null) { input.DoctorId = doctor.Id;}

            return base.Insert(input);
        }
    }
}
