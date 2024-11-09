using backend.Entities.Concretes;
using FluentValidation;

namespace Polls.Infrastructure.Validations;

public class PollValidator : AbstractValidator<Poll>
{
    public PollValidator()
    {
        RuleFor(p => p.Name).NotEmpty().NotNull().Matches(@"[A-Za-z0-9\s]$");
        RuleFor(p => p.Options)
            .NotNull()
            .Must(p => p.Count >= 2)
            .WithMessage("Options requires at least 2 options");
    }
}