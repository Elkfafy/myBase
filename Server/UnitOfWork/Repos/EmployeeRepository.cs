namespace myBase.Server;

public class EmployeeRepository<TEntity> : BaseNameRepository<TEntity>, IEmployeeRepository<TEntity>
    where TEntity : Employee
{
    public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext) { }
}
