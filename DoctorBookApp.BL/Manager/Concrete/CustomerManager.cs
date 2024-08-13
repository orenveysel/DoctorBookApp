using DoctorBookApp.BL.Manager.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;

namespace DoctorBookApp.BL.Manager.Concrete
{
    public class DateNotInFutureAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date > DateTime.Now)
                {
                    return new ValidationResult("Birth date cannot be in the future.");
                }
            }
            return ValidationResult.Success;
        }
    }

    public class DateNotInPastAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date < DateTime.Now)
                {
                    return new ValidationResult("Birth date cannot be in the past.");
                }
            }
            return ValidationResult.Success;
        }
    }

    public class CustomerManager : ManagerBase<Customer>, ICustomerManager
    {
        private readonly IServiceProvider _serviceProvider;

        public CustomerManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public int CreateCustomer(Customer customer)
        {
            var newCustomer = base.Insert(customer);
            var idProperty = typeof(Customer).GetProperty("Id");
            if (idProperty != null)
            {
                return (int)idProperty.GetValue(newCustomer);
            }
            return 0;
        }

        public Customer IsThereAnyCustomer(int nationalId)
        {
            var customerManager = _serviceProvider.GetService<ICustomerManager>();
            return customerManager?.IsThereAnyCustomer(nationalId);
        }
    }
}


//using DoctorBookApp.BL.Manager.Abstract;
//using DoctorBookApp.Entities.Models.Concrete;

//namespace DoctorBookApp.BL.Manager.Concrete
//{
//    public class CustomerManager : ManagerBase<Customer>, ICustomerManager
//    {
//        private readonly ICustomerManager _manager;

//        public CustomerManager(ICustomerManager manager)
//        {
//            _manager = manager;
//        }

//        public int CreateCustomer(Customer customer)
//        {
//            var newCustomer = base.Insert(customer);
//            var idProperty = typeof(Customer).GetProperty("Id");
//            if (idProperty != null)
//            {
//                return (int)idProperty.GetValue(newCustomer);
//            }
//            return 0;
//        }

//        public Customer IsThereAnyCustomer(int nationalId)
//        {
//            var customer = _manager.IsThereAnyCustomer(nationalId);

//            return customer;
//        }
//    }
//}
