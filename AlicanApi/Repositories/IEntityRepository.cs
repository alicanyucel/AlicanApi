using System.Linq.Expressions;

namespace AlicanApi.Repositories
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        IList<T> GetAll(Expression<Func<T, bool>>? predicate = null);
        T Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
