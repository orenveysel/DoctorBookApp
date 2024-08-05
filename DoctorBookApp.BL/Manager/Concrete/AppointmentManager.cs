using DoctorBookApp.BL.Manager.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorBookApp.BL.Manager.Concrete
{
    public class AppointmentManager : ManagerBase<Appointment>, IAppointmentManager
    {
        private readonly IServiceProvider _serviceProvider;

        public AppointmentManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public int CancelAppointment(int id)
        {
            var customerAppointment = base.GetById(id);
            if (customerAppointment != null)
            {
                customerAppointment.IsCanceled = true;
                return base.Insert(customerAppointment);
            }
            return 0;
        }

        public List<Appointment> GetAllAppointmentsByCustomerId(int id)
        {
            var appointmentManager = _serviceProvider.GetService<IAppointmentManager>();
            return appointmentManager?.GetAllAppointmentsByCustomerId(id);
        }

        public override int Insert(Appointment input)
        {
            var customerManager = _serviceProvider.GetService<ICustomerManager>();
            var customer = customerManager?.IsThereAnyCustomer(input.Customer.NationalId);
            if (customer == null)
            {
                input.CustomerId = customerManager.CreateCustomer(input.Customer);
            }
            else
            {
                input.CustomerId = customer.Id;
            }

            var doctor = base.GetById(input.Doctor.Id);
            if (doctor != null) { input.DoctorId = doctor.Id; }

            return base.Insert(input);
        }
    }
}


//using DoctorBookApp.BL.Manager.Abstract;
//using DoctorBookApp.Entities.Models.Concrete;

//namespace DoctorBookApp.BL.Manager.Concrete
//{
//    public class AppointmentManager : ManagerBase<Appointment>, IAppointmentManager
//    {
//        private readonly ICustomerManager _customerManager;
//        private readonly IAppointmentManager _appointmentManager;
//        public AppointmentManager(ICustomerManager customerManager, IAppointmentManager appointmentManager)
//        {
//            _customerManager = customerManager;
//            _appointmentManager = appointmentManager;
//        }

//        public int CancelAppointment(int id)
//        {
//            var customerAppointment = base.GetById(id);
//            if (customerAppointment != null)
//            {
//                customerAppointment.IsCanceled = true;
//                return base.Insert(customerAppointment);
//            }
//            return 0;
//        }

//        public List<Appointment> GetAllAppointmentsByCustomerId(int id)
//        {
//            var data = _appointmentManager.GetAllAppointmentsByCustomerId(id);
//            return data;
//        }

//        public override int Insert(Appointment input)
//        {
//            var customer  = _customerManager.IsThereAnyCustomer(input.Customer.NationalId);
//            if (customer == null)
//            {
//                input.CustomerId = _customerManager.CreateCustomer(input.Customer);
//            }
//            else
//            {
//                input.CustomerId = customer.Id;
//            }

//            var doctor = base.GetById(input.Doctor.Id);
//            if (doctor != null) { input.DoctorId = doctor.Id;}

//            return base.Insert(input);
//        }
//    }
//}
