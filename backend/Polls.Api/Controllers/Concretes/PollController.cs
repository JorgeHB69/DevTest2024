using AutoMapper;
using backend.Entities.Concretes;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Polls.Api.Controllers.Bases;
using Polls.Infrastructure.DTOs.Poll;
using Polls.Infrastructure.Repositories.Interfaces;

namespace Polls.Api.Controllers.Concretes;

public class PollController(
    IRepository<Poll> _repository,
    AbstractValidator<Poll> validator,
    AbstractValidator<Vote> voteValidator
    ) : BaseController<Poll, PollCreateDto, PollUpdateDto>(_repository, validator)
{
    [HttpPost("{id}/votes")]
    public ActionResult<bool> Vote(Guid id, Vote vote)
    {
        var result = voteValidator.Validate(vote);
        if (!result.IsValid)
        {
            return BadRequest(result.Errors);
        }

        var response = _repository.GetById(id);
        if (response == null) return NotFound();
        var option = response.Options.FirstOrDefault(o => o.Index == vote.OptionId);
        option.Votes += 1;

        var newOptions = response.Options.Where(o => o.Index != vote.OptionId).ToList();
        newOptions.Add(option);

        response.Options = newOptions;

        return Ok(_repository.Update(id, response));
    }
}