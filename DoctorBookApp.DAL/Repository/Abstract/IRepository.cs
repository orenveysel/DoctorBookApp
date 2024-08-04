using DoctorBookApp.Entities.Models.Abstract;
using System.Linq.Expressions;

namespace DoctorBookApp.DAL.Repository.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        public int Insert(T input);
        public int Update(T input);
        public int Delete(T input);
        public int DeleteById(int id);
        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null);
        public T? GetById(int id);

        public T? Get(Expression<Func<T, bool>> predicate = null);

        IQueryable<T> GetAllInclude(Expression<Func<T, bool>>? predicate,
           params Expression<Func<T, object>>[] include);
    }
}
