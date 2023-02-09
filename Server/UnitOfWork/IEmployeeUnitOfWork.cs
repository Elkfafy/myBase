namespace myBase.Server;

public interface IEmployeeUnitOfWork<TEntity> : IBaseNameUnitOfWork<TEntity> where TEntity : Employee
{
}
