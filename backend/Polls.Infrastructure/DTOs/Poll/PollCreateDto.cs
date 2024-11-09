using backend.Entities.Concretes;
using Polls.Infrastructure.DTOs.Interfaces;
using Polls.Infrastructure.DTOs.Options;

namespace Polls.Infrastructure.DTOs.Poll;

public class PollCreateDto : ICreateDto<backend.Entities.Concretes.Poll>
{
    public required string Name { get; set; }
    public required ICollection<OptionCreateDto> Options { get; set; }
    
    public backend.Entities.Concretes.Poll ToEntity()
    {
        var options = Options.Select(o => o.ToEntity()).ToList();
        return new backend.Entities.Concretes.Poll
        {
            Name = Name,
            Options = options,
            Id = Guid.NewGuid(),
            IsActive = true,
            CreatedAt = DateTime.Now
        };
    }
}