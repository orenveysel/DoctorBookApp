using DoctorBookApp.Entities.EntitiyConfig.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorBookApp.Entities.EntitiyConfig.Concrete
{
    public class DoctorConfig : BaseConfig<Doctor>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.HasData(new Doctor { Id = Guid.NewGuid(), Name = "Ali", LastName = "Veli" });
        }
    }
}
