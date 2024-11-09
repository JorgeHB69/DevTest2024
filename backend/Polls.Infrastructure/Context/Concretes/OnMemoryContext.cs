using backend.Entities.Concretes;
using Polls.Infrastructure.Context.Interfaces;

namespace Polls.Infrastructure.Context.Concretes;

public class OnMemoryContext : IContext<Poll>
{
    public ICollection<Option> Options { get; set; } = [];
    public IDictionary<Guid, Poll> Polls { get; set; } = new Dictionary<Guid, Poll>();
    
    public ICollection<Poll> GetAll()
    {
        return Polls.Values.Where(p => p.IsActive).ToList();
    }

    public Poll? GetById(Guid id)
    {
        return Polls.FirstOrDefault(p => p.Key == id).Value;
    }

    public Poll Create(Poll entity)
    {
        Polls.Add(entity.Id, entity);
        return entity;
    }

    public bool Update(Guid id, Poll entity)
    {
        var response = Polls.FirstOrDefault(p => p.Key == id).Value;
        if (response == null && entity.Id != id)
        {
            return false;
        }

        Polls[id] = entity;
        return true;
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}