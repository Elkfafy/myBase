namespace myBase.Server;

public interface ITeacherUnitOfWork<TEntity> : IEmployeeUnitOfWork<TEntity> where TEntity : Teacher
{
}
