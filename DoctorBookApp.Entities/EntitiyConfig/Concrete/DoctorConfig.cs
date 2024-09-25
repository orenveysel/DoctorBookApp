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
            builder.Property(p => p.FullName).HasMaxLength(50);
            builder.HasData(new Doctor { Id = 1, FullName = "Ali Yilmaz" });
            builder.HasData(new Doctor { Id = 2, FullName = "Ayse Ozturk" });
        }
    }
}
