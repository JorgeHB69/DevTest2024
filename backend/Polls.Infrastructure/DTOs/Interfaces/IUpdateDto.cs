using backend.Entities.Interfaces;

namespace Polls.Infrastructure.DTOs.Interfaces;

public interface IUpdateDto<T> where T : IEntity
{
    T FromEntity(T entity);
}