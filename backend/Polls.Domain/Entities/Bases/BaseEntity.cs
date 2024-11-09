using backend.Entities.Interfaces;

namespace backend.Entities.Bases;

public class BaseEntity : IEntity
{
    public required Guid Id { get; set; } = Guid.NewGuid();
    public required bool IsActive { get; set; } = true;
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}