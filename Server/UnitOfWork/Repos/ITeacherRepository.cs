namespace myBase.Server;

public interface ITeacherRepository<TEntity> : IEmployeeRepository<TEntity> where TEntity : Teacher
{
}
