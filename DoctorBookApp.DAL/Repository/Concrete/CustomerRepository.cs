using DoctorBookApp.DAL.Repository.Abstract;
using DoctorBookApp.Entities.DbContexts;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DoctorBookApp.DAL.Repository.Concrete
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        readonly AppDbContext _dbContext;
        readonly DbSet<Customer> _dbSet;
        public CustomerRepository()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<Customer>();
        }

        public Customer GetByNationalId(int nationalId)
        {
            return _dbSet.FirstOrDefault(x => x.NationalId == nationalId);
        }
    }
}
