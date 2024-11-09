using backend.Entities.Interfaces;

namespace Polls.Infrastructure.DTOs.Interfaces;

public interface ICreateDto<out T> where T : IEntity
{
    T ToEntity();
}