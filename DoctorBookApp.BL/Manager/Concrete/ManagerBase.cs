using DoctorBookApp.BL.Manager.Abstract;
using DoctorBookApp.DAL.Repository.Concrete;
using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.BL.Manager.Concrete
{
    public class ManagerBase<T> : Repository<T>, IManagerBase<T> where T : BaseEntity
    {

    }
}
