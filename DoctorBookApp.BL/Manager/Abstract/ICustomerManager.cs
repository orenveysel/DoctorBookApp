using DoctorBookApp.Entities.Models.Concrete;

namespace DoctorBookApp.BL.Manager.Abstract
{
    public interface ICustomerManager
    {
        Customer IsThereAnyCustomer(int nationalId);

        int CreateCustomer(Customer customer);
    }
}
