namespace myBase.Shared;

public class EmployeeValidator<TEntity> : AbstractValidator<TEntity>, IValidator<TEntity>
    where TEntity : Employee
{
    public EmployeeValidator()
    {
        RuleFor(e => e.Salary).NotNull();
    }
}
