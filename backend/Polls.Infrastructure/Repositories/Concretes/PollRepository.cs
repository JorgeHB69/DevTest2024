using backend.Entities.Concretes;
using Polls.Infrastructure.Context.Interfaces;
using Polls.Infrastructure.Repositories.Bases;

namespace Polls.Infrastructure.Repositories.Concretes;

public class PollRepository(IContext<Poll> context) : BaseRepository<Poll>(context)
{
    
}