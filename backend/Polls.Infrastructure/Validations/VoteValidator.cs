using backend.Entities.Concretes;
using FluentValidation;

namespace Polls.Infrastructure.Validations;

public class VoteValidator : AbstractValidator<Vote>
{
    public VoteValidator()
    {
        RuleFor(v => v.OptionId).NotNull().NotEmpty();
        RuleFor(v => v.Email)
            .Matches(@"^(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$")
            .WithMessage("Invalid email format");
    }
}