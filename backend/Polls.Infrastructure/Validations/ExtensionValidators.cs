using FluentValidation;

namespace Polls.Infrastructure.Validations;

public static class ExtensionValidators
{
    public static IRuleBuilderOptions<T, ICollection<TElement>> ListMustContainAtLeast<T, TElement>(this IRuleBuilder<T, IList<TElement>> ruleBuilder, int num) {
        return ruleBuilder.Must(list => list.Count >= num).WithMessage($"The list must contain at least {num}");
    }
}