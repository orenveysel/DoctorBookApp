using DoctorBookApp.Entities.EntitiyConfig.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorBookApp.Entities.EntitiyConfig.Concrete
{
    public class CustomerConfig : BaseConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(50);
        }
    }
}
