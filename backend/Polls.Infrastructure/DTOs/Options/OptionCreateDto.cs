using backend.Entities.Concretes;
using Polls.Infrastructure.DTOs.Interfaces;

namespace Polls.Infrastructure.DTOs.Options;

public class OptionCreateDto : ICreateDto<Option>
{
    public required uint Index { get; set; }
    public required string Name { get; set; }
    public required uint Votes { get; set; }

    public Option ToEntity()
    {
        return new Option
        {
            Index = Index,
            Name = Name,
            Votes = Votes,
            Id = Guid.NewGuid(),
            IsActive = true,
            CreatedAt = DateTime.Now
        };
    }
}