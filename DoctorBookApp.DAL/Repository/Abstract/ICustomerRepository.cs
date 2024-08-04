using DoctorBookApp.DAL.Repository.Concrete;
using DoctorBookApp.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBookApp.DAL.Repository.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByNationalId(int nationalId);
    }
}
