using backend.Entities.Interfaces;

namespace Polls.Infrastructure.Repositories.Interfaces;

public interface IRepository<T> where T : IEntity
{
    ICollection<T> GetAll();
    T? GetById(Guid id);
    T Create(T entity);
    bool Update(Guid id, T entity);
    bool Delete(Guid id);
}