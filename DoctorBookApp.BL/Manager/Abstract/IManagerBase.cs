using DoctorBookApp.DAL.Repository.Abstract;
using DoctorBookApp.Entities.Models.Abstract;

namespace DoctorBookApp.BL.Manager.Abstract
{
    public interface IManagerBase<T> : IRepository<T> where T : BaseEntity
    {

    }
}
