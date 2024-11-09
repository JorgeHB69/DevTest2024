using backend.Entities.Bases;

namespace backend.Entities.Concretes;

public class Option : BaseEntity
{
    public required uint Index { get; set; }
    public required string Name { get; set; }
    public required uint Votes { get; set; }
}