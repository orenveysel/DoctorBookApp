using DoctorBookApp.DAL.Repository.Abstract;
using DoctorBookApp.Entities.DbContexts;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DoctorBookApp.DAL.Repository.Concrete
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        readonly AppDbContext _dbContext;
        readonly DbSet<Appointment> _dbSet;
        public AppointmentRepository()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<Appointment>();
        }

        public List<Appointment> GetAppointmentsByCustomerId(int id)
        {
            var appointments = _dbContext.Set<Appointment>().Where(x => x.CustomerId == id).ToList();
            return appointments;
        }
    }
}
