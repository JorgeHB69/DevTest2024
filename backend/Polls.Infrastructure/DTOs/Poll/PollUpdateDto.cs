using backend.Entities.Concretes;
using Polls.Infrastructure.DTOs.Interfaces;

namespace Polls.Infrastructure.DTOs.Poll;

public class PollUpdateDto : IUpdateDto<backend.Entities.Concretes.Poll>
{
    public required ICollection<Option> Options { get; set; }

    public backend.Entities.Concretes.Poll FromEntity(backend.Entities.Concretes.Poll entity)
    {
        return new backend.Entities.Concretes.Poll
        {
            Name = entity.Name,
            Options = Options,
            Id = entity.Id,
            IsActive = entity.IsActive,
            CreatedAt = entity.CreatedAt
        };

    }
}