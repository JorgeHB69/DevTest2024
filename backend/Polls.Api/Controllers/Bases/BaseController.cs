using AutoMapper;
using backend.Entities.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Polls.Api.Controllers.Interfaces;
using Polls.Infrastructure.DTOs.Interfaces;
using Polls.Infrastructure.Repositories.Interfaces;

namespace Polls.Api.Controllers.Bases;

[ApiController]
[Route("api/v1/[controller]")]
public class BaseController<T, TCreate, TUpdate>(IRepository<T> repository, AbstractValidator<T> validator) : ControllerBase, IController<T, TCreate, TUpdate> 
    where T : IEntity
    where TCreate : ICreateDto<T>
    where TUpdate : IUpdateDto<T>
{
    [HttpGet]
    public ActionResult<ICollection<T>> GetAll()
    {
        var response = repository.GetAll();
        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<T?> GetById(Guid id)
    {
        var response = repository.GetById(id);
        if (response == null) return NotFound();
        return Ok(response);
    }

    [HttpPost]
    public ActionResult<T> Create(TCreate createDto)
    {
        var entity = createDto.ToEntity();

        var result = validator.Validate(entity);

        if (!result.IsValid)
        {
            return BadRequest(result.Errors);
        }
            
        var response = repository.Create(entity); 
        return Ok(response);
    }

    [HttpPut("{id}")]
    public ActionResult<bool> Update(Guid id, TUpdate updateDto)
    {
        var entity = repository.GetById(id);
        
        if (entity == null) return NotFound();
        
        var result = validator.Validate(entity);

        if (!result.IsValid)
        {
            return BadRequest(result.Errors);
        }
        
        var response = repository.Update(id, updateDto.FromEntity(entity));
        if (!response) return BadRequest();
        return Ok(response);
    }

    [HttpDelete]
    public ActionResult<bool> Delete(Guid id)
    {
        var entity = repository.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        entity.IsActive = false;
        var response = repository.Update(id, entity);
        if (!response) return BadRequest();
        return Ok();
    }
}