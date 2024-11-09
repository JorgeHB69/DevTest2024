using AutoMapper;
using backend.Entities.Concretes;
using FluentValidation;
using Polls.Api.Controllers.Bases;
using Polls.Infrastructure.DTOs.Poll;
using Polls.Infrastructure.Repositories.Interfaces;

namespace Polls.Api.Controllers.Concretes;

public class PollController(IRepository<Poll> _repository, AbstractValidator<Poll> validator) 
    : BaseController<Poll, PollCreateDto, PollUpdateDto>(_repository, validator)
{
    
}