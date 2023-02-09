namespace myBase.Server;

public interface IEmployeeRepository<TEntity> : IBaseNameRepository<TEntity> where TEntity : Employee
{
}
