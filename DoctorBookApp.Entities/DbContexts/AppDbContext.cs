using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DoctorBookApp.Entities.DbContexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=IstkaCompanyInfo;Trusted_Connection=true;
            //TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
