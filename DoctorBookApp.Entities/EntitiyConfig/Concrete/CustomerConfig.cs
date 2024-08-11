using DoctorBookApp.Entities.EntitiyConfig.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorBookApp.Entities.EntitiyConfig.Concrete
{
    public class CustomerConfig : BaseConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.BirthDate).HasColumnType("date");
            builder.Property(p => p.Gender).HasMaxLength(50);
            builder.Property(p => p.NationalId)
                   .HasMaxLength(11)
                   .IsFixedLength(); // Sabit uzunluklu kimlik numaraları için

            builder.Property(p => p.PhoneNumber)
                   .HasMaxLength(10)
                   .IsFixedLength(); // Sabit uzunluklu telefon numarası formatı

            builder.Property(p => p.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Password)
                   .IsRequired()
                   .HasMaxLength(256);
        }
    }
}
