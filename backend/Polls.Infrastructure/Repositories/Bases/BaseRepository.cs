using backend.Entities.Interfaces;
using Polls.Infrastructure.Context.Interfaces;
using Polls.Infrastructure.Repositories.Interfaces;

namespace Polls.Infrastructure.Repositories.Bases;

public class BaseRepository<T>(IContext<T> context) : IRepository<T> where T : IEntity
{
    public ICollection<T> GetAll()
    {
        return context.GetAll();
    }

    public T? GetById(Guid id)
    {
        var response = context.GetById(id);

        return response;
    }

    public T Create(T entity)
    {
        return context.Create(entity);
    }

    public bool Update(Guid id, T entity)
    {
        return context.Update(id, entity);
    }

    public bool Delete(Guid id)
    {
        return context.Delete(id);
    }
}