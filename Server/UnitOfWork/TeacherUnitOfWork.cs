namespace myBase.Server;

public class TeacherUnitOfWork<TEntity> : EmployeeUnitOfWork<TEntity>, ITeacherUnitOfWork<TEntity>
    where TEntity : Teacher
{
    public TeacherUnitOfWork(ITeacherRepository<TEntity> repository) : base(repository) { }
}
