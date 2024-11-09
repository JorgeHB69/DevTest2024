using AutoMapper;
using backend.Entities.Concretes;
using Polls.Infrastructure.DTOs.Poll;

namespace Polls.Infrastructure.Profiles;

public class PollProfile : Profile
{
    public PollProfile()
    {
        CreateMap<Poll, PollCreateDto>();
        CreateMap<Poll, PollUpdateDto>();
        CreateMap<PollCreateDto, Poll>();
        CreateMap<PollUpdateDto, Poll>();
    }
}