namespace backend.Entities.Interfaces;

public interface IEntity
{
    Guid Id { get; set; }
    bool IsActive { get; set; }
    DateTime CreatedAt { get; set; }
}