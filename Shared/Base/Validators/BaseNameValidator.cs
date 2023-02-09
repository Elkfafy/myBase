namespace myBase.Shared;

public class BaseNameValidator<TEntity> : BaseValidator<TEntity> where TEntity : BaseName
{
    public BaseNameValidator()
    {
        RuleFor(e => e.Name).NotEmpty().MaximumLength(50);
    }
}
