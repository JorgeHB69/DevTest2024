using backend.Entities.Bases;

namespace backend.Entities.Concretes;

public class Poll : BaseEntity
{
    public required string Name { get; set; }
    public required ICollection<Option> Options { get; set; }
}