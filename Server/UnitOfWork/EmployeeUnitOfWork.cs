namespace myBase.Server;

public class EmployeeUnitOfWork<TEntity> : BaseNameUnitOfWork<TEntity>, IEmployeeUnitOfWork<TEntity>
    where TEntity : Employee
{
    public EmployeeUnitOfWork(IEmployeeRepository<TEntity> repository) : base(repository) { }
}
