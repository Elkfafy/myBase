namespace myBase.Shared;

public class BaseValidator<TEntity> : AbstractValidator<TEntity>, IValidator<TEntity> 
    where TEntity : BaseEntity
{
    public BaseValidator()
    {
        RuleFor(e => e.Id).NotEmpty();
    }
}
