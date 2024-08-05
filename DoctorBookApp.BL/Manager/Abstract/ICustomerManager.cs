using DoctorBookApp.Entities.Models.Concrete;

namespace DoctorBookApp.BL.Manager.Abstract
{
    public interface ICustomerManager : IManagerBase<Customer>
    {
        Customer IsThereAnyCustomer(int nationalId);

        int CreateCustomer(Customer customer);
    }
}
