using DoctorBookApp.Entities.EntitiyConfig.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorBookApp.Entities.EntitiyConfig.Concrete
{
    public class AppointmentConfig : BaseConfig<Appointment>
    {
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);
        }
    }
}
