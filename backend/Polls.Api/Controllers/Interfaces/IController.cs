using backend.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Polls.Infrastructure.DTOs.Interfaces;

namespace Polls.Api.Controllers.Interfaces;

public interface IController<T, TCreate, TUpdate> 
    where T : IEntity
    where TCreate : ICreateDto<T>
    where TUpdate : IUpdateDto<T>
{
    ActionResult<ICollection<T>> GetAll();
    ActionResult<T?> GetById(Guid id);
    ActionResult<T> Create(TCreate createDto);
    ActionResult<bool> Update(Guid id, TUpdate updateDto);
    ActionResult<bool> Delete(Guid id);
}